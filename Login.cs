
using MongoDB.Bson;
using MongoDB.Driver;
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
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://Aparra:YEBZBMZIK24wWW9P@cluster0.yrrbhan.mongodb.net/?retryWrites=true&w=majority");
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

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            
        }
    }
}