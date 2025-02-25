namespace VykazyPrace
{
    partial class ucDay
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            labelTimeDoneDay = new Label();
            labelPocetHodin = new Label();
            panelIndicator = new Panel();
            checkBox1 = new CheckBox();
            buttonRemoveTime = new Button();
            buttonAddTime = new Button();
            labelDay = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelPocetHodin);
            panel1.Controls.Add(panelIndicator);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(buttonRemoveTime);
            panel1.Controls.Add(buttonAddTime);
            panel1.Controls.Add(labelDay);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 113);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDoubleClick += panel1_MouseDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(labelTimeDoneDay);
            panel2.Location = new Point(4, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(41, 32);
            panel2.TabIndex = 6;
            // 
            // labelTimeDoneDay
            // 
            labelTimeDoneDay.AutoSize = true;
            labelTimeDoneDay.BackColor = Color.Transparent;
            labelTimeDoneDay.Font = new Font("Reddit Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTimeDoneDay.Location = new Point(3, 7);
            labelTimeDoneDay.Name = "labelTimeDoneDay";
            labelTimeDoneDay.Size = new Size(20, 17);
            labelTimeDoneDay.TabIndex = 0;
            labelTimeDoneDay.Text = "---";
            // 
            // labelPocetHodin
            // 
            labelPocetHodin.AutoSize = true;
            labelPocetHodin.Location = new Point(3, 87);
            labelPocetHodin.Name = "labelPocetHodin";
            labelPocetHodin.Size = new Size(0, 15);
            labelPocetHodin.TabIndex = 5;
            // 
            // panelIndicator
            // 
            panelIndicator.Location = new Point(3, 7);
            panelIndicator.Margin = new Padding(3, 4, 3, 4);
            panelIndicator.Name = "panelIndicator";
            panelIndicator.Size = new Size(1, 100);
            panelIndicator.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 17);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 3;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTime
            // 
            buttonRemoveTime.Cursor = Cursors.Hand;
            buttonRemoveTime.Font = new Font("Segoe UI", 13F);
            buttonRemoveTime.Location = new Point(104, 59);
            buttonRemoveTime.Margin = new Padding(3, 4, 3, 4);
            buttonRemoveTime.Name = "buttonRemoveTime";
            buttonRemoveTime.Size = new Size(32, 48);
            buttonRemoveTime.TabIndex = 2;
            buttonRemoveTime.Text = "-";
            buttonRemoveTime.UseVisualStyleBackColor = true;
            buttonRemoveTime.Click += buttonRemoveTime_Click;
            // 
            // buttonAddTime
            // 
            buttonAddTime.Cursor = Cursors.Hand;
            buttonAddTime.Font = new Font("Segoe UI", 13F);
            buttonAddTime.Location = new Point(140, 59);
            buttonAddTime.Margin = new Padding(3, 4, 3, 4);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new Size(32, 48);
            buttonAddTime.TabIndex = 1;
            buttonAddTime.Text = "+";
            buttonAddTime.UseVisualStyleBackColor = true;
            buttonAddTime.Click += buttonAddTime_Click;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.BackColor = Color.Transparent;
            labelDay.Font = new Font("Reddit Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelDay.Location = new Point(123, -3);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(45, 38);
            labelDay.TabIndex = 0;
            labelDay.Text = "33";
            // 
            // ucDay
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gray;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(179, 119);
            Name = "ucDay";
            Padding = new Padding(2, 3, 2, 3);
            Size = new Size(179, 119);
            Load += ucDay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRemoveTime;
        private Button buttonAddTime;
        private Label labelDay;
        private CheckBox checkBox1;
        private Panel panelIndicator;
        private Label labelPocetHodin;
        private Panel panel2;
        private Label labelTimeDoneDay;
    }
}
