using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using VykazyPrace.Models;

namespace VykazyPrace
{
    public partial class Form1 : Form
    {
        public static int _year, _month;
        public static DBInteractor dbint = new();
        string WinUserName = Environment.UserName;

        

        public Form1()
        {
            InitializeComponent();
            InitializeUser();
            //FillListBoxLog();
        }



        /// <summary>
        /// Initializes the user interface and user information.
        /// </summary>
        void InitializeUser()
        {
            try
            {
                GetUserFromDatabase();
                LoadUserInfoPanel();
                SetButtonsByPermission();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }



        void FillListBoxLog()
        {


            List<Log> Logs = new();
            Logs = Form1.dbint.GetLogs();
            if (Logs.Count == 0)
            {
                return;
            }
            int i = 0;
            foreach (Log log in Logs)
            {

                if (i == 9)
                {
                    break;
                }
                else
                {
                    UserInfo user = Form1.dbint.GetAllUsersAuto().FirstOrDefault(b => b.Id.ToString() == log.UserId);
                    Projekty projekt = Form1.dbint.GetProjectByProjectID(log.ActionId);
                    Zakazky zak = new();
                    string message = "";

                    if (projekt is null)
                    {
                        zak = Form1.dbint.GetZakazkaById(log.ActionId);
                        if (Form1.dbint.GetRecordsByZakazka(zak).FirstOrDefault().Zakazka == 1)
                        {
                            zak = Form1.dbint.GetZakazkaById(log.ActionId);
                            if (zak is null)
                            {
                                //archive
                                ZakazkyArchive projectArchive = new ZakazkyArchive();
                                projectArchive = Form1.dbint.GetZakazkyArchiveById(log.ActionId);
                                message = $"Uživatel {user.Jmeno} {user.Prijmeni} provedl èinnost {log.Action} s objektem {zak.CisloZakazky} - {zak.Nazev}";


                            }
                            else
                            {
                                message = $"Uživatel {user.Jmeno} {user.Prijmeni} provedl èinnost {log.Action} s objektem {zak.CisloZakazky} - {zak.Nazev}";

                            }




                        }
                        else
                        {
                            if (projekt != null)
                            {
                                message = $"Uživatel {user.Jmeno} {user.Prijmeni} provedl èinnost {log.Action} s objektem {projekt.OznaceniProjektu} - {projekt.NazevProjektu}";

                            }
                            else
                            {
                                //Nastavit aby to sáhlo do archivu když není v aktivních
                                ProjectArchive projectArchive = new ProjectArchive();
                                projectArchive = Form1.dbint.GetProjectByProjectIDArchive(log.ActionId);
                                message = $"Uživatel {user.Jmeno} {user.Prijmeni} provedl èinnost {log.Action} s objektem {projectArchive.Oznaceni} - {projectArchive.Nazev}";

                            }
                        }
                    }
                    else
                    {

                    }



                    listBoxLog.Items.Add(message);
                    i++;
                }
            }
            listBoxLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            listBoxLog.MeasureItem += lst_MeasureItem;
            listBoxLog.DrawItem += lst_DrawItem;
        }



        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBoxLog.Items[e.Index].ToString(), listBoxLog.Font, listBoxLog.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(listBoxLog.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            using (Pen borderPen = new Pen(Color.Black))
            {
                e.Graphics.DrawLine(borderPen, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            }
        }


        /// <summary>
        /// Retrieves the current user from the database.
        /// </summary>
        void GetUserFromDatabase()
        {
            User? currentUser = new();
            UserInfo? currentUserInfo = new();
            try
            {

                currentUserInfo = dbint.GetCurrentUserInfo(currentUserInfo, WinUserName);
                currentUser = dbint.GetCurrentUser(currentUser, currentUserInfo.OsCis);
            }
            catch (NullReferenceException ex)
            {
                Application.Exit();
            }

            if (ValidateUser(currentUser, currentUserInfo))
            {
                MessageBox.Show($"Úspìšnì pøihlášen jako {currentUserInfo.Jmeno} {currentUserInfo.Prijmeni}.");
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Validates the current user and user info.
        /// </summary>
        /// <returns>True if valid; otherwise, false.</returns>
        bool ValidateUser(User currentUser, UserInfo currentUserInfo)
        {
            if (currentUserInfo == null || currentUser == null)
            {
                MessageBox.Show("Nejste registrován jako uživatel, aplikace bude ukonèena.");
                this.Close();
                return false;
            }
            else
            {
                dbint.CurrentUserInfo = currentUserInfo;
                dbint.CurrentUser = currentUser;
                return true;
            }
        }

        /// <summary>
        /// Loads the user information panel with user details.
        /// </summary>
        void LoadUserInfoPanel()
        {
            labelUsername.Text = dbint.CurrentUserInfo.WinUsername;
            labelName.Text = $"{dbint.CurrentUserInfo.Jmeno}  {dbint.CurrentUserInfo.Prijmeni}";
            labelOsCis.Text = dbint.CurrentUserInfo.OsCis.ToString();

            comboBoxChangeUser.Text = Form1.dbint.CurrentUserInfo.Jmeno + " " + Form1.dbint.CurrentUserInfo.Prijmeni;
            

            if (Form1.dbint.CurrentUser.Loa > 1)
            {
                comboBoxChangeUser.Enabled = true;
                comboBoxChangeUser.Visible = true;
            }


            List<UserInfo> list = new List<UserInfo>();
            list = Form1.dbint.GetAllUsersAuto();
            foreach (UserInfo user in list)
            {
                comboBoxChangeUser.Items.Add(user.ToString());
            }
        }

        /// <summary>
        /// Sets the buttons' permissions based on user role.
        /// </summary>
        void SetButtonsByPermission()
        {
            bool hasPermission = dbint.CurrentUser.Loa > 1;
            buttonProjects.Enabled = hasPermission;
            buttonUsers.Enabled = hasPermission;
            buttonReporty.Enabled = hasPermission;
            comboBoxChangeUser.Enabled = hasPermission;

        }

        private void label1_Click(object sender, EventArgs e) { }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);


            if (labelName.Text == "label1")
            {
                Application.Exit();
            }

        }

        /// <summary>
        /// Displays the days of the specified month and year.
        /// </summary>
        /// <param name="month">The month to display.</param>
        /// <param name="year">The year to display.</param>
        public void ShowDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            CultureInfo czechCulture = new CultureInfo("cs-CZ");
            string monthName = czechCulture.DateTimeFormat.GetMonthName(month);
            labelMonth.Text = monthName.ToUpper() + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            // Adjust for the first day of the week
            if (week < 1) week = 7;

            // Add placeholders for days in the previous month
            for (int i = 1; i < week; i++)
            {
                ucDay ucDayPlaceholder = new();
                flowLayoutPanel1.Controls.Add(ucDayPlaceholder);
            }

            // Add days of the current month
            for (int i = 1; i <= day; i++)
            {
                ucDay ucDay = new(i.ToString());
                flowLayoutPanel1.Controls.Add(ucDay);
            }
        }

        public void ShowDaysDifferentUser(int month, int year, string OsCis)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            CultureInfo czechCulture = new CultureInfo("cs-CZ");
            string monthName = czechCulture.DateTimeFormat.GetMonthName(month);
            labelMonth.Text = monthName.ToUpper() + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            // Adjust for the first day of the week
            if (week < 1) week = 7;

            // Add placeholders for days in the previous month
            for (int i = 1; i < week; i++)
            {
                UcDaysOthers ucDayPlaceholder = new();
                flowLayoutPanel1.Controls.Add(ucDayPlaceholder);
            }

            // Add days of the current month
            for (int i = 1; i <= day; i++)
            {
                UcDaysOthers ucDay = new(i.ToString(), OsCis);
                flowLayoutPanel1.Controls.Add(ucDay);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            ShowDays(_month, _year);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            ShowDays(_month, _year);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) { }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
            FillListBoxLog();
        }

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            ProjectManagement pm = new();
            pm.ShowDialog();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UserManagement um = new();
            um.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporty report = new($"1/{_month}/{_year}");
            report.ShowDialog();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxChangeUser_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowDaysDifferentUser(DateTime.Now.Month, DateTime.Now.Year, comboBoxChangeUser.Text.Split('-')[1].Trim());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            VykazyPrace.UzReport uz = new(dbint.CurrentUserInfo.OsCis.ToString(), $"1/{_month}/{_year}");
            uz.ShowDialog();
        }
    }
}
