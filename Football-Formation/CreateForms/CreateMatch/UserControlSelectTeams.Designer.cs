﻿namespace FootballFormation.CreateForms.CreateMatch
{
    partial class UserControlSelectTeams
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxHomeTeam = new ComboBox();
            comboBoxAwayTeam = new ComboBox();
            buttonCancel = new Button();
            buttonNext = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxHomeTeam
            // 
            comboBoxHomeTeam.FormattingEnabled = true;
            comboBoxHomeTeam.Location = new Point(184, 263);
            comboBoxHomeTeam.Name = "comboBoxHomeTeam";
            comboBoxHomeTeam.Size = new Size(151, 28);
            comboBoxHomeTeam.TabIndex = 0;
            comboBoxHomeTeam.SelectedIndexChanged += comboBoxHomeTeam_SelectedIndexChanged;
            // 
            // comboBoxAwayTeam
            // 
            comboBoxAwayTeam.FormattingEnabled = true;
            comboBoxAwayTeam.Location = new Point(596, 263);
            comboBoxAwayTeam.Name = "comboBoxAwayTeam";
            comboBoxAwayTeam.Size = new Size(151, 28);
            comboBoxAwayTeam.TabIndex = 1;
            comboBoxAwayTeam.SelectedIndexChanged += comboBoxAwayTeam_SelectedIndexChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(805, 490);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(705, 490);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(94, 29);
            buttonNext.TabIndex = 3;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(174, 219);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 12;
            label1.Text = "Home team";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(591, 219);
            label2.Name = "label2";
            label2.Size = new Size(163, 41);
            label2.TabIndex = 13;
            label2.Text = "Away team";
            // 
            // UserControlSelectTeams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonNext);
            Controls.Add(buttonCancel);
            Controls.Add(comboBoxAwayTeam);
            Controls.Add(comboBoxHomeTeam);
            Name = "UserControlSelectTeams";
            Size = new Size(902, 522);
            Load += UserControlSelectTeams_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxHomeTeam;
        private ComboBox comboBoxAwayTeam;
        private Button buttonCancel;
        private Button buttonNext;
        private Label label1;
        private Label label2;
    }
}
