using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballFormation.Classes;

namespace FootballFormation.InfoPages
{
    public partial class PlayerInfoForm : Form
    {
        private Player player;

        public PlayerInfoForm(Player player) //player
        {
            InitializeComponent();

            this.player = player;
            SetPlayerInfo();
        }

        private void PlayerInfoForm_Load(object sender, EventArgs e)
        {
        }

        public void SetPlayerInfo()
        {
            labelPlayerName.Text = player.Name;
            labelPlayerAge.Text = $"{player.Age} y.o.";
            labelPlayerHeight.Text = $"{player.Height / 100.0:F2} m";
            labelPlayerPosition.Text = player.Position.ToString();
            labelPlayerPrice.Text = $"{player.Price} mln $";
            labelPlayerTeam.Text = player.Team == null ? "Free agent" : player.Team.Name;
        }
    }
}
