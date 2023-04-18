using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Big_Pool.UserControls;
using static The_Big_Pool.Login;

namespace The_Big_Pool
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            labelUsername.Text = UserSession.Instance.Username;
        }
        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            panelDashboard.Controls.Clear();
            panelDashboard.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addUserControl(uc);
        }

        private void buttonSwim_Click(object sender, EventArgs e)
        {
            UC_Swim uc = new UC_Swim();
            addUserControl(uc);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            UC_History uc = new UC_History();
            addUserControl(uc);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            addUserControl(uc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
