using Amazon.Auth.AccessControlPolicy;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static The_Big_Pool.Login;

namespace The_Big_Pool.UserControls
{
    public partial class UC_Edit : UserControl
    {
        //UC_Settings panelSide;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.json", true, true)
                   .Build();
            string connectionString = config.GetConnectionString("MongoDB");

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TheBigPool");
            var users = database.GetCollection<BsonDocument>("user");
            string username = UserSession.Instance.Username;
            var filter_user = Builders<BsonDocument>.Filter.Eq("Username", username);

            var document = users.Find(filter_user).FirstOrDefault();
            //need to add all the functions to the data is actually store
            if (textBox3.Text != "")
            {

                UserSession.Instance.Username = textBox3.Text;
                // Define the update to set the new username value
                var update = Builders<BsonDocument>.Update.Set("Username", textBox3.Text.ToLower());
                var result = users.UpdateOne(filter_user, update);
                if (result.ModifiedCount == 1)
                {
                    MessageBox.Show("Username updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Username update failed.");
                }
            }
            if (textBox4.Text != "" && textBox4.Text == textBox6.Text)
            {
                var update = Builders<BsonDocument>.Update.Set("Password", BCrypt.Net.BCrypt.HashPassword(textBox4.Text));
                var result = users.UpdateOne(filter_user, update);
                if (result.ModifiedCount == 1)
                {
                    MessageBox.Show("Password updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Password update failed.");
                }
            }

            if (comboBox2.Text != "")
            {
                var update = Builders<BsonDocument>.Update.Set("Settings.Preferred Categories", comboBox2.Text);
                var result = users.UpdateOne(filter_user, update);
                if (result.ModifiedCount == 1)
                {
                    MessageBox.Show("Categories updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Categories update failed.");
                }
            }
            if (comboBox1.Text != "")
            {
                var update = Builders<BsonDocument>.Update.Set("Settings.Skill level", comboBox1.Text);
                var result = users.UpdateOne(filter_user, update);
                if (result.ModifiedCount == 1)
                {
                    MessageBox.Show("Skill Level updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Skill Level update failed.");
                }
            }
            if (textBox1.Text != "")
                //and everything changes on the swimmer profile card and database\
                panelEdit.Controls.Clear();

        }
    }
}
