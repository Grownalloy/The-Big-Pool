using IronPdf;
using IronPdf.PrintDoc;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using static The_Big_Pool.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;

namespace The_Big_Pool.UserControls
{
    public partial class UC_Swim : UserControl
    {
        public UC_Swim()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string category = "";
            string Skill = "";
            string timeString = "";

            if (IsDigitsOnly(textBox2.Text) && textBox2.Text != "")
            {
                timeString = textBox2.Text + ":";

                if (IsDigitsOnly(textBox3.Text) && textBox3.Text != "")
                {
                    if (int.TryParse(textBox3.Text, out int minutes) && minutes < 60 && minutes >= 0)
                    {
                        // Ensure that the minutes are two digits
                        timeString += minutes.ToString("D2") + ":";

                        if (int.TryParse(textBox4.Text, out int seconds) && seconds < 60 && seconds >= 0)
                        {
                            // Ensure that the seconds are two digits
                            timeString += seconds.ToString("D2");

                            // Parse the time string into a TimeSpan object

                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number of seconds (0-59).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number of minutes (0-59).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of minutes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                return;
            }

            TimeSpan totalTime = TimeSpan.Parse(timeString);


            if (radioButtonGarnet.Checked) { Skill = "Garnet"; }
            if (radioButtonBronze.Checked) { Skill = "Bronze"; }
            if (radioButtonSilver.Checked) { Skill = "Silver"; }
            if (radioButtonGold.Checked) { Skill = "Gold"; }
            if (radioButtonSenior.Checked) { Skill = "Senior"; }
            if (Skill == "")
            {
                MessageBox.Show("Please select a skill level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (checkBoxFreestyle.Checked)
            { category += "Freestyle,"; }
            if (checkBoxMedley.Checked)
                category += "Medley,";
            if (checkBoxPace.Checked)
                category += "Pace,";
            if (checkBoxSprint.Checked)
                category += "Sprint,";
            if (checkBoxStroke.Checked)
                category += "Stroke";
            if (!checkBoxFreestyle.Checked && !checkBoxMedley.Checked && !checkBoxPace.Checked && !checkBoxSprint.Checked && !checkBoxStroke.Checked)
            {
                MessageBox.Show("Please select at least one category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Practicespecs practice = new Practicespecs(int.Parse(textBox1.Text), Skill, category, timeString);

            IConfiguration config = new ConfigurationBuilder()
                     .AddJsonFile("appsettings.json", true, true)
                     .Build();
            string connectionString = config.GetConnectionString("MongoDB");

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("TheBigPool");
            var sets = database.GetCollection<BsonDocument>("sets");



            var remainingWU = practice.warmup();
            var categoryFilter = Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("warmup", "i"));
            var skillFilter = Builders<BsonDocument>.Filter.Eq("Skill", new BsonRegularExpression(Skill, "i"));
            var filter = Builders<BsonDocument>.Filter.And(categoryFilter, skillFilter);


            // get the warmup sets
            var warmupSets = sets.Find(filter).ToList();
            var rng = new Random();

            // create variables to keep track of the selected sets and the total distance
            var selectedSets = new List<BsonDocument>();
            var totalDistance = 0;

            // keep selecting sets until the total distance is greater than or equal to the target distance
            while (totalDistance < remainingWU)
            {
                // randomly select a set from the warmup sets
                var index = rng.Next(warmupSets.Count);
                var set = warmupSets[index];

                // add the set to the selected sets and update the total distance

                BsonValue x = set.GetValue("Distance");
                BsonValue y = set.GetValue("Reps");
                var z = x.ToInt32() * y.ToInt32();
                if ((z + totalDistance) > (remainingWU + (remainingWU / 8)))
                {
                    warmupSets.RemoveAt(index);

                    // if all warmup sets have been selected, break out of the loop
                    if (warmupSets.Count == 0)
                    {
                        break;
                    }
                }
                else
                {
                    MessageBox.Show(index.ToString());
                    totalDistance += z;
                    selectedSets.Add(set);
                    // remove the set from the warmup sets to prevent duplicates
                    warmupSets.RemoveAt(index);

                    // if all warmup sets have been selected, break out of the loop
                    if (warmupSets.Count == 0)
                    {
                        break;
                    }
                }
            }
            var doc = new Document();
            var output = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SelectedSets.pdf");
            var writer = PdfWriter.GetInstance(doc, new FileStream(output, FileMode.Create));


            doc.Open();


            foreach (var set in selectedSets)
            {
                var description = set.GetValue("Set Description").ToString();
                var reps = set.GetValue("Reps").ToString();
                var distance = set.GetValue("Distance").ToString();
                var interval = set.GetValue("interval").ToString();


                distance = distance.Replace(",", "x");


                var paragraph = new Paragraph($" {reps}     x      {distance} ");
                var tab = new Paragraph("\t");


                doc.Add(paragraph);
            }
            var p = new Paragraph($"{totalDistance}");
            doc.Add(p);

            MessageBox.Show("PDF file created on your desktop.");

            int remainingMS = practice.mainset();

            var filterBuilder = Builders<BsonDocument>.Filter;
            var checkedItems = new List<string>();
            var filters = new List<FilterDefinition<BsonDocument>>();


            if (checkBoxFreestyle.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("Freestyle", "i")));
            }

            if (checkBoxMedley.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("Medley", "i")));
            }

            if (checkBoxPace.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("Pace", "i")));
            }

            if (checkBoxSprint.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("Sprint", "i")));
            }

            if (checkBoxStroke.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("Stroke", "i")));
            }


            filter = Builders<BsonDocument>.Filter.Or(filters);






            filter = Builders<BsonDocument>.Filter.And(filter, skillFilter);
            var MainSets = sets.Find(filter).ToList();
            string bsonFiles = "";
            foreach (var set in MainSets)
            {
                bsonFiles += set.ToBson() + "\n\n";
            }
            MessageBox.Show(bsonFiles);

            // create variables to keep track of the selected sets and the total distance
            selectedSets = new List<BsonDocument>();
            totalDistance = 0;

            // keep selecting sets until the total distance is greater than or equal to the target distance
            while (totalDistance < remainingMS)
            {
                // randomly select a set from the warmup sets
                var index = rng.Next(MainSets.Count);
                var set = MainSets[index];

                // add the set to the selected sets and update the total distance
                selectedSets.Add(set);


                BsonValue x = set.GetValue("Distance");
                BsonValue y = set.GetValue("Reps");
                var z = x.ToInt32() * y.ToInt32();
                if (z > (remainingMS - totalDistance))
                {
                    MainSets.RemoveAt(index);

                    // if all warmup sets have been selected, break out of the loop
                    if (MainSets.Count == 0)
                    {
                        break;
                    }
                }
                else
                {
                    totalDistance += z;
                    selectedSets.Add(set);
                    // remove the set from the warmup sets to prevent duplicates
                    MainSets.RemoveAt(index);

                    // if all warmup sets have been selected, break out of the loop
                    if (MainSets.Count == 0)
                    {
                        break;
                    }
                }

            }
            foreach (var setb in selectedSets)
            {
                var description = setb.GetValue("Set Description").ToString();
                var reps = setb.GetValue("Reps").ToString();
                var distance = setb.GetValue("Distance").ToString();
                var interval = setb.GetValue("interval").ToString();

                // replace the comma in the distance with an x
                distance = distance.Replace(",", "x");

                // create a paragraph with the set description, reps, and distance
                var paragraph = new Paragraph($" {reps}     x      {distance}              {interval}\t                    \t{description}");

                // add the paragraph to the document
                doc.Add(paragraph);
            }
            p = new Paragraph($"{totalDistance}");
            doc.Add(p);

            int remainingWD = practice.warmdown();

            categoryFilter = Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("warmup", "i")); //When added change warmup to warmdown
            filter = Builders<BsonDocument>.Filter.And(categoryFilter, skillFilter);



            var warmdownSets = sets.Find(filter).ToList();
            selectedSets = new List<BsonDocument>();
            totalDistance = 0;

            // keep selecting sets until the total distance is greater than or equal to the target distance
            while (totalDistance < remainingWD)
            {
                // randomly select a set from the warmup sets
                var index = rng.Next(warmdownSets.Count);
                var set = warmdownSets[index];

                // add the set to the selected sets and update the total distance

                int x = set.GetValue("Distance").ToInt32();
                x = x * set.GetValue("Reps").ToInt32();
                if (x + totalDistance > (remainingWD + (remainingWD / 8)))
                {

                    warmdownSets.RemoveAt(index);

                    // if all warmup sets have been selected, break out of the loop
                    if (warmdownSets.Count == 0)
                    {
                        break;
                    }
                }
                else
                {
                    selectedSets.Add(set);
                    totalDistance += x;

                    // remove the set from the warmup sets to prevent duplicates
                    warmdownSets.RemoveAt(index);

                    // if all warmup sets have been selected, break out of the loop
                    if (warmdownSets.Count == 0)
                    {
                        break;
                    }
                }
            }
            foreach (var setD in selectedSets)
            {
                var description = setD.GetValue("Set Description").ToString();
                var reps = setD.GetValue("Reps").ToString();
                var distance = setD.GetValue("Distance").ToString();
                var interval = setD.GetValue("interval").ToString();

                // replace the comma in the distance with an x
                distance = distance.Replace(",", "x");

                // create a paragraph with the set description, reps, and distance
                var paragraph = new Paragraph($" {reps}     x      {distance}                                                                                                {description}");

                // add the paragraph to the document
                doc.Add(paragraph);
            }
            p = new Paragraph($"{totalDistance}");
            doc.Add(p);
            doc.Close();
            try
            {
                var collection = database.GetCollection<BsonDocument>("user");
                string username = UserSession.Instance.Username;
                // Generate a unique ID for each document
                string documentId = "SelectedSets_" + Guid.NewGuid().ToString();
                // Create the PDF metadata
                var metadata = new BsonDocument
                    {
                        { "practices", documentId},
                        { "date", TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
                        TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")).ToString("MM/dd/yyyy HH:mm:ss") }
                    };
                //byte[] metadataBytes = metadata.ToBson();
                //int metadataSize = metadataBytes.Length;
                //metadata.Add("size", metadataSize);

                // Insert the metadata into the MongoDB collection
                var filter_user = Builders<BsonDocument>.Filter.Eq("Username", username);
                var update = Builders<BsonDocument>.Update.Push("metadata", metadata);
                var options = new FindOneAndUpdateOptions<BsonDocument>
                {
                    ReturnDocument = ReturnDocument.After,
                    IsUpsert = true //This inserts a new document if one doesnt exist
                };
                var updatedDocument = collection.FindOneAndUpdate(filter_user, update, options);

                // Check if the metadata was inserted successfully to the db
                if (updatedDocument != null)
                {
                    var insertedMetadata = updatedDocument["metadata"].AsBsonArray.Last().AsBsonDocument;
                    if (insertedMetadata == metadata)
                    {
                        MessageBox.Show("Pushed PDF to database successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert metadata into database");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to update user document in database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create practice or upload to MongoDB\n" + ex);
                // Handle exception
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_Swim_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxCategory_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
