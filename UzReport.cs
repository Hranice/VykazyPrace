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
    public partial class UzReport : Form
    {

        string oscis { get; set; }
        string date { get; set; }
        public UzReport()
        {
            InitializeComponent();
        }

        public UzReport(string OsCis, string Date)
        {
            InitializeComponent();
            oscis = OsCis;
            date = Date;
            FillDgv();
        }

        void FillDgv()
        {
            dataGridView1.RowHeadersVisible = false;
       
            List<Models.UzReport> uzReports = new List<Models.UzReport>();
            uzReports = Form1.dbint.DatasourceUzReport(date, Form1.dbint.GetUserInfoByOsCis(int.Parse(oscis)));


            foreach (Models.UzReport rec in uzReports)
            {
                try
                {
                    rec.ProjectID = Form1.dbint.GetProjectByProjectID(rec.ProjectID).NazevProjektu;
                }
                catch (NullReferenceException ex)
                {
                    Debug.WriteLine(ex.Message);

                    rec.ProjectID = Form1.dbint.GetZakazkaById(rec.ProjectID).Nazev;

                }



            }
            dataGridView1.DataSource = uzReports;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].HeaderText = "Název projektu";
        }
    }
}
