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
    public partial class TeamInfoForm : Form
    {
        private Team team;

        public TeamInfoForm(Team team)
        {
            InitializeComponent();

            this.team = team;
            SetTeamInfo();
        }

        private void TeamInfoForm_Load(object sender, EventArgs e)
        {
        }

        private void SetTeamInfo()
        {
            labelTeamName.Text = team.Name;
            labelTeamCountry.Text = team.Country;
            labelTeamCoach.Text = team.TeamCoach.Name;

            foreach (var player in team.Players)
            {
                listBoxPlayers.Items.Add(player);
            }
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
