namespace VykazyPrace
{
    partial class UserManagement
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
            textBoxJmeno = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            textBoxOsCis = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPrijmeni = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            dataGridView1.Location = new Point(12, 24);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(404, 414);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Reddit Sans", 11F);
            button1.Location = new Point(3, 114);
            button1.Name = "button1";
            button1.Size = new Size(369, 52);
            button1.TabIndex = 1;
            button1.Text = "Vytvořit uživatele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxJmeno
            // 
            textBoxJmeno.Location = new Point(3, 25);
            textBoxJmeno.Name = "textBoxJmeno";
            textBoxJmeno.Size = new Size(135, 23);
            textBoxJmeno.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxOsCis);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxPrijmeni);
            panel1.Controls.Add(textBoxJmeno);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(422, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 172);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Reddit Sans", 9F);
            label4.Location = new Point(217, 3);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 9;
            label4.Text = "Osobní číslo";
            // 
            // textBoxOsCis
            // 
            textBoxOsCis.Location = new Point(219, 22);
            textBoxOsCis.Name = "textBoxOsCis";
            textBoxOsCis.Size = new Size(147, 23);
            textBoxOsCis.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Reddit Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 5;
            label2.Text = "Příjmení";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reddit Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 4;
            label1.Text = "Jméno";
            // 
            // textBoxPrijmeni
            // 
            textBoxPrijmeni.Location = new Point(3, 70);
            textBoxPrijmeni.Name = "textBoxPrijmeni";
            textBoxPrijmeni.Size = new Size(133, 23);
            textBoxPrijmeni.TabIndex = 3;
            textBoxPrijmeni.TextChanged += textBoxPrijmeni_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Reddit Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(356, 42);
            button2.TabIndex = 4;
            button2.Text = "Smazat uživatele a jeho záznamy.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(426, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 48);
            panel2.TabIndex = 5;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Správa uživatelů";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBoxJmeno;
        private Panel panel1;
        private Label label4;
        private TextBox textBoxOsCis;
        private Label label2;
        private Label label1;
        private TextBox textBoxPrijmeni;
        private Button button2;
        private Panel panel2;
    }
}