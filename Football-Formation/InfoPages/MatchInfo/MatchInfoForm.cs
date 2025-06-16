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
using FootballFormation.InfoPages.MatchInfo;

namespace FootballFormation.InfoPages
{
    public partial class MatchInfoForm : Form
    {
        private Match match;

        public MatchInfoForm(Match match)
        {
            InitializeComponent();

            this.match = match;
        }

        private void MatchInfoForm_Load(object sender, EventArgs e)
        {
            LoadPage(new UserControlMatchSummaryInfo(match));
        }

        private void LoadPage(UserControl page)
        {
            panel1.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panel1.Controls.Add(page);
        }
    }
}
