using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VykazyPrace.Models;

namespace VykazyPrace
{
    /// <summary>
    /// Formulář pro přidání nového časového záznamu (NewRecord).
    /// Umožňuje uživateli vybrat projekt, zadat aktivitu a počet minut.
    /// </summary>
    public partial class NewRecord : Form
    {



        /// <summary>
        /// Datum, ke kterému bude záznam přidán.
        /// </summary>
        string Date { get; set; }
        Record recordVac = new Record();

        /// <summary>
        /// Konstruktor, který inicializuje NewRecord s daným datem a načte všechny projekty.
        /// </summary>
        /// <param name="date">Datum, ke kterému bude časový záznam přiřazen.</param>
        public NewRecord(string date)
        {
            InitializeComponent();
            LoadProjects();
            LoadZakazky();
            Date = date;
            textBoxHours.Text = 1.ToString();
        }

        /// <summary>
        /// Načte všechny projekty z databáze a přidá je do comboBoxu pro výběr projektu.
        /// </summary>
        void LoadProjects()
        {
            List<Projekty> AllProject = new();

            AllProject = Form1.dbint.GetAllProjects().OrderBy(b => b.Id).ToList();

            foreach (Projekty projekty in AllProject)
            {
                if (projekty.OznaceniProjektu == Form1.dbint.GetProjektByName("Dovolená").OznaceniProjektu)
                {

                }
                else
                {
                    comboBox1.Items.Add(projekty.OznaceniProjektu + " - " + projekty.NazevProjektu);
                }
            }
        }

        void LoadZakazky()
        {
            List<Zakazky> AllZakazky = new();

            AllZakazky = Form1.dbint.GetAllZakazky().ToList();

            foreach (Zakazky zak in AllZakazky)
            {
                if (zak.TypZakazky == Form1.dbint.getZakazkaByName("DOVOLENÁ").TypZakazky)
                {

                }
                else
                {
                    // Ensure zak.CisloZakazky is treated as a string with a fixed length of 6 by padding with zeros
                    string cislo = zak.CisloZakazky.ToString().PadLeft(6, '0');

                    // Add the formatted string to the ComboBox
                    comboBoxZakazky.Items.Add(cislo + " " + zak.TypZakazky + " - " + zak.Nazev);
                }
            }
        }

        public event Action RecordCreated;
        /// <summary>
        /// Uloží nový záznam (Record) do databáze při kliknutí na tlačítko.
        /// </summary>
        /// <param name="sender">Zdroj události.</param>
        /// <param name="e">Argumenty události.</param>
        private void button1_Click(object sender, EventArgs e)
        {

            // Ensure that the project is selected in the ComboBox
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please select a project.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure that minutes are entered and valid
            if (!double.TryParse(textBoxHours.Text, out double hours) || hours <= 0)
            {
                MessageBox.Show("Please enter a valid number of hours (greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Record zaznam = new()
            {
                Activity = textBoxActivity.Text.ToString(),
                Hours = hours.ToString(),
                Date = Date
            };

            // Ensure ProjectId is valid
            var selectedProject = Form1.dbint.GetProjectByOznaceni(comboBox1.Text.Split("-")[0].Trim());
            if (selectedProject == null)
            {
                MessageBox.Show("Invalid project selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            zaznam.ProjectId = selectedProject.Id.ToString();

            // Assign OsCis from the current user
            if (string.IsNullOrEmpty(Form1.dbint.CurrentUserInfo?.PersonalNumber.ToString()))
            {
                MessageBox.Show("User identifier (OsCis) is missing or invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            zaznam.OsCis = Form1.dbint.CurrentUserInfo.PersonalNumber;


            if (checkBox2.Checked)
            {
                recordVac.Activity = "Dovolená";
                recordVac.Date = Date;
                recordVac.Hours = "7,5";
                recordVac.OsCis = Form1.dbint.CurrentUserInfo.PersonalNumber;
                recordVac.ProjectId = Form1.dbint.GetProjektByName("Dovolená").Id.ToString();

                Form1.dbint.SaveRecord(recordVac);
                MessageBox.Show("Úspěšně zaznamenáno");
                RecordCreated?.Invoke();
            }
            else
            {
                // If all validations pass, save the record

                zaznam.Hours = zaznam.Hours.Replace('.', ',');

                Form1.dbint.SaveRecord(zaznam);
                MessageBox.Show("Úspěšně zaznamenáno");
                RecordCreated?.Invoke();
            }
            this.Close();

        }

        private void NewRecord_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBoxActivity.Text = "Dovolená";
                textBoxHours.Text = 7.5.ToString();
                comboBox1.Text = Form1.dbint.GetProjektByName("Dovolená").OznaceniProjektu;
                textBoxActivity.Enabled = false;
                textBoxHours.Enabled = false;
                comboBox1.Enabled = false;



            }
            else
            {

                textBoxActivity.Text = "";
                textBoxHours.Text = "";
                comboBox1.Text = "";

                textBoxActivity.Enabled = true;
                textBoxHours.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxHours.Text = (double.Parse(textBoxHours.Text) + 0.5).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBoxHours.Text) == 0.5)
            {
            }
            else
            {
                textBoxHours.Text = (double.Parse(textBoxHours.Text) - 0.5).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = (double.Parse(textBox2.Text) + 0.5).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox2.Text) == 0.5)
            {
            }
            else
            {
                textBox2.Text = (double.Parse(textBox2.Text) - 0.5).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Ensure that the project is selected in the ComboBox
            if (string.IsNullOrEmpty(comboBoxZakazky.Text))
            {
                MessageBox.Show("Vyberte zakázku.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure that minutes are entered and valid
            if (!double.TryParse(textBox2.Text, out double hours) || hours <= 0)
            {
                MessageBox.Show("Please enter a valid number of hours (greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Record zaznam = new()
            {
                Activity = textBox1.Text.ToString(),
                Hours = hours.ToString(),
                Date = Date,
                Zakazka = 1
            };

            // Ensure ProjectId is valid
            var selectedProject = Form1.dbint.GetZakazkaByOznaceni(comboBoxZakazky.Text.Split(" ")[0].Trim());
            if (selectedProject == null)
            {
                MessageBox.Show("Invalid project selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            zaznam.ProjectId = selectedProject.Id.ToString();

            // Assign OsCis from the current user
            if (string.IsNullOrEmpty(Form1.dbint.CurrentUserInfo?.PersonalNumber.ToString()))
            {
                MessageBox.Show("User identifier (OsCis) is missing or invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            zaznam.OsCis = Form1.dbint.CurrentUserInfo.PersonalNumber;
            

            if (checkBox1.Checked)
            {
                recordVac.Activity = "Dovolená";
                recordVac.Date = Date;
                recordVac.Hours = "7,5";
                recordVac.OsCis = Form1.dbint.CurrentUserInfo.PersonalNumber;
                recordVac.ProjectId = Form1.dbint.GetProjektByName("Dovolená").Id.ToString();

                Form1.dbint.SaveRecord(recordVac);
                MessageBox.Show("Úspěšně zaznamenáno");
                RecordCreated?.Invoke();
            }
            else
            {
                // If all validations pass, save the record

                zaznam.Hours = zaznam.Hours.Replace('.', ',');

                Form1.dbint.SaveRecord(zaznam);
                MessageBox.Show("Úspěšně zaznamenáno");
                RecordCreated?.Invoke();
            }
            this.Close();
        }
    }
}
