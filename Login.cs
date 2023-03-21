
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace The_Big_Pool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(); //(TS, Username.Text);
            registration.Show();
            Visible = false;
        }
    }
}