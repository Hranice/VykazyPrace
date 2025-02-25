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
    public partial class UcDaysOthers : UserControl
    {

        /// <summary>
        /// Den, datum a den v týdnu.
        /// </summary>
        string _day, date, _weekday;

        string Oscis = "";
        public UcDaysOthers()
        {
            InitializeComponent();
            buttonAddTime.Hide();
            buttonRemoveTime.Hide();
            labelDay.Hide();
            checkBox1.Hide();
            panelIndicator.Hide();
            this.Padding = new Padding(0);
        }

        public UcDaysOthers(string day, string OsCis)
        {


            InitializeComponent();
            _day = day;
            labelDay.Text = day;
            checkBox1.Hide();
            date = _day + "/" + Form1._month + "/" + Form1._year;
            buttonAddTime.Hide();
            buttonRemoveTime.Hide();
            checkBox1.Hide();


            UserInfo userTOFind = new();
            userTOFind = Form1.dbint.GetUserInfoByOsCis(int.Parse(OsCis));
            OsCis = userTOFind.OsCis.ToString();
            List<Record> records = new();
            try
            {
                records = Form1.dbint.GetRecordsByDateAndUser(date, userTOFind);
            }
            catch (Exception ex)
            {

            }
            if (records.Count == 0)
            {
                panelIndicator.BackColor = Color.Red;
            }
            else
            {
                double hoursWorked = 0;
                foreach (Record rec in records)
                {
                    hoursWorked += double.Parse(rec.Hours);
                }

                double tolerance = 0.00001;

                if (hoursWorked == 7.5)
                {
                    this.panel1.BackColor = Color.FromArgb(150, 140, 249, 171);
                    this.BackColor = Color.Transparent;


                }
                else if (hoursWorked < 7.5 && hoursWorked != 0)
                {
                    this.panel1.BackColor = Color.FromArgb(60, 245, 39, 39);
                    this.BackColor = Color.Transparent;

                }
                else if (hoursWorked > 7.5)
                {
                    this.panel1.BackColor = Color.FromArgb(60, 39, 69, 245);
                    this.BackColor = Color.Transparent;
                }
                else if (hoursWorked == 0)
                {

                }

            }
            Oscis = OsCis;
            ShowHoursDay(userTOFind.OsCis.ToString());
        }

        private void buttonAddTime_Click(object sender, EventArgs e)
        {                                                                                                          

        }
        void ShowHoursDay(string OsCis)
        {
            List<Record> records = new List<Record>();


            UserInfo usertofind = new();
            usertofind = Form1.dbint.GetUserInfoByOsCis(int.Parse(OsCis));

            records = Form1.dbint.GetRecordsByDateAndUser(date, usertofind);

            double hours = 0;
            if (records.Count != 0)
            {
                foreach (Record record in records)
                {
                    hours = hours + double.Parse(record.Hours);
                    if (record.Activity == "Dovolená")
                    {
                        labelTimeDoneDay.Text = "DOV";
                        break;
                    }
                    else
                    {
                        labelTimeDoneDay.Text = $"{hours.ToString()} h";

                    }
                }
            }


        }
        /// <summary>
        /// Změní barvu textu dne na základě toho, zda je neděle (červená) nebo jiný den (šedá).
        /// </summary>
        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                _weekday = day.ToString("ddd");
                if (_weekday == "ne")
                {
                    labelDay.ForeColor = Color.FromArgb(255, 128, 128); // Červená barva pro neděli
                }
                else
                {
                    labelDay.ForeColor = Color.FromArgb(64, 64, 64); // Šedá barva pro ostatní dny
                }
            }
            catch (Exception) { }
        }

        private void UcDaysOthers_Load(object sender, EventArgs e)
        {
            sundays();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            string formattedDate = this.labelDay.Text + "/" + Form1._month + "/" + Form1._year;
            ShowRecords SR = new ShowRecords(formattedDate, Oscis);
            SR.ShowDialog();
        }
    }
}
