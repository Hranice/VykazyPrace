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
    /// Uživatelský ovládací prvek ucDay, který zobrazuje den a poskytuje funkcionalitu pro manipulaci s časovými záznamy.
    /// </summary>
    public partial class ucDay : UserControl
    {
        /// <summary>
        /// Den, datum a den v týdnu.
        /// </summary>
        string _day, date, _weekday;

        /// <summary>
        /// Konstruktor, který inicializuje ucDay s konkrétním dnem.
        /// </summary>
        /// <param name="day">Den, který má být zobrazen.</param>
        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            labelDay.Text = day;
            checkBox1.Hide();
            date = _day + "/" + Form1._month + "/" + Form1._year;



            List<Record> records = new();
            try
            {
                records = Form1.dbint.GetRecordsByDate(date);
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

            ShowHoursDay();



        }




        /// <summary>
        /// Výchozí konstruktor, který inicializuje prvek ucDay bez zobrazení tlačítek a dalších ovládacích prvků.
        /// </summary>
        public ucDay()
        {
            InitializeComponent();
            buttonAddTime.Hide();
            buttonRemoveTime.Hide();
            labelDay.Hide();
            checkBox1.Hide();
            panelIndicator.Hide();
            this.Padding = new Padding(0);

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

        /// <summary>
        /// Při načtení ovládacího prvku ucDay zavolá metodu sundays pro nastavení barvy dne.
        /// </summary>
        private void ucDay_Load(object sender, EventArgs e)
        {
            sundays();
        }



        /// <summary>
        /// Otevře dialogové okno pro přidání nového časového záznamu na daný den.
        /// </summary>
        private void buttonAddTime_Click(object sender, EventArgs e)
        {
            string formattedDate = this.labelDay.Text + "/" + Form1._month + "/" + Form1._year;
            NewRecord nr = new(formattedDate);
            nr.RecordCreated += NewRecordForm_RecordCreated;

            nr.ShowDialog();
        }

        void ShowHoursDay()
        {
            List<Record> records = new List<Record>();

            records = Form1.dbint.GetRecordsByDate(date);

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
        private void NewRecordForm_RecordCreated()
        {
            // Access Form1 to trigger the update method
            var parentForm = this.FindForm() as Form1;
            if (parentForm != null)
            {
                // Call the ShowDays method from Form1
                parentForm.ShowDays(DateTime.Now.Month, DateTime.Now.Year);
            }
        }

        /// <summary>
        /// (Neimplementovaná) metoda pro odstranění časového záznamu.
        /// </summary>
        private void buttonRemoveTime_Click(object sender, EventArgs e)
        {
            string formattedDate = this.labelDay.Text + "/" + Form1._month + "/" + Form1._year;
            RemoveRecord rr = new(formattedDate);
            rr.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string formattedDate = this.labelDay.Text + "/" + Form1._month + "/" + Form1._year;
            ShowRecords SR = new ShowRecords(formattedDate);
            SR.ShowDialog();
        }
    }
}
