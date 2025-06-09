namespace FootballFormation.CreateForms
{
    partial class CreateTeamForm
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
            buttonSave = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxCountry = new TextBox();
            textBoxName = new TextBox();
            comboBoxCoach = new ComboBox();
            checkedListBoxPlayers = new CheckedListBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(594, 409);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(694, 409);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(444, 200);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 6;
            label1.Text = "Players";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(452, 127);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 7;
            label2.Text = "Coach";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(72, 201);
            label3.Name = "label3";
            label3.Size = new Size(99, 32);
            label3.TabIndex = 9;
            label3.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(93, 133);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(177, 207);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(125, 27);
            textBoxCountry.TabIndex = 13;
            textBoxCountry.TextChanged += textBoxCountry_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(177, 139);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 14;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // comboBoxCoach
            // 
            comboBoxCoach.FormattingEnabled = true;
            comboBoxCoach.Location = new Point(538, 133);
            comboBoxCoach.Name = "comboBoxCoach";
            comboBoxCoach.Size = new Size(223, 28);
            comboBoxCoach.TabIndex = 16;
            comboBoxCoach.SelectedIndexChanged += comboBoxCoach_SelectedIndexChanged;
            // 
            // checkedListBoxPlayers
            // 
            checkedListBoxPlayers.FormattingEnabled = true;
            checkedListBoxPlayers.Location = new Point(538, 207);
            checkedListBoxPlayers.Name = "checkedListBoxPlayers";
            checkedListBoxPlayers.Size = new Size(223, 136);
            checkedListBoxPlayers.TabIndex = 17;
            checkedListBoxPlayers.SelectedIndexChanged += checkedListBoxPlayers_SelectedIndexChanged;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBoxPlayers);
            Controls.Add(comboBoxCoach);
            Controls.Add(textBoxName);
            Controls.Add(textBoxCountry);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            Load += CreateTeamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxCountry;
        private TextBox textBoxName;
        private ComboBox comboBoxCoach;
        private CheckedListBox checkedListBoxPlayers;
    }
}