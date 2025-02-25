namespace VykazyPrace
{
    partial class NewRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBoxActivity = new TextBox();
            label2 = new Label();
            textBoxHours = new TextBox();
            label3 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label4 = new Label();
            button4 = new Button();
            comboBoxZakazky = new ComboBox();
            button5 = new Button();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            label5 = new Label();
            button6 = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 1;
            label1.Text = "Projekt:";
            // 
            // textBoxActivity
            // 
            textBoxActivity.Location = new Point(6, 86);
            textBoxActivity.Name = "textBoxActivity";
            textBoxActivity.Size = new Size(229, 23);
            textBoxActivity.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 3;
            label2.Text = "Aktivita";
            // 
            // textBoxHours
            // 
            textBoxHours.Enabled = false;
            textBoxHours.Location = new Point(6, 146);
            textBoxHours.Name = "textBoxHours";
            textBoxHours.Size = new Size(162, 23);
            textBoxHours.TabIndex = 4;
            textBoxHours.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 122);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 5;
            label3.Text = "Počet hodin";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(6, 199);
            button1.Name = "button1";
            button1.Size = new Size(229, 52);
            button1.TabIndex = 6;
            button1.Text = "Vytvořit záznam";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Reddit Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBox1.Location = new Point(158, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(85, 25);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Dovolená";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(205, 146);
            button2.Name = "button2";
            button2.Size = new Size(24, 23);
            button2.TabIndex = 8;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 145);
            button3.Name = "button3";
            button3.Size = new Size(25, 23);
            button3.TabIndex = 9;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 305);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBoxActivity);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBoxHours);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(258, 277);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Projekty";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(comboBoxZakazky);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(258, 277);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Zakázky";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 11;
            label4.Text = "Zakázky:";
            // 
            // button4
            // 
            button4.Location = new Point(179, 156);
            button4.Name = "button4";
            button4.Size = new Size(25, 23);
            button4.TabIndex = 19;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBoxZakazky
            // 
            comboBoxZakazky.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxZakazky.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxZakazky.FormattingEnabled = true;
            comboBoxZakazky.Location = new Point(6, 27);
            comboBoxZakazky.Name = "comboBoxZakazky";
            comboBoxZakazky.Size = new Size(229, 23);
            comboBoxZakazky.TabIndex = 10;
            // 
            // button5
            // 
            button5.Location = new Point(210, 157);
            button5.Name = "button5";
            button5.Size = new Size(24, 23);
            button5.TabIndex = 18;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 12;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Reddit Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBox2.Location = new Point(163, 183);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(85, 25);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Dovolená";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(5, 83);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 13;
            label5.Text = "Aktivita";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(11, 210);
            button6.Name = "button6";
            button6.Size = new Size(229, 52);
            button6.TabIndex = 16;
            button6.Text = "Vytvořit záznam";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(5, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 14;
            textBox2.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 132);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 15;
            label6.Text = "Počet hodin";
            // 
            // NewRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 308);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nový záznam";
            FormClosed += NewRecord_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBoxActivity;
        private Label label2;
        private TextBox textBoxHours;
        private Label label3;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Button button4;
        private ComboBox comboBoxZakazky;
        private Button button5;
        private TextBox textBox1;
        private CheckBox checkBox2;
        private Label label5;
        private Button button6;
        private TextBox textBox2;
        private Label label6;
    }
}