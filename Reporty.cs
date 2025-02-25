using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VykazyPrace.Models;
using static System.Net.Mime.MediaTypeNames;

namespace VykazyPrace
{
    public partial class Reporty : Form
    {
        public string Date { get; set; }
        public Reporty(string date)
        {
            InitializeComponent();
            Date = date;

            InitLabels();
            FillComboBoxes();
        }

        void FillComboBoxes()
        {
            List<Projekty> projekty = new List<Projekty>();
            List<UserInfo> users = new List<UserInfo>();
            users = Form1.dbint.GetAllUsersAuto();
            projekty = Form1.dbint.GetAllProjects();
            comboBoxProjekty.Items.Clear();
            comboBoxZamestnanci.Items.Clear();


            foreach (UserInfo us in users)
            {
                comboBoxZamestnanci.Items.Add($"{us}");
                comboBoxZamestnanecSmall.Items.Add($"{us}");
            }

            foreach (Projekty proj in projekty)
            {
                comboBoxProjekty.Items.Add($"{proj.OznaceniProjektu} {proj.NazevProjektu}");
                comboBoxProjektySmall.Items.Add($"{proj.OznaceniProjektu} {proj.NazevProjektu}");
            }
        }

        void InitLabels()
        {
            CultureInfo czechCulture = new CultureInfo("cs-CZ");
            string monthName = czechCulture.DateTimeFormat.GetMonthName(Form1._month);
            label1.Text = $"Součet hodin na projektu za měsíc";


            label2.Text = $"Součet hodin zaměstnance";

            label3.Text = $"Součet hodin zaměstnance na konkrétním projektu";

            label4.Text = $"{monthName}".ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Record> records = new List<Record>();

            // Kontrola, zda je datum platné
            if (Date == null || Date == DateTime.MinValue.ToString())
            {
                MessageBox.Show("Prosím, vyberte platné datum.", "Neplatné datum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kontrola, zda je vybrán projekt
            if (string.IsNullOrEmpty(comboBoxProjekty.Text))
            {
                MessageBox.Show("Prosím, vyberte projekt.", "Neplatný projekt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rozdělení názvu projektu a kontrola, zda je platný
            var selectedProject = comboBoxProjekty.Text.Split(" ")[0];
            if (string.IsNullOrEmpty(selectedProject))
            {
                MessageBox.Show("Prosím, vyberte platný projekt.", "Neplatný projekt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Načtení záznamů, pokud je validace úspěšná
            records = Form1.dbint.GetRecordsByMonthAndProject(Date, selectedProject);
            double PocetHodin = 0;
            double pocetMinut = 0;
            foreach (Record rec in records)
            {
                pocetMinut += Double.Parse(rec.Hours) * 60;

            }

            PocetHodin = pocetMinut / 60;
            CultureInfo czechCulture = new CultureInfo("cs-CZ");
            MessageBox.Show($"Za měsíc {czechCulture.DateTimeFormat.GetMonthName(int.Parse(Date.Split("/")[1]))} se na projektu {Form1.dbint.GetProjectByOznaceni(comboBoxProjekty.Text.Split(" ")[0]).NazevProjektu} odpracovalo {PocetHodin} hodin.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Set the Czech culture for date formatting
            CultureInfo czechCulture = new CultureInfo("cs-CZ");

            // Initialize necessary variables
            List<Record> records = new List<Record>();
            UserInfo user = new UserInfo();

            try
            {
                // Validate and get the selected user
                if (string.IsNullOrWhiteSpace(comboBoxZamestnanci.Text))
                {
                    MessageBox.Show("Vyberte platného zaměstnance.");
                    return;
                }
                string userCode = comboBoxZamestnanci.Text.Split(" - ")[1];
                user = Form1.dbint.GetUserInfoByOsCis(int.Parse(userCode));

                // Validate and check the date format
                string[] dateParts = Date.Split("/");
                if (dateParts.Length != 3 || !int.TryParse(dateParts[1], out int month))
                {
                    MessageBox.Show("Neplatný formát data.");
                    return;
                }

                // Get records for the user based on the month and user
                records = Form1.dbint.GetAllRecordsByMonthAndUser(Date, user);

              
                double hoursVacation = 0;
                double hoursProvoz = 0;
                double hoursOther = 0;
                // Iterate through records and calculate time for vacation, provoz, and other projects
                foreach (Record rec in records)
                {
                    string projectCode = Form1.dbint.GetProjectByProjectID(rec.ProjectId).OznaceniProjektu.ToString();

                    if (projectCode == Form1.dbint.GetProjektByName("Dovolená").OznaceniProjektu)
                    {
                        hoursVacation += double.Parse(rec.Hours);
                    }
                    else if (projectCode == Form1.dbint.GetProjektByName("Provoz").OznaceniProjektu)
                    {
                        hoursProvoz += double.Parse(rec.Hours);
                    }
                    else
                    {
                        hoursOther += double.Parse(rec.Hours);
                    }
                }

                // Convert minutes to hours
                

                // Display the result in a message box
                string monthName = czechCulture.DateTimeFormat.GetMonthName(month);
                MessageBox.Show($"Zaměstnanec {user.FirstName} {user.Surname} evidoval za měsíc {monthName} {hoursOther} hodin na projektech, {hoursProvoz} hodin v provozu a {hoursVacation} hodin dovolené.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Chyba formátování. Zkontrolujte vstupní data.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo k neočekávané chybě: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Set the Czech culture for date formatting
            CultureInfo czechCulture = new CultureInfo("cs-CZ");

            // Initialize an empty list for filtered records
            List<Record> filteredRecords = new();

            try
            {
                // Validate and get the selected project ID
                if (string.IsNullOrWhiteSpace(comboBoxProjektySmall.Text))
                {
                    MessageBox.Show("Vyberte platný projekt.");
                    return;
                }
                string projectCode = comboBoxProjektySmall.Text.Split(" ")[0];
                string idProject = Form1.dbint.GetProjectByOznaceni(projectCode).Id.ToString();

                // Validate and get the selected user ID (OsCis)
                if (string.IsNullOrWhiteSpace(comboBoxZamestnanecSmall.Text))
                {
                    MessageBox.Show("Vyberte platného zaměstnance.");
                    return;
                }
                string userCode = comboBoxZamestnanecSmall.Text.Split(" - ")[1];
                string OsCisUser = Form1.dbint.GetUserInfoByOsCis(int.Parse(userCode)).PersonalNumber.ToString();

                // Retrieve records filtered by project and user
                filteredRecords = Form1.dbint.GetRecordsByProjectAndUser(idProject, OsCisUser);

                // Check if there are any records
                if (filteredRecords == null || filteredRecords.Count == 0)
                {
                    MessageBox.Show("Uživatel nemá žádný záznam v tomto projektu.");
                    return;
                }

                // Calculate total minutes worked
                double hoursWorked = 0;
                foreach (Record rec in filteredRecords)
                {
                    hoursWorked += double.Parse(rec.Hours);
                }

                // Calculate hours worked
               

                // Extract user and project details for the message
                string userName = $"{Form1.dbint.GetUserInfoByOsCis(filteredRecords[0].OsCis).FirstName} {Form1.dbint.GetUserInfoByOsCis(filteredRecords[0].OsCis).Surname}";
                string projectName = Form1.dbint.GetProjectByProjectID(filteredRecords[0].ProjectId).NazevProjektu;

                // Assuming 'Date' is a string in the format "dd/MM/yyyy", validate and extract the month
                string[] dateParts = Date.Split("/");
                if (dateParts.Length != 3)
                {
                    MessageBox.Show("Neplatný formát data.");
                    return;
                }
                int month = int.Parse(dateParts[1]);
                string monthName = czechCulture.DateTimeFormat.GetMonthName(month);

                // Display the final message
                MessageBox.Show($"Zaměstnanec {userName} strávil na projektu {projectName} za měsíc {monthName} {hoursWorked} hodin");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Chyba formátování. Zkontrolujte vstupní data.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Uživatel nemá žádný záznam v tomto projektu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo k neočekávané chybě: {ex.Message}");
            }



        }
    }
}
