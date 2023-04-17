using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static The_Big_Pool.Login;

namespace The_Big_Pool.UserControls
{
    public partial class UC_History : UserControl
    {
        public UC_History()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                   .AddJsonFile("appsettings.json", true, true)
                   .Build();
            string connectionString = config.GetConnectionString("MongoDB");

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TheBigPool");
            var collection = database.GetCollection<BsonDocument>("user");
            DateTime selectedDate = monthCalendar1.SelectionStart;
            string date = selectedDate.ToString("MM/dd/yyyy");
            var filter = Builders<BsonDocument>.Filter.And(
    Builders<BsonDocument>.Filter.Eq("Username", UserSession.Instance.Username),
    Builders<BsonDocument>.Filter.Eq("Date", date)
);

            
            var chunks = collection.Find(filter).ToList();
            var count = chunks.Count;

            // Show a message box with yes and no buttons
            DialogResult result = MessageBox.Show("There are: "+count+" Practices from:  " + selectedDate.ToShortDateString() + " Would you like to download them?", "Selected Date", MessageBoxButtons.YesNo);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (chunks.Any())
                    {
                        var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        var downloadPath = Path.Combine(desktopFolder, date+".pdf");

                        using (var outputStream = File.Create(downloadPath))
                        {
                            foreach (var chunk in chunks.OrderBy(c => c["chunkNumber"].AsInt32))
                            {
                                var data = chunk["data"].AsByteArray;
                                outputStream.Write(data, 0, data.Length);
                            }
                        }
                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
                return;
          
            }
            else
            {
                // User clicked "No" button, do something else or just return
                return;
            }
        }
    }
}
