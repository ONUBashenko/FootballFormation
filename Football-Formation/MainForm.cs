using System.Configuration;

namespace FootballFormation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem.ToString())
            {
                case "Players":
                    LoadPage(new PlayersPage());
                    break;
                case "Coaches":
                    LoadPage(new CoachesPage());
                    break;
                case "Teams":
                    LoadPage(new TeamsPage());
                    break;
                case "Matches":
                    LoadPage(new MatchesPage());
                    break;
            }
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
