using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballFormation.Classes;
using static FootballFormation.Classes.FormationHelper;

namespace FootballFormation.InfoPages
{
    public partial class CoachInfoForm : Form
    {
        private Coach coach;

        public CoachInfoForm(Coach coach)
        {
            InitializeComponent();

            this.coach = coach;
            SetCoachInfo();
        }

        private void CoachInfoForm_Load(object sender, EventArgs e)
        {
        }

        public void SetCoachInfo()
        {
            labelCoachName.Text = coach.Name;
            labelCoachAge.Text = coach.Age.ToString();
            labelCoachHeight.Text = coach.Height.ToString("F2") + " m";
            labelCoachExperiance.Text = coach.Experience.ToString();
            labelCoachTeam.Text = coach.Team == null ? "Free agent" : coach.Team.Name;

            foreach (var formation in coach.Formations)
            {
                listBoxFormations.Items.Add(GetFormationString(formation));
            }
        }

    }
}
