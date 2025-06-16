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
using FootballFormation.InfoPages;

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

        private void PlayersPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanelPlayers.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelPlayers.WrapContents = false;
            flowLayoutPanelPlayers.AutoScroll = true;

            RenderPlayers();
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            CreatePlayerForm createForm = new CreatePlayerForm();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                RenderPlayers();
            }
        }

        private void RenderPlayers()
        {
            flowLayoutPanelPlayers.Controls.Clear();

            foreach (var player in Player.GetAllPlayers())
            {
                Panel panel = new Panel();
                panel.Width = 1000;
                panel.Height = 30;

                Label linkLabel = new Label();
                linkLabel.Text = player.Name;
                linkLabel.Width = 250;
                linkLabel.Location = new Point(5, 5);
                linkLabel.Tag = player;
                linkLabel.Click += LinkLabel_LinkClicked;

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Width = 80;
                deleteButton.Height = 30;
                deleteButton.Location = new Point(400, 2);
                deleteButton.Tag = player;
                deleteButton.Click += DeleteButton_Click;

                panel.Controls.Add(linkLabel);
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

        private void LinkLabel_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Label label = sender as Label;
                if (label?.Tag is Player player)
                {
                    PlayerInfoForm infoForm = new PlayerInfoForm(player);
                    infoForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }
    }
}
