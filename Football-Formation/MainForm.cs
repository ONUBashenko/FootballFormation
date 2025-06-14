using System.Configuration;

namespace FootballFormation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Sizable;

            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem.ToString())
            {
                case "Players":
                    LoadPage(new UserControlPlayersPage());
                    break;
                case "Coaches":
                    LoadPage(new UserControlCoachesPage());
                    break;
                case "Teams":
                    LoadPage(new UserControlTeamsPage());
                    break;
                case "Matches":
                    LoadPage(new UserControlMatchesPage());
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
