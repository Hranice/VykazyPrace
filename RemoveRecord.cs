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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;

namespace VykazyPrace
{
    public partial class RemoveRecord : Form
    {
        string Date { get; set; }
        public RemoveRecord()
        {
            InitializeComponent();
            FillDGV();
        }
        public RemoveRecord(string date)
        {
            InitializeComponent();
            Date = date;
            FillDGV();
            EditDGV();
        }

        void FillDGV()
        {
            List<Record> records = new List<Record>();
            records = Form1.dbint.GetRecordsByDate(Date);
            dataGridView1.DataSource = records;
            double hours = 0;
            foreach (Record rec in records)
            {
                if (Form1.dbint.GetProjectByProjectID(rec.ProjectId) is null)
                {
                    rec.ProjectId = "Ukončený projekt";
                }
                else
                {
                    rec.ProjectId = Form1.dbint.GetProjectByProjectID(rec.ProjectId).NazevProjektu;
                }
                hours = double.Parse(rec.Hours);
                rec.Hours = hours.ToString();
            }
        }

        void EditDGV()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[2].HeaderText = "Projekt";

            dataGridView1.Columns[2].Width = 111;
            dataGridView1.Columns[3].Width = 111;
            dataGridView1.Columns[4].Width = 111;
            dataGridView1.Columns[5].Width = 111;


            dataGridView1.Columns[2].HeaderText = "Projekt";
            dataGridView1.Columns[3].HeaderText = "Aktivita";
            dataGridView1.Columns[4].HeaderText = "Počet hodin";
            dataGridView1.Columns[5].HeaderText = "Osobní číslo";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Record record = Form1.dbint.GetRecordByID(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (Form1.dbint.RemoveRecord(record))
                {
                    MessageBox.Show("Záznam byl úspěšně smazán");
                    FillDGV();
                    EditDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nejsou další záznamy ke smazání nebo nastala následující chyba: {ex.Message}");
            }
        }
    }
}
