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
    public partial class TeamsPage : UserControl
    {
        public TeamsPage()
        {
            InitializeComponent();
        }

        private void CreateTeam_Click(object sender, EventArgs e)
        {
            CreateTeamForm createForm = new CreateTeamForm();
            createForm.ShowDialog();
        }
    }
}
