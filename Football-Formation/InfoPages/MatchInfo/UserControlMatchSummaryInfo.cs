using FootballFormation.Classes;
using FootballFormation.CreateForms.CreateMatch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FootballFormation.CreateForms.CreateMatch.CreateMatchForm;

namespace FootballFormation.InfoPages.MatchInfo
{
    public partial class UserControlMatchSummaryInfo : UserControl
    {
        private Match match;

        public UserControlMatchSummaryInfo(Match match)
        {
            InitializeComponent();

            this.match = match;
            LoadMatchSummary();
        }

        private void UserControlMatchSummaryInfo_Load(object sender, EventArgs e)
        {
        }

        public void LoadMatchSummary()
        {
            HomeTeam.Text = match.HomeTeam.Name;
            AwayTeam.Text = match.AwayTeam.Name;
            HomeTeamGoals.Text = match.MatchEvents["Goals"].Item1.ToString();
            AwayTeamGoals.Text = match.MatchEvents["Goals"].Item2.ToString();
            HomeTeamPossession.Text = match.MatchEvents["Possession"].Item1.ToString() + '%';
            AwayTeamPossession.Text = match.MatchEvents["Possession"].Item2.ToString() + '%';
            HomeTeamShots.Text = match.MatchEvents["Shots"].Item1.ToString();
            AwayTeamShots.Text = match.MatchEvents["Shots"].Item2.ToString();
            HomeTeamShotsOnTarget.Text = match.MatchEvents["Shots on target"].Item1.ToString();
            AwayTeamShotsOnTarget.Text = match.MatchEvents["Shots on target"].Item2.ToString();
            HomeTeamCorners.Text = match.MatchEvents["Corners"].Item1.ToString();
            AwayTeamCorners.Text = match.MatchEvents["Corners"].Item2.ToString();
            HomeTeamFouls.Text = match.MatchEvents["Fouls"].Item1.ToString();
            AwayTeamFouls.Text = match.MatchEvents["Fouls"].Item2.ToString();
            HomeTeamYellowCards.Text = match.MatchEvents["Yellow cards"].Item1.ToString();
            AwayTeamYellowCards.Text = match.MatchEvents["Yellow cards"].Item2.ToString();
            HomeTeamRedCards.Text = match.MatchEvents["Red cards"].Item1.ToString();
            AwayTeamRedCards.Text = match.MatchEvents["Red cards"].Item2.ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var parent = this.Parent;

            if (parent != null)
            {
                parent.Controls.Clear();
                var uc2 = new UserControlHomeFormationInfo(match);
                parent.Controls.Add(uc2);
                uc2.Dock = DockStyle.Fill;
            }
        }
    }
}
