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

namespace FootballFormation.CreateForms.CreateMatch
{
    public partial class CreateMatchForm : Form
    {
        public class MatchData
        {
            public Team HomeTeam { get; set; }
            public Team AwayTeam { get; set; }
            public Formation HomeFormation { get; set; }
            public Formation AwayFormation { get; set; }
            public Match Match { get; set; }
        }

        public CreateMatchForm()
        {
            InitializeComponent();
        }

        private void CreateMatchForm_Load(object sender, EventArgs e)
        {
            LoadPage(new UserControlSelectTeams());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LoadPage(UserControl page)
        {
            panel1.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panel1.Controls.Add(page);
        }
    }
}
