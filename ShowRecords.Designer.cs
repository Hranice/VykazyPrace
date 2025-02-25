namespace VykazyPrace
{
    partial class ShowRecords
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
            radioButtonAllRecords = new RadioButton();
            radioButtonConcreteWorker = new RadioButton();
            comboBoxUsers = new ComboBox();
            radioButtonMyRecords = new RadioButton();
            comboBoxProjects = new ComboBox();
            radioButtonProjects = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(447, 426);
            dataGridView1.TabIndex = 1;
            // 
            // radioButtonAllRecords
            // 
            radioButtonAllRecords.AutoSize = true;
            radioButtonAllRecords.Font = new Font("Reddit Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButtonAllRecords.Location = new Point(466, 47);
            radioButtonAllRecords.Name = "radioButtonAllRecords";
            radioButtonAllRecords.Size = new Size(159, 29);
            radioButtonAllRecords.TabIndex = 2;
            radioButtonAllRecords.Text = "Všechny záznamy";
            radioButtonAllRecords.UseVisualStyleBackColor = true;
            radioButtonAllRecords.CheckedChanged += radioButtonAllRecords_CheckedChanged;
            // 
            // radioButtonConcreteWorker
            // 
            radioButtonConcreteWorker.AutoSize = true;
            radioButtonConcreteWorker.Font = new Font("Reddit Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButtonConcreteWorker.Location = new Point(466, 82);
            radioButtonConcreteWorker.Name = "radioButtonConcreteWorker";
            radioButtonConcreteWorker.Size = new Size(158, 29);
            radioButtonConcreteWorker.TabIndex = 3;
            radioButtonConcreteWorker.Text = "Konkrétní uživatel";
            radioButtonConcreteWorker.UseVisualStyleBackColor = true;
            radioButtonConcreteWorker.CheckedChanged += radioButtonConcreteWorker_CheckedChanged;
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.Enabled = false;
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(466, 117);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(158, 23);
            comboBoxUsers.TabIndex = 4;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // radioButtonMyRecords
            // 
            radioButtonMyRecords.AutoSize = true;
            radioButtonMyRecords.Checked = true;
            radioButtonMyRecords.Font = new Font("Reddit Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButtonMyRecords.Location = new Point(465, 12);
            radioButtonMyRecords.Name = "radioButtonMyRecords";
            radioButtonMyRecords.Size = new Size(132, 29);
            radioButtonMyRecords.TabIndex = 5;
            radioButtonMyRecords.TabStop = true;
            radioButtonMyRecords.Text = "Moje záznamy";
            radioButtonMyRecords.UseVisualStyleBackColor = true;
            radioButtonMyRecords.CheckedChanged += radioButtonMyRecords_CheckedChanged;
            // 
            // comboBoxProjects
            // 
            comboBoxProjects.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProjects.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxProjects.Enabled = false;
            comboBoxProjects.FormattingEnabled = true;
            comboBoxProjects.Location = new Point(465, 181);
            comboBoxProjects.Name = "comboBoxProjects";
            comboBoxProjects.Size = new Size(237, 23);
            comboBoxProjects.TabIndex = 7;
            comboBoxProjects.SelectedIndexChanged += comboBoxProjects_SelectedIndexChanged;
            // 
            // radioButtonProjects
            // 
            radioButtonProjects.AutoSize = true;
            radioButtonProjects.Font = new Font("Reddit Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButtonProjects.Location = new Point(465, 146);
            radioButtonProjects.Name = "radioButtonProjects";
            radioButtonProjects.Size = new Size(152, 29);
            radioButtonProjects.TabIndex = 6;
            radioButtonProjects.Text = "Konkrétní projekt";
            radioButtonProjects.UseVisualStyleBackColor = true;
            radioButtonProjects.CheckedChanged += radioButtonProjects_CheckedChanged;
            // 
            // ShowRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxProjects);
            Controls.Add(radioButtonProjects);
            Controls.Add(radioButtonMyRecords);
            Controls.Add(comboBoxUsers);
            Controls.Add(radioButtonConcreteWorker);
            Controls.Add(radioButtonAllRecords);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ShowRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zobrazit záznamy";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        private RadioButton radioButtonAllRecords;
        private RadioButton radioButtonConcreteWorker;
        private ComboBox comboBoxUsers;
        private RadioButton radioButtonMyRecords;
        private ComboBox comboBoxProjects;
        private RadioButton radioButtonProjects;
    }
}