﻿using Microsoft.Extensions.Configuration;
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
        private string Date = "MM/dd/yyyy";
        private string Date2 = "MM-dd-yyyy.pdf";
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
            DateTime selectedDate = monthCalendar1.SelectionStart;
            Date = selectedDate.ToString("MM/dd/yyyy");
            Date2 = selectedDate.ToString("MM-dd-yyyy") + ".pdf";
            IConfiguration config = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", true, true)
                  .Build();
            string connectionString = config.GetConnectionString("MongoDB");

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TheBigPool");
            var collection = database.GetCollection<BsonDocument>("user");
            string date = selectedDate.ToString("MM/dd/yyyy");
            var filter = Builders<BsonDocument>.Filter.And(
    Builders<BsonDocument>.Filter.Eq("Username", UserSession.Instance.Username),
    Builders<BsonDocument>.Filter.Eq("chunks.Date", date));

            var projection = Builders<BsonDocument>.Projection.Include("chunks.chunkNumber").Include("chunks.Total Distance").Include("chunks.Total Time");

            var doc = collection.Find(filter).Project(projection).FirstOrDefault();

            if (doc != null && doc["chunks"] is BsonArray chunks && chunks.Count > 0)
            {
                var firstChunk = chunks[0];
                var x = firstChunk["Total Distance"].ToInt32();
                label5.Text = x.ToString();
                label8.Text = firstChunk["Total Time"].ToString();
            }
            else
            {
                label5.Text = "0";
                label8.Text = "00:00:00";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true, true)
    .Build();
            string connectionString = config.GetConnectionString("MongoDB");

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TheBigPool");
            var collection = database.GetCollection<BsonDocument>("user");
           
            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("Username", UserSession.Instance.Username),
                Builders<BsonDocument>.Filter.Eq("chunks.Date", Date)
            );
            var projection = Builders<BsonDocument>.Projection.Include("chunks.chunkNumber").Include("chunks.data");

            var cursor = collection.Find(filter).Project(projection).ToCursor();
            var chunks = new List<BsonDocument>();
            while (cursor.MoveNext())
            {
                chunks.AddRange(cursor.Current);
            }

            var count = chunks.Count;

            // Show a message box with yes and no buttons
            DialogResult result = MessageBox.Show("There are: " + count + " Practices from:  " + Date + " Would you like to download them?", "Selected Date", MessageBoxButtons.YesNo);

            // Check the user's response
            if (count != 0)
            {
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (chunks.Any())
                        {
                            var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            var downloadPath = Path.Combine(desktopFolder, Date2);

                            using (var outputStream = File.Create(downloadPath))
                            {
                                foreach (var chunk in chunks)
                                {
                                    foreach (var chunkDoc in chunk["chunks"].AsBsonArray)
                                    {
                                        var data = chunkDoc["data"].AsByteArray;
                                        var chunkNumber = chunkDoc["chunkNumber"].ToInt32();
                                        outputStream.Write(data, 0, data.Length);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    return;
                }
                else
                {
                    // User clicked "No" button, do something else or just return
                    return;
                }
            }
            else
            {
                MessageBox.Show("There are no practices from: " + Date);
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}





