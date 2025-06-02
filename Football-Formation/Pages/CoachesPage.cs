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
    public partial class CoachesPage : UserControl
    {
        public CoachesPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateCoach_Click(object sender, EventArgs e)
        {
            CreateCoachForm createForm = new CreateCoachForm();
            createForm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CoachesPage_Load(object sender, EventArgs e)
        {

        }
    }
}
