namespace FootballFormation.CreateForms
{
    partial class CreateCoachForm
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
            label5 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            checkedListBoxFormations = new CheckedListBox();
            numericUpDownAge = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownExperience = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExperience).BeginInit();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(427, 113);
            label5.Name = "label5";
            label5.Size = new Size(129, 32);
            label5.TabIndex = 13;
            label5.Text = "Experience";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(423, 201);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 10;
            label2.Text = "Formations";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(137, 119);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(75, 156);
            label6.Name = "label6";
            label6.Size = new Size(56, 32);
            label6.TabIndex = 16;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(44, 207);
            label7.Name = "label7";
            label7.Size = new Size(87, 32);
            label7.TabIndex = 15;
            label7.Text = "Neight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(53, 113);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 14;
            label8.Text = "Name";
            // 
            // checkedListBoxFormations
            // 
            checkedListBoxFormations.FormattingEnabled = true;
            checkedListBoxFormations.Location = new Point(562, 207);
            checkedListBoxFormations.Name = "checkedListBoxFormations";
            checkedListBoxFormations.Size = new Size(142, 114);
            checkedListBoxFormations.TabIndex = 21;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(137, 163);
            numericUpDownAge.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(125, 27);
            numericUpDownAge.TabIndex = 22;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(137, 214);
            numericUpDownHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(125, 27);
            numericUpDownHeight.TabIndex = 23;
            // 
            // numericUpDownExperience
            // 
            numericUpDownExperience.Location = new Point(562, 120);
            numericUpDownExperience.Name = "numericUpDownExperience";
            numericUpDownExperience.Size = new Size(125, 27);
            numericUpDownExperience.TabIndex = 24;
            // 
            // CreateCoachForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownExperience);
            Controls.Add(numericUpDownHeight);
            Controls.Add(numericUpDownAge);
            Controls.Add(checkedListBoxFormations);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "CreateCoachForm";
            Text = "CreateCoachForm";
            Load += CreateCoachForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExperience).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private Label label5;
        private Label label2;
        private TextBox textBoxName;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckedListBox checkedListBoxFormations;
        private NumericUpDown numericUpDownAge;
        private NumericUpDown numericUpDownHeight;
        private NumericUpDown numericUpDownExperience;
    }
}