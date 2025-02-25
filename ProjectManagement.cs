using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VykazyPrace.Models;

namespace VykazyPrace
{
    public partial class ProjectManagement : Form
    {
        public ProjectManagement()
        {
            InitializeComponent();
            FillDgvWithProjects();
            FillDgvWithZakazky();
            EditDgv();
            EditDgvZakazky();
            FillBoxes();
            FillComboboxWithUser();
        }

        void EditDgvZakazky()
        {
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Width = 52;
            dataGridView2.Columns[2].Width = 52;
            dataGridView2.Columns[3].Width = 200;
            dataGridView2.Columns[4].Width = 85;
            dataGridView2.Columns[5].Width = 104;


            dataGridView2.Columns[1].HeaderText = "Číslo zakázky";
            dataGridView2.Columns[2].HeaderText = "Typ zakázky";
            dataGridView2.Columns[3].HeaderText = "Název";
            dataGridView2.Columns[4].HeaderText = "Autor";
            dataGridView2.Columns[5].HeaderText = "Poznámka";
        }
        void EditDgv()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 118;
            dataGridView1.Columns[2].Width = 119;

            dataGridView1.Columns[1].HeaderText = "Označení projektu";
            dataGridView1.Columns[2].HeaderText = "Název projektu";
        }

        void FillDgvWithZakazky()
        {
            List<Zakazky> allZakazky = new();
            allZakazky = Form1.dbint.GetAllZakazky();
            List<Zakazky> Filtered = new();
            foreach (Zakazky zak in allZakazky)
            {
                if (zak.TypZakazky == Form1.dbint.getZakazkaByName("DOVOLENÁ").TypZakazky)
                {

                }
                else
                {
                    Filtered.Add(zak);
                }
            }
            dataGridView2.DataSource = Filtered;
        }

        void FillDgvWithProjects()
        {
            List<Projekty> allProject = new();
            allProject = Form1.dbint.GetAllProjects();
            List<Projekty> filtered = new();
            foreach (Projekty proj in allProject)
            {
                try
                {

                if (proj.OznaceniProjektu == Form1.dbint.GetProjektByName("Dovolená").OznaceniProjektu ||
                    proj.OznaceniProjektu == Form1.dbint.GetProjektByName("Provoz").OznaceniProjektu ||
                    proj.OznaceniProjektu == Form1.dbint.GetProjektByName("Meeting").OznaceniProjektu ||
                    proj.OznaceniProjektu == Form1.dbint.GetProjektByName("Laserovani").OznaceniProjektu ||
                    proj.OznaceniProjektu == Form1.dbint.GetProjektByName("Pripravky").OznaceniProjektu)
                {
                }
                else
                {
                    filtered.Add(proj);
                }
                }
                catch(NullReferenceException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            dataGridView1.DataSource = filtered;

        }

        void FillBoxes()
        {
            textBoxDovolena.Text = Form1.dbint.GetProjektByName("Dovolená").OznaceniProjektu;
            textBoxProvoz.Text = Form1.dbint.GetProjektByName("Provoz").OznaceniProjektu;
            textBoxLaserovani.Text = Form1.dbint.GetProjektByName("Laserovani").OznaceniProjektu;
            textBoxMeeting.Text = Form1.dbint.GetProjektByName("Meeting").OznaceniProjektu;
            textBoxPripravky.Text = Form1.dbint.GetProjektByName("Pripravky").OznaceniProjektu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate that both text fields have been filled
            if (string.IsNullOrWhiteSpace(textBoxProjectName.Text) || string.IsNullOrWhiteSpace(textBoxProjectOznaceni.Text))
            {
                MessageBox.Show("Please enter both the project name and project code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }

            // If validation passes, proceed with creating the project
            Projekty projekty = new Projekty()
            {
                NazevProjektu = textBoxProjectName.Text,
                OznaceniProjektu = textBoxProjectOznaceni.Text,
            };

            Form1.dbint.AddProject(projekty);
            MessageBox.Show("Projekt úspěšně přidán.");
            FillDgvWithProjects();
            EditDgv();
            LogCreateProject(projekty);

        }

        void LogCreateProject(Projekty projekt)
        {
            Log log = new()
            {
                UserId = Form1.dbint.CurrentUserInfo.Id.ToString(),
                Action = "Create",
                ActionId = projekt.Id.ToString(),
                Date = DateTime.Today.ToString("dd/MM/yyyy"),

            };
            //Form1.dbint.SaveLog(log);
        }

        void LogCreateZakazky(Zakazky projekt)
        {
            Log log = new()
            {
                UserId = Form1.dbint.CurrentUserInfo.Id.ToString(),
                Action = "Create",
                ActionId = projekt.Id.ToString(),
                Date = DateTime.Today.ToString("dd/MM/yyyy"),

            };
            //Form1.dbint.SaveLog(log);
        }

        void LogRemoveProject(Projekty projekt)
        {
            Log log = new()
            {
                Action = "Remove",
                ActionId = projekt.Id.ToString(),
                UserId = Form1.dbint.CurrentUserInfo.Id.ToString(),
                Date = DateTime.Today.ToString("dd/MM/yyyy"),
            };
            //Form1.dbint.SaveLog(log);

        }

        void LogRemoveZakazka(Zakazky projekt)
        {
            Log log = new()
            {
                Action = "Remove",
                ActionId = projekt.Id.ToString(),
                UserId = Form1.dbint.CurrentUserInfo.Id.ToString(),
                Date = DateTime.Today.ToString("dd/MM/yyyy"),
            };
            //Form1.dbint.SaveLog(log);

        }



        private void button2_Click(object sender, EventArgs e)
        {

            List<Record> records = new List<Record>();






            Projekty projekt = new();

            projekt = Form1.dbint.GetProjectByOznaceni(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

            ProjectArchive archivProjekt = new()
            {
                Id = projekt.Id,
                Nazev = projekt.NazevProjektu,
                Oznaceni = projekt.OznaceniProjektu,
            };
            Form1.dbint.db.ProjectArchives.Add(archivProjekt);
            Form1.dbint.db.SaveChanges();

            LogRemoveProject(projekt);

            records = Form1.dbint.GetRecordsByProject(projekt);

            Form1.dbint.removeRecords(records);
            Form1.dbint.RemoveProject(projekt);
            MessageBox.Show("Projekt a jeho záznamy úspěšně smazány.");

            FillDgvWithProjects();
            EditDgv();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Projekty projekt = new();

            projekt = Form1.dbint.GetProjectByOznaceni(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

            ProjectArchive archivProjekt = new()
            {
                Id = projekt.Id,
                Nazev = projekt.NazevProjektu,
                Oznaceni = projekt.OznaceniProjektu,
            };
            Form1.dbint.db.ProjectArchives.Add(archivProjekt);
            Form1.dbint.db.SaveChanges();

            LogRemoveProject(projekt);

            List<Record> records = new();
            records = Form1.dbint.GetRecordsByProject(projekt);

            foreach (Record rec in records)
            {
                rec.Archive = 1;
            }



            Form1.dbint.RemoveProject(projekt);
            MessageBox.Show("Projekt byl ukončen.");

            FillDgvWithProjects();
            EditDgv();
        }

        private void button4_Click(object sender, EventArgs e)
        {



            Projekty projekt = new();
            projekt = Form1.dbint.GetProjektByName("Dovolená");
            projekt.OznaceniProjektu = textBoxDovolena.Text;
            Form1.dbint.SaveProjekt(projekt);
            MessageBox.Show("Úspěšně změněno");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Projekty projekt = new();
            projekt = Form1.dbint.GetProjektByName("Provoz");
            projekt.OznaceniProjektu = textBoxProvoz.Text;
            Form1.dbint.SaveProjekt(projekt);
            MessageBox.Show("Úspěšně změněno");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Projekty projekt = new();
            projekt = Form1.dbint.GetProjektByName("Meeting");
            projekt.OznaceniProjektu = textBoxMeeting.Text;
            Form1.dbint.SaveProjekt(projekt);
            MessageBox.Show("Úspěšně změněno");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Projekty projekt = new();
            projekt = Form1.dbint.GetProjektByName("Laserovani");
            projekt.OznaceniProjektu = textBoxLaserovani.Text;
            Form1.dbint.SaveProjekt(projekt);
            MessageBox.Show("Úspěšně změněno");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Projekty projekt = new();
            projekt = Form1.dbint.GetProjektByName("Pripravky");
            projekt.OznaceniProjektu = textBoxPripravky.Text;
            Form1.dbint.SaveProjekt(projekt);
            MessageBox.Show("Úspěšně změněno");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Record> records = new List<Record>();



            Zakazky zakazka = new();

            zakazka = Form1.dbint.GetZakazkaByOznaceni(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());


            ZakazkyArchive archivZakazka = new()
            {
                Id = zakazka.Id,
                Nazev = zakazka.Nazev,
                CisloZakazky = zakazka.CisloZakazky,
                Poznamky = zakazka.Poznamky,
                TypZakazky = zakazka.TypZakazky,
                Autor = zakazka.Autor
            };
            Form1.dbint.db.ZakazkyArchives.Add(archivZakazka);
            Form1.dbint.db.SaveChanges();

            LogRemoveZakazka(zakazka);

            records = Form1.dbint.GetRecordsByZakazka(zakazka);

            Form1.dbint.removeRecords(records);
            Form1.dbint.RemoveZakazka(zakazka);
            MessageBox.Show("Zakázka a její záznamy úspěšně smazány.");

            FillDgvWithZakazky();
            EditDgvZakazky();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Zakazky projekt = new();

            projekt = Form1.dbint.GetZakazkaByOznaceni(dataGridView2.SelectedRows[0].Cells[1].Value.ToString());

            ZakazkyArchive archivProjekt = new()
            {
                Id = projekt.Id,
                Nazev = projekt.Nazev,
                Autor = projekt.Autor,
                CisloZakazky = projekt.CisloZakazky,
                Poznamky = projekt.Poznamky,
                TypZakazky = projekt.TypZakazky
            };
            Form1.dbint.db.ZakazkyArchives.Add(archivProjekt);
            Form1.dbint.db.SaveChanges();

            LogRemoveZakazka(projekt);

            List<Record> records = new();
            records = Form1.dbint.GetRecordsByZakazka(projekt);

            foreach (Record rec in records)
            {
                rec.Archive = 1;
            }



            Form1.dbint.RemoveZakazka(projekt);
            MessageBox.Show("Zakázka byla ukončena.");

            FillDgvWithZakazky();
            EditDgvZakazky();
        }
        void FillComboboxWithUser()
        {
            List<UserInfo> allusers = Form1.dbint.GetAllUsersAuto();
            foreach(UserInfo user in allusers)
            {
                comboBox2.Items.Add($"{user.Jmeno} {user.Prijmeni}");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Zakazky novaZakazka = new();

            // Validate CisloZakazky
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !int.TryParse(textBox2.Text, out int cisloZakazky))
            {
                MessageBox.Show("Číslo zakázky musí být platné číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if validation fails
            }
            novaZakazka.CisloZakazky = cisloZakazky;

            // Validate TypZakazky selection
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Prosím vyberte typ zakázky.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if validation fails
            }

            string typZakazky;
            if (comboBox1.Text == "Interní")
            {
                typZakazky = $"I{DateTime.Now.Year.ToString().Substring(2, 2)}"; // Corrected substring index
            }
            else
            {
                typZakazky = $"E{DateTime.Now.Year.ToString().Substring(2, 2)}"; // Corrected substring index
            }
            novaZakazka.TypZakazky = typZakazky;

            // Validate Nazev
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Název zakázky nesmí být prázdný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if validation fails
            }
            novaZakazka.Nazev = textBox1.Text;

            // Validate Autor
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Prosím vyberte autora zakázky.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if validation fails
            }
            novaZakazka.Autor = comboBox2.Text;

            // Validate Poznamky (optional)
            if (textBox3.Text.Length > 500) // Assuming a max length for example
            {
                MessageBox.Show("Poznámky mohou mít maximálně 500 znaků.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if validation fails
            }
            novaZakazka.Poznamky = textBox3.Text;

            // Create Zakazka if all validations pass
            Form1.dbint.CreateZakazka(novaZakazka);
            MessageBox.Show("Zakázka úspěšně vytvořena.");
            LogCreateZakazky(novaZakazka);


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
