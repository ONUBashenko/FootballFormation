namespace FootballFormation
{
    partial class UserControlPlayersPage
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
            label1 = new Label();
            CreatePlayer = new Button();
            flowLayoutPanelPlayers = new FlowLayoutPanel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F);
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(137, 42);
            label1.TabIndex = 1;
            label1.Text = "Players";
            // 
            // CreatePlayer
            // 
            CreatePlayer.BackColor = SystemColors.Control;
            CreatePlayer.Location = new Point(949, 74);
            CreatePlayer.Name = "CreatePlayer";
            CreatePlayer.Size = new Size(118, 30);
            CreatePlayer.TabIndex = 4;
            CreatePlayer.Text = "Create player";
            CreatePlayer.UseVisualStyleBackColor = false;
            CreatePlayer.Click += CreatePlayer_Click;
            // 
            // flowLayoutPanelPlayers
            // 
            flowLayoutPanelPlayers.BackColor = SystemColors.ControlDark;
            flowLayoutPanelPlayers.Location = new Point(0, 123);
            flowLayoutPanelPlayers.Name = "flowLayoutPanelPlayers";
            flowLayoutPanelPlayers.Size = new Size(1070, 437);
            flowLayoutPanelPlayers.TabIndex = 13;
            flowLayoutPanelPlayers.Paint += flowLayoutPanelPlayers_Paint;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(0, 67);
            label2.Name = "label2";
            label2.Size = new Size(1070, 4);
            label2.TabIndex = 14;
            label2.Text = "label2";
            // 
            // UserControlPlayersPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(flowLayoutPanelPlayers);
            Controls.Add(CreatePlayer);
            Controls.Add(label1);
            Name = "UserControlPlayersPage";
            Size = new Size(1070, 561);
            Load += PlayersPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreatePlayer;
        private FlowLayoutPanel flowLayoutPanelPlayers;
        private Label label2;
    }
}
