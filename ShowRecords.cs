using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VykazyPrace.Models;

namespace VykazyPrace
{
    public partial class ShowRecords : Form
    {
        public string Date { get; set; }

        /// <summary>
        /// Default constructor for ShowRecords form.
        /// </summary>
        public ShowRecords()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for ShowRecords form that takes a date string.
        /// </summary>
        /// <param name="date">The date to filter the records by.</param>
        public ShowRecords(string date)
        {
            InitializeComponent();
            Date = date;
            FillDGV();
            EditDGV();
        }

        public ShowRecords(string date,string OsCis)
        {
            InitializeComponent();
            Date = date;
            FillDGV();
            EditDGV();
            radioButtonConcreteWorker.Checked = true;
            radioButtonAllRecords.Enabled = false;
            radioButtonMyRecords.Enabled = false;
            radioButtonProjects.Enabled = false;
            comboBoxUsers.Enabled = false;
            radioButtonConcreteWorker.Enabled = false;
            FillDgvConcreteUser(int.Parse(OsCis));

        }


       

        /// <summary>
        /// Updates control permissions based on the current user's level of access (Loa).
        /// </summary>
        void UpdateControlsByPriviligies()
        {
            if (Form1.dbint.CurrentUserInfo.LevelOfAccess == 1)
            {
                radioButtonAllRecords.Enabled = false;
                radioButtonConcreteWorker.Enabled = false;
                radioButtonProjects.Enabled = false;
                comboBoxProjects.Enabled = false;
            }
            else if (Form1.dbint.CurrentUserInfo.LevelOfAccess > 1)
            {
                radioButtonConcreteWorker.Enabled = true;
                radioButtonAllRecords.Enabled = true;
                radioButtonProjects.Enabled = true;
                comboBoxProjects.Enabled = true;
            }
        }

        /// <summary>
        /// Fills the DataGridView with records filtered by the selected date.
        /// </summary>
        void FillDGV()
        {
            List<Record> records = Form1.dbint.GetRecordsByDate(Date);
            dataGridView1.DataSource = records;
            double hours = 0;

            foreach (Record rec in records)
            {
                if (rec.Zakazka == 1)
                {
                    if (Form1.dbint.GetZakazkaById(rec.ProjectId.ToString()) is null)
                    {
                        rec.ProjectId = Form1.dbint.GetZakazkyArchiveById(rec.ProjectId.ToString()).Nazev ;
                    }
                    else
                    {
                        rec.ProjectId = Form1.dbint.GetZakazkaById(rec.ProjectId.ToString()).Nazev;
                    }
                }
                else
                {
                    if (Form1.dbint.GetProjectByProjectID(rec.ProjectId) is null)
                    {

                        rec.ProjectId = Form1.dbint.GetProjectByProjectIDArchive(rec.ProjectId).Nazev;

                    }
                    else
                    {
                        rec.ProjectId = Form1.dbint.GetProjectByProjectID(rec.ProjectId).NazevProjektu;
                    }
                }
                hours = double.Parse(rec.Hours);
                rec.Hours = hours.ToString();
            }
        }

        /// <summary>
        /// Fills the DataGridView with records for a specific user, filtered by the selected date.
        /// </summary>
        /// <param name="Oscis">The user identifier.</param>
        void FillDgvConcreteUser(int Oscis)
        {
            List<Record> records = Form1.dbint.GetRecordsByDateAndUser(Date, Oscis);
            dataGridView1.DataSource = records;
            double hours = 0;
            foreach (Record rec in records)
            {
                if (rec.Zakazka == 1)
                {
                    if (Form1.dbint.GetZakazkaById(rec.ProjectId) is null)
                    {
                        rec.ProjectId = Form1.dbint.GetZakazkyArchiveById(rec.ProjectId).Nazev;
                    }
                    else
                    {
                        rec.ProjectId = Form1.dbint.GetZakazkaById(rec.ProjectId).Nazev;
                    }
                }
                else
                {
                    if (Form1.dbint.GetProjectByProjectID(rec.ProjectId) is null)
                    {
                        rec.ProjectId = Form1.dbint.GetProjectByProjectIDArchive(rec.ProjectId).Nazev;
                    }
                    else
                    {

                        rec.ProjectId = Form1.dbint.GetProjectByProjectID(rec.ProjectId).NazevProjektu;
                    }
                }
                hours = double.Parse(rec.Hours);
                rec.Hours = hours.ToString();
            }
        }

        /// <summary>
        /// Fills the DataGridView with records for all users, filtered by the selected date.
        /// </summary>
        void FillDGVAllUsers()
        {
            List<Record> records = Form1.dbint.GetRecordsAllByDate(Date);
            dataGridView1.DataSource = records;
            double hours = 0;
            foreach (Record rec in records)
            {
                if (rec.Zakazka == 1)
                {
                    if(Form1.dbint.GetZakazkaById(rec.ProjectId) is null)
                    {
                        rec.ProjectId = Form1.dbint.GetZakazkyArchiveById(rec.ProjectId).Nazev;
                    }
                    else
                    {
                    rec.ProjectId = Form1.dbint.GetZakazkaById(rec.ProjectId).Nazev;
                    }
                }
                else
                {
                    if (Form1.dbint.GetProjectByProjectID(rec.ProjectId) is null)
                    {
                        rec.ProjectId = Form1.dbint.GetProjectByProjectIDArchive(rec.ProjectId).Nazev;
                    }
                    else
                    {

                        rec.ProjectId = Form1.dbint.GetProjectByProjectID(rec.ProjectId).NazevProjektu;
                    }
                }
                hours = double.Parse(rec.Hours);
                rec.Hours = hours.ToString();
            }
        }

        /// <summary>
        /// Edits the DataGridView column headers and visibility.
        /// </summary>
        void EditDGV()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[2].HeaderText = "Projekt";
            dataGridView1.Columns[3].HeaderText = "Aktivita";
            dataGridView1.Columns[4].HeaderText = "Počet hodin";
            dataGridView1.Columns[5].HeaderText = "Osobní číslo";

            dataGridView1.Columns[2].Width = 111;
            dataGridView1.Columns[3].Width = 111;
            dataGridView1.Columns[4].Width = 111;
            dataGridView1.Columns[5].Width = 111;
        }

        /// <summary>
        /// Fills the combobox with projects from the database.
        /// </summary>
        private void FillComboboxWithProjects()
        {
            List<Projekty> allProjects = Form1.dbint.GetAllProjects();

            foreach (Projekty projekty in allProjects)
            {
                comboBoxProjects.Items.Add(projekty);
            }
        }

        /// <summary>
        /// Handles the Concrete Worker radio button check change event.
        /// Enables or disables the user selection combobox.
        /// </summary>
        private void radioButtonConcreteWorker_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConcreteWorker.Checked)
            {
                comboBoxUsers.Enabled = true;
                comboBoxUsers.Items.Clear();
            }
            else
            {
                comboBoxUsers.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the All Records radio button check change event.
        /// Fills the DataGridView with records for all users.
        /// </summary>
        private void radioButtonAllRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAllRecords.Checked && !radioButtonConcreteWorker.Checked)
            {
                FillDGVAllUsers();
                EditDGV();
            }
        }

        /// <summary>
        /// Handles the My Records radio button check change event.
        /// Fills the DataGridView with records for the current user.
        /// </summary>
        private void radioButtonMyRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMyRecords.Checked)
            {
                FillDGV();
                EditDGV();
            }
        }

        /// <summary>
        /// Handles the User selection combobox change event.
        /// Fills the DataGridView with records for the selected user.
        /// </summary>
        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Projects radio button check change event.
        /// Enables or disables the project selection combobox.
        /// </summary>
        private void radioButtonProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProjects.Checked)
            {
                comboBoxProjects.Enabled = true;
                comboBoxProjects.Items.Clear();
                FillComboboxWithProjects();
            }
            else
            {
                comboBoxProjects.Enabled = false;
            }
        }



        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.dbint.GetRecordsByDateAndProject(Date, (comboBoxProjects.SelectedItem as Projekty).Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
