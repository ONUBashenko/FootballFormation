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
using FootballFormation.CreateForms;
using FootballFormation.InfoPages;

namespace FootballFormation
{
    public partial class UserControlCoachesPage : UserControl
    {
        public UserControlCoachesPage()
        {
            InitializeComponent();

            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            CreateCoach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void CoachesPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            RenderCoaches();
        }

        private void CreateCoach_Click(object sender, EventArgs e)
        {
            CreateCoachForm createForm = new CreateCoachForm();
            var result = createForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                RenderCoaches();
            }
        }

        private void RenderCoaches()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var coach in Coach.GetAllCoaches())
            {
                Panel panel = new Panel();
                panel.Width = 1000;
                panel.Height = 30;

                Label linkLabel = new Label();
                linkLabel.Text = coach.Name;
                linkLabel.Width = 250;
                linkLabel.Location = new Point(5, 5);
                linkLabel.Tag = coach;
                linkLabel.Click += LinkLabel_LinkClicked;

                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Width = 80;
                deleteButton.Height = 30;
                deleteButton.Location = new Point(400, 2);
                deleteButton.Tag = coach;
                deleteButton.Click += DeleteButton_Click;

                panel.Controls.Add(linkLabel);
                panel.Controls.Add(deleteButton);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;
                if (button?.Tag is Coach coachToRemove)
                {
                    coachToRemove.Delete();
                    RenderCoaches();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        private void LinkLabel_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Label label = sender as Label;
                if (label?.Tag is Coach coach)
                {
                    CoachInfoForm infoForm = new CoachInfoForm(coach);
                    infoForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }
    }
}
