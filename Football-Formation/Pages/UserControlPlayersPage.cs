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
using FootballFormation.Classes;

namespace FootballFormation
{
    public partial class UserControlPlayersPage : UserControl
    {
        public UserControlPlayersPage()
        {
            InitializeComponent();

            flowLayoutPanelPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            CreatePlayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            CreatePlayerForm createForm = new CreatePlayerForm();
            createForm.ShowDialog();
        }

        private void PlayersPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanelPlayers.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelPlayers.WrapContents = false;
            flowLayoutPanelPlayers.AutoScroll = true;

            RenderPlayers();
        }

        private void flowLayoutPanelPlayers_Paint(object sender, PaintEventArgs e)
        {
        }
        private void RenderPlayers()
        {
            flowLayoutPanelPlayers.Controls.Clear();

            foreach (var player in Player.GetAllPlayers())
            {
                Panel panel = new Panel();
                panel.Width = 1000;
                panel.Height = 30;

                Label label = new Label();
                label.Text = player.Name;
                label.Width = 250;
                label.Location = new Point(5, 5);

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Width = 80;
                deleteButton.Height = 30;
                deleteButton.Location = new Point(400, 2);
                deleteButton.Tag = player;
                deleteButton.Click += DeleteButton_Click;

                panel.Controls.Add(label);
                panel.Controls.Add(deleteButton);
                flowLayoutPanelPlayers.Controls.Add(panel);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                if (button?.Tag is Player playerToRemove)
                {
                    playerToRemove.Delete();
                    RenderPlayers();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }
    }
}
