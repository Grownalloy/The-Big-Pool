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
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://Aparra:YEBZBMZIK24wWW9P@cluster0.yrrbhan.mongodb.net/?retryWrites=true&w=majority");
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
               TU=document["Username"].AsString;
            }
            TU = TU.ToLower();
            if (TU == textBoxUsername.Text.ToLower())
                failcause += "Username is already taken \n";
            if (textBoxFirstName.Text == "")
                failcause += "First Name is empty \n";
            if (textBoxLastName.Text == "")
                failcause += "Last Name is empty \n";
            if (textBoxEmail.Text == "")
                failcause += "Email is empty \n";
           User Act= new User(textBoxUsername.Text,textBoxPassword.Text);
            failcause += Act.failurecause();
            if (textBoxPassword.Text != textBoxConPass.Text)
                failcause += "Passwords do not match";
            if (failcause=="")
            {
                string hashpass = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);


                var doc = new BsonDocument
                {
                    {"Username", textBoxUsername.Text.ToLower() },
                    {"Password", hashpass },
                    { "Settings", new BsonDocument {
                        {"Name", textBoxFirstName.Text },
                        {"Surname",textBoxLastName.Text },
                        {"Email",textBoxEmail.Text},
                        { "Skill level", Act.get_skill() },
                        { "Preffered Distance", Act.get_Distance() },
                        { "Duration of work-out", Act.get_duration() }
                                                    }
                    }
                };
                users.InsertOne(doc);
                MessageBox.Show("Added account");
            }
            else
            {
                MessageBox.Show(failcause);
            }

                
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
