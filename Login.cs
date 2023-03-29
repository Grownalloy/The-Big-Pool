
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Net.Http;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
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
            var filter = Builders<BsonDocument>.Filter.Eq("Username", textBoxUsername.Text.ToLower());
            var document = users.Find(filter).FirstOrDefault();
            string TU = "";
            string TS = "";
            bool t = false;
            if (document != null)
            {
                TU = document["Username"].AsString;
                TS = document["Password"].AsString;
                t = BCrypt.Net.BCrypt.Verify(textBoxPassword.Text, TS);
            }

            if (t)
            {
                // Store the user's credentials in the UserSession object
                UserSession.Instance.Username = TU;
                UserSession.Instance.Password = TS;

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            
        }
        public class UserSession
        {
            private static UserSession? _instance;
            public static UserSession Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new UserSession();
                    }
                    return _instance;
                }
            }

            public string? Username { get; set; }
            public string? Password { get; set; }
        }

    }
}