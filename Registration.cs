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

namespace The_Big_Pool
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonBacktoLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int prefdist;
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            string connectionString = config.GetConnectionString("MongoDB");

            var settings = MongoClientSettings.FromConnectionString(connectionString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            IMongoDatabase database = client.GetDatabase("TheBigPool");
            var users = database.GetCollection<BsonDocument>("user");
            //Add a filter to search by usernames
            var filter = Builders<BsonDocument>.Filter.Eq("Username", textBoxUsername.Text);
            var document = users.Find(filter).FirstOrDefault();
            string TU = "";
            string failcause = "";
            if (document != null)
            {
                TU = document["Username"].AsString;
            }
            TU = TU.ToLower();
            if (TU == textBoxUsername.Text.ToLower())
                failcause += "Username is already taken \n";
            if (comboBox1.SelectedIndex < -1)
                failcause += "Category needs to be selected \n";
            if (comboBox2.SelectedIndex < -1)
                failcause += "Difficculty level needs to be selected \n";
            if (textBox1.Text == "")
                failcause += "Distance needs to be entered \n";
            User Act = new User(textBoxUsername.Text, textBoxPassword.Text);
            failcause += Act.failurecause();
            if (textBoxPassword.Text != textBoxConPass.Text)
                failcause += "Passwords do not match";
            if (failcause == "")
            {
                prefdist =int.Parse( textBox1.Text);
                string hashpass = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);


                var doc = new BsonDocument
                {
                    {"Username", textBoxUsername.Text.ToLower() },
                    {"Password", hashpass },
                    { "Settings", new BsonDocument {
                        {"Preferred Categories", comboBox1.Text },
                        {"Difficulty Level",comboBox2.Text },
                        { "Skill level", comboBox2.Text },
                        { "Preffered Distance", prefdist },
                        { "Duration of work-out", Act.get_duration() }
                                                    }
                    }
                };
                users.InsertOne(doc);
                MessageBox.Show(comboBox1.Text);
                MessageBox.Show(comboBox2.Text);
                MessageBox.Show("Added account");
            }
            else
            {
                MessageBox.Show(failcause);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
