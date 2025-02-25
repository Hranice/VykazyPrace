namespace VykazyPrace
{
    partial class ProjectManagement
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBoxProjectName = new TextBox();
            textBoxProjectOznaceni = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            textBoxProvoz = new TextBox();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBoxLaserovani = new TextBox();
            label6 = new Label();
            button6 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            button8 = new Button();
            labelPripravky = new Label();
            textBoxPripravky = new TextBox();
            textBoxMeeting = new TextBox();
            textBoxDovolena = new TextBox();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label10 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            button9 = new Button();
            textBox1 = new TextBox();
            button10 = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            button11 = new Button();
            label8 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(26, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(240, 426);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Reddit Sans", 12F);
            button1.Location = new Point(272, 405);
            button1.Name = "button1";
            button1.Size = new Size(268, 45);
            button1.TabIndex = 1;
            button1.Text = "Přidat projekt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Location = new Point(272, 376);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new Size(268, 23);
            textBoxProjectName.TabIndex = 2;
            // 
            // textBoxProjectOznaceni
            // 
            textBoxProjectOznaceni.Location = new Point(272, 322);
            textBoxProjectOznaceni.Name = "textBoxProjectOznaceni";
            textBoxProjectOznaceni.Size = new Size(268, 23);
            textBoxProjectOznaceni.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Reddit Sans", 12F);
            button2.Location = new Point(272, 24);
            button2.Name = "button2";
            button2.Size = new Size(268, 64);
            button2.TabIndex = 4100;
            button2.Text = "Ukončit vybraný projekt a smazat záznamy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reddit Sans", 10F);
            label1.Location = new Point(272, 348);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 5;
            label1.Text = "Název projektu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Reddit Sans", 10F);
            label2.Location = new Point(272, 294);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 6;
            label2.Text = "Označení projektu";
            // 
            // button3
            // 
            button3.Font = new Font("Reddit Sans", 12F);
            button3.Location = new Point(272, 94);
            button3.Name = "button3";
            button3.Size = new Size(268, 64);
            button3.TabIndex = 1000;
            button3.Text = "Ukončit vybraný projekt a zachovat záznamy.\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Reddit Sans", 9F);
            label3.Location = new Point(93, 19);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 8;
            label3.Text = "Označení \"dovolená\"";
            // 
            // button4
            // 
            button4.Location = new Point(12, 41);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Potvrdit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxProvoz
            // 
            textBoxProvoz.Font = new Font("Reddit Sans", 9F);
            textBoxProvoz.Location = new Point(93, 96);
            textBoxProvoz.Name = "textBoxProvoz";
            textBoxProvoz.Size = new Size(135, 23);
            textBoxProvoz.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(12, 97);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Potvrdit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Reddit Sans", 9F);
            label4.Location = new Point(93, 78);
            label4.Name = "label4";
            label4.Size = new Size(111, 19);
            label4.TabIndex = 13;
            label4.Text = "Označení \"provoz\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Reddit Sans", 9F);
            label5.Location = new Point(93, 195);
            label5.Name = "label5";
            label5.Size = new Size(131, 19);
            label5.TabIndex = 17;
            label5.Text = "Označení \"Laserování\"";
            // 
            // textBoxLaserovani
            // 
            textBoxLaserovani.Font = new Font("Reddit Sans", 9F);
            textBoxLaserovani.Location = new Point(93, 213);
            textBoxLaserovani.Name = "textBoxLaserovani";
            textBoxLaserovani.Size = new Size(135, 23);
            textBoxLaserovani.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Reddit Sans", 9F);
            label6.Location = new Point(93, 136);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 14;
            label6.Text = "Označení \"Meeting\"";
            // 
            // button6
            // 
            button6.Location = new Point(12, 214);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 19;
            button6.Text = "Potvrdit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 154);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 18;
            button7.Text = "Potvrdit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(labelPripravky);
            panel1.Controls.Add(textBoxPripravky);
            panel1.Controls.Add(textBoxMeeting);
            panel1.Controls.Add(textBoxDovolena);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxProvoz);
            panel1.Controls.Add(textBoxLaserovani);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(618, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 321);
            panel1.TabIndex = 20;
            // 
            // button8
            // 
            button8.Location = new Point(12, 268);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 25;
            button8.Text = "Potvrdit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // labelPripravky
            // 
            labelPripravky.AutoSize = true;
            labelPripravky.Font = new Font("Reddit Sans", 9F);
            labelPripravky.Location = new Point(93, 249);
            labelPripravky.Name = "labelPripravky";
            labelPripravky.Size = new Size(123, 19);
            labelPripravky.TabIndex = 24;
            labelPripravky.Text = "Označení \"Přípravky\"";
            // 
            // textBoxPripravky
            // 
            textBoxPripravky.Font = new Font("Reddit Sans", 9F);
            textBoxPripravky.Location = new Point(93, 267);
            textBoxPripravky.Name = "textBoxPripravky";
            textBoxPripravky.Size = new Size(135, 23);
            textBoxPripravky.TabIndex = 26;
            // 
            // textBoxMeeting
            // 
            textBoxMeeting.Location = new Point(93, 154);
            textBoxMeeting.Name = "textBoxMeeting";
            textBoxMeeting.Size = new Size(135, 23);
            textBoxMeeting.TabIndex = 22;
            // 
            // textBoxDovolena
            // 
            textBoxDovolena.Location = new Point(93, 41);
            textBoxDovolena.Name = "textBoxDovolena";
            textBoxDovolena.Size = new Size(135, 23);
            textBoxDovolena.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(572, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 448);
            panel2.TabIndex = 21;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(881, 490);
            tabControl1.TabIndex = 4101;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(textBoxProjectName);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBoxProjectOznaceni);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(873, 462);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Projekty";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(873, 462);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Zakázky";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Reddit Sans", 10F);
            label10.Location = new Point(562, 301);
            label10.Name = "label10";
            label10.Size = new Size(46, 22);
            label10.TabIndex = 4114;
            label10.Text = "Autor";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(562, 327);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(105, 23);
            comboBox2.TabIndex = 4113;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Interní", "Externí" });
            comboBox1.Location = new Point(692, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 4112;
            comboBox1.Text = "Interní";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Reddit Sans", 10F);
            label9.Location = new Point(692, 239);
            label9.Name = "label9";
            label9.Size = new Size(85, 22);
            label9.TabIndex = 4111;
            label9.Text = "Typ zakázky";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(15, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(515, 426);
            dataGridView2.TabIndex = 4101;
            // 
            // button9
            // 
            button9.Font = new Font("Reddit Sans", 12F);
            button9.Location = new Point(562, 412);
            button9.Name = "button9";
            button9.Size = new Size(268, 45);
            button9.TabIndex = 4102;
            button9.Text = "Přidat projekt";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(562, 383);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 4104;
            // 
            // button10
            // 
            button10.Font = new Font("Reddit Sans", 12F);
            button10.Location = new Point(573, 96);
            button10.Name = "button10";
            button10.Size = new Size(268, 64);
            button10.TabIndex = 4108;
            button10.Text = "Ukončit vybranou zakázku a zachovat záznamy";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(562, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 23);
            textBox2.TabIndex = 4103;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Reddit Sans", 10F);
            label7.Location = new Point(562, 239);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 4106;
            label7.Text = "Číslo zakázky";
            // 
            // button11
            // 
            button11.Font = new Font("Reddit Sans", 12F);
            button11.Location = new Point(573, 26);
            button11.Name = "button11";
            button11.Size = new Size(268, 64);
            button11.TabIndex = 4109;
            button11.Text = "Ukončit vybranou zakázku a smazat záznamy";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Reddit Sans", 10F);
            label8.Location = new Point(562, 355);
            label8.Name = "label8";
            label8.Size = new Size(105, 22);
            label8.TabIndex = 4105;
            label8.Text = "Název projektu";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(692, 327);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 4115;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Reddit Sans", 10F);
            label11.Location = new Point(692, 302);
            label11.Name = "label11";
            label11.Size = new Size(73, 22);
            label11.TabIndex = 4116;
            label11.Text = "Poznámka";
            // 
            // ProjectManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 495);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProjectManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management projektů";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBoxProjectName;
        private TextBox textBoxProjectOznaceni;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Button button4;
        private TextBox textBoxProvoz;
        private Button button5;
        private Label label4;
        private Label label5;
        private TextBox textBoxLaserovani;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Button button6;
        private Button button7;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxMeeting;
        private TextBox textBoxDovolena;
        private Button button8;
        private Label labelPripravky;
        private TextBox textBoxPripravky;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Button button9;
        private TextBox textBox1;
        private Button button10;
        private TextBox textBox2;
        private Label label7;
        private Button button11;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label11;
        private TextBox textBox3;
    }
}