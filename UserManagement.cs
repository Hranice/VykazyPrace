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

namespace VykazyPrace
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            FillDgv();
            EditDgv();
        }

        void EditDgv()
        {
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }

        void FillDgv()
        {
            dataGridView1.DataSource = Form1.dbint.GetAllUsersAuto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu by bylo načtení a asi smazání uživatele?");

            //User user = new User();
            //List<Record> records = new List<Record>();


            //user = Form1.dbint.GetUserByOsCis(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            //records = Form1.dbint.GetRecordsByUser(user);

            //Form1.dbint.RemoveUserAndRecords(user, records);

            //FillDgv();
            //EditDgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                // Validate numeric input for OsCis
                if (!int.TryParse(textBoxOsCis.Text, out int osCis))
                {
                    MessageBox.Show("Číslo musí být celé číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate non-empty Jmeno and Prijmeni
                if (string.IsNullOrWhiteSpace(textBoxJmeno.Text))
                {
                    MessageBox.Show("Jméno nesmí být prázdné.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxPrijmeni.Text))
                {
                    MessageBox.Show("Příjmení nesmí být prázdné.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure that the first letter exists for Substring() operation on Jmeno
                if (textBoxJmeno.Text.Length < 1)
                {
                    MessageBox.Show("Jméno je příliš krátké.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure Prijmeni has at least 1 character for the Substring() operation
                if (textBoxPrijmeni.Text.Length < 1)
                {
                    MessageBox.Show("Příjmení je příliš krátké.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string WinUsername = RemoveDiacritics(
                    string.Concat(textBoxJmeno.Text.Substring(0, 1), textBoxPrijmeni.Text)
                ).ToLower();

                UserInfo userInfo = new UserInfo()
                {
                    FirstName= textBoxJmeno.Text,
                    Surname= textBoxPrijmeni.Text,
                    WindowsUsername = WinUsername,
                    PersonalNumber= osCis
                };

                // Attempt to create the user in the database
                try
                {
                    //Form1.dbint.CreateUser(userInfo);
                    MessageBox.Show("Uživatel NEBYL CUZ JSEM SMAZAL CRUD byl úspěšně vytvořen.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    FillDgv();
                    EditDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při vytváření uživatele: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }





        private void textBoxPrijmeni_TextChanged(object sender, EventArgs e)
        {

        }







        public static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            // Normalize the string to decompose the characters
            var normalizedString = text.Normalize(NormalizationForm.FormD);

            // Create a StringBuilder to collect characters without diacritics
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            // Normalize back to Form C (composed characters) and return the result
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
