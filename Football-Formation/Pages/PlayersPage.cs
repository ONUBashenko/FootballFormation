using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballFormation.CreateForms;

namespace FootballFormation
{
    public partial class PlayersPage : UserControl
    {
        public PlayersPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            CreatePlayerForm createForm = new CreatePlayerForm();
            createForm.ShowDialog();
        }

        private void PlayersPage_Load(object sender, EventArgs e)
        {
            RenderPeople();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }
        private void RenderPeople()
        {
            flowLayoutPanel1.Controls.Clear(); // Очищаем старое

            for (int i = 0; i < 100; i++)
            {
                Panel panel = new Panel();
                panel.Width = 1000;
                panel.Height = 30;

                Label label = new Label();
                label.Text = "Hi";
                label.Width = 150;
                label.Location = new Point(5, 5);

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Width = 80;
                deleteButton.Height = 30;
                deleteButton.Location = new Point(400, 2);
                deleteButton.Click += DeleteButton_Click;

                panel.Controls.Add(label);
                panel.Controls.Add(deleteButton);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
