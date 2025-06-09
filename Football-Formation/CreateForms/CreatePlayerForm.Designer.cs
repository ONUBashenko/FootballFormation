namespace FootballFormation
{
    partial class CreatePlayerForm
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
            buttonCancel = new Button();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            comboBoxPosition = new ComboBox();
            numericUpDownAge = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(694, 409);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(594, 409);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(22, 119);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(348, 141);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 5;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(13, 213);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 6;
            label3.Text = "Neight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(44, 162);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 7;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(381, 194);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(106, 125);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 27);
            textBoxName.TabIndex = 9;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Location = new Point(452, 145);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(150, 28);
            comboBoxPosition.TabIndex = 14;
            comboBoxPosition.SelectedIndexChanged += comboBoxPosition_SelectedIndexChanged;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(106, 169);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(150, 27);
            numericUpDownAge.TabIndex = 15;
            numericUpDownAge.ValueChanged += numericUpDownAge_ValueChanged;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(106, 220);
            numericUpDownHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(150, 27);
            numericUpDownHeight.TabIndex = 16;
            numericUpDownHeight.ValueChanged += numericUpDownHeight_ValueChanged;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(452, 201);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(150, 27);
            numericUpDownPrice.TabIndex = 17;
            numericUpDownPrice.ValueChanged += numericUpDownPrice_ValueChanged;
            // 
            // CreatePlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownHeight);
            Controls.Add(numericUpDownAge);
            Controls.Add(comboBoxPosition);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "CreatePlayerForm";
            Text = "CreatePlayerForm";
            Load += CreatePlayerForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCancel;
        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private ComboBox comboBoxPosition;
        private NumericUpDown numericUpDownAge;
        private NumericUpDown numericUpDownHeight;
        private NumericUpDown numericUpDownPrice;
    }
}