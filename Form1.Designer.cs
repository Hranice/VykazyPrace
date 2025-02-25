namespace VykazyPrace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelUserInfo = new Panel();
            comboBoxChangeUser = new ComboBox();
            labelOsCis = new Label();
            labelName = new Label();
            labelUsername = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelMonth = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            buttonReporty = new Button();
            buttonUsers = new Button();
            buttonProjects = new Button();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            listBoxLog = new ListBox();
            button1 = new Button();
            panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelUserInfo
            // 
            panelUserInfo.BorderStyle = BorderStyle.FixedSingle;
            panelUserInfo.Controls.Add(comboBoxChangeUser);
            panelUserInfo.Controls.Add(labelOsCis);
            panelUserInfo.Controls.Add(labelName);
            panelUserInfo.Controls.Add(labelUsername);
            panelUserInfo.Location = new Point(1054, 12);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Size = new Size(253, 119);
            panelUserInfo.TabIndex = 0;
            // 
            // comboBoxChangeUser
            // 
            comboBoxChangeUser.Enabled = false;
            comboBoxChangeUser.FormattingEnabled = true;
            comboBoxChangeUser.Location = new Point(4, 86);
            comboBoxChangeUser.Name = "comboBoxChangeUser";
            comboBoxChangeUser.Size = new Size(146, 27);
            comboBoxChangeUser.TabIndex = 3;
            comboBoxChangeUser.Visible = false;
            comboBoxChangeUser.SelectedValueChanged += comboBoxChangeUser_SelectedValueChanged;
            // 
            // labelOsCis
            // 
            labelOsCis.AutoSize = true;
            labelOsCis.Font = new Font("Reddit Sans", 10F);
            labelOsCis.Location = new Point(191, 52);
            labelOsCis.Name = "labelOsCis";
            labelOsCis.Size = new Size(44, 22);
            labelOsCis.TabIndex = 2;
            labelOsCis.Text = "label1";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Reddit Sans", 10F);
            labelName.Location = new Point(4, 5);
            labelName.Name = "labelName";
            labelName.Size = new Size(44, 22);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Reddit Sans", 10F);
            labelUsername.Location = new Point(4, 52);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(44, 22);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "label1";
            labelUsername.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MinimumSize = new Size(1250, 530);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1302, 640);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Font = new Font("Reddit Sans", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelMonth.Location = new Point(4, 5);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(83, 42);
            labelMonth.TabIndex = 9;
            labelMonth.Text = "Temp";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.left_arrow;
            pictureBox1.Location = new Point(4, 52);
            pictureBox1.MinimumSize = new Size(37, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(37, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox2_MouseDown;
            pictureBox1.MouseUp += pictureBox2_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.right_arrow;
            pictureBox2.Location = new Point(50, 52);
            pictureBox2.MinimumSize = new Size(37, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(5);
            pictureBox2.Size = new Size(37, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(46, 170);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 12;
            label1.Text = "Pondělí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(254, 170);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 13;
            label2.Text = "Úterý";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(431, 170);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 14;
            label3.Text = "Středa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(612, 170);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 15;
            label4.Text = "Čtvrtek";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(797, 170);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 16;
            label5.Text = "Pátek";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(977, 170);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 17;
            label6.Text = "Sobota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(1166, 170);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 18;
            label7.Text = "Neděle";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelMonth);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 119);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonReporty);
            panel2.Controls.Add(buttonUsers);
            panel2.Controls.Add(buttonProjects);
            panel2.Location = new Point(873, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 106);
            panel2.TabIndex = 12;
            // 
            // buttonReporty
            // 
            buttonReporty.AutoSize = true;
            buttonReporty.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonReporty.Font = new Font("Reddit Sans", 7F);
            buttonReporty.Location = new Point(91, 74);
            buttonReporty.Name = "buttonReporty";
            buttonReporty.Size = new Size(53, 26);
            buttonReporty.TabIndex = 2;
            buttonReporty.Text = "Reporty";
            buttonReporty.UseVisualStyleBackColor = true;
            buttonReporty.Click += button1_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.AutoSize = true;
            buttonUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUsers.Font = new Font("Reddit Sans", 7F);
            buttonUsers.Location = new Point(4, 74);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(57, 26);
            buttonUsers.TabIndex = 1;
            buttonUsers.Text = "Uživatelé";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonProjects
            // 
            buttonProjects.AutoSize = true;
            buttonProjects.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonProjects.Font = new Font("Reddit Sans", 7F);
            buttonProjects.Location = new Point(3, 3);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Size = new Size(55, 26);
            buttonProjects.TabIndex = 0;
            buttonProjects.Text = "Projekty";
            buttonProjects.UseVisualStyleBackColor = true;
            buttonProjects.Click += buttonProjects_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.refresh;
            pictureBox3.Location = new Point(1282, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(5, 211);
            panel3.Name = "panel3";
            panel3.Size = new Size(1302, 640);
            panel3.TabIndex = 21;
            // 
            // listBoxLog
            // 
            listBoxLog.BackColor = Color.Gainsboro;
            listBoxLog.BorderStyle = BorderStyle.FixedSingle;
            listBoxLog.ColumnWidth = 165;
            listBoxLog.Enabled = false;
            listBoxLog.Font = new Font("Reddit Sans", 10F);
            listBoxLog.FormattingEnabled = true;
            listBoxLog.ItemHeight = 21;
            listBoxLog.Items.AddRange(new object[] { "In Progress" });
            listBoxLog.Location = new Point(1326, 12);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.SelectionMode = SelectionMode.None;
            listBoxLog.Size = new Size(173, 821);
            listBoxLog.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(804, 5);
            button1.Name = "button1";
            button1.Size = new Size(66, 109);
            button1.TabIndex = 3;
            button1.Text = "Měsíční report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1511, 862);
            Controls.Add(listBoxLog);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(panelUserInfo);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Font = new Font("Reddit Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1278, 750);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HG Hodiny na projektech";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Enter += Form1_Enter;
            panelUserInfo.ResumeLayout(false);
            panelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUserInfo;
        private Label labelUsername;
        private Label labelName;
        private Label labelOsCis;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelMonth;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Button buttonProjects;
        private PictureBox pictureBox3;
        private Button buttonUsers;
        private Button buttonReporty;
        private Panel panel3;
        private ListBox listBoxLog;
        private ComboBox comboBoxChangeUser;
        private Button button1;
    }
}
