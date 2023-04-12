using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Big_Pool.UserControls
{
    public partial class UC_Edit : UserControl
    {
        UC_Settings panelSide;
        public UC_Edit()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            panelEdit.Controls.Clear();
            panelEdit.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelEdit.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //need to add all the functions to the data is actually store
            //and everything changes on the swimmer profile card and database\
            panelEdit.Controls.Clear();
        }
    }
}
