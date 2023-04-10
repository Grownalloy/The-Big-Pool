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
            if (category == "")
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

            var totalWUDistance = int.Parse(practice.finaldist());

            var remainingWU = practice.warmup();
            var filter = Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("warmup", "i"));

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
                selectedSets.Add(set);
                BsonValue x = set.GetValue("Distance");
                totalDistance += x.ToInt32();

                // remove the set from the warmup sets to prevent duplicates
                warmupSets.RemoveAt(index);

                // if all warmup sets have been selected, break out of the loop
                if (warmupSets.Count == 0)
                {
                    break;
                }
            }

            // do something with the selected sets (e.g. add them to the PDF)
            // create the PDF document and writer
            var doc = new Document();
            var output = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SelectedSets.pdf");
            var writer = PdfWriter.GetInstance(doc, new FileStream(output, FileMode.Create));

            // open the document
            doc.Open();

            // add each selected set to the document
            foreach (var set in selectedSets)
            {
                var description = set.GetValue("Set Description").ToString();
                var reps = set.GetValue("Reps").ToString();
                var distance = set.GetValue("Distance").ToString();

                // replace the comma in the distance with an x
                distance = distance.Replace(",", "x");

                // create a paragraph with the set description, reps, and distance
                var paragraph = new Paragraph($" {reps} x {distance}                            {description}");

                // add the paragraph to the document
                doc.Add(paragraph);
            }

            // close the document
            doc.Close();

            // show a message box indicating that the PDF was created
            MessageBox.Show("PDF file created on your desktop.");

            int remainingMS = practice.mainset();
            int remainingWD = practice.warmdown();




            string htmlString =
                ("<!DOCTYPE html>\r\n<html>\r\n " +
                " <head>\r\n    " +
                "<meta charset=\"UTF-8\">\r\n    " +
                "<title>PDF Header</title>\r\n    " +
                "<style>\r\n      " +
                ".header {\r\n        " +
                "display: flex;\r\n" +
                "        justify-content: space-between;\r\n" +
                "        align-items: center;\r\n" +
                "        padding: 10px;\r\n" +
                "        background-color: #f2f2f2;\r\n" +
                "        border-bottom: 1px solid #ccc;\r\n" +
                "      }\r\n\r\n" +
                "      .header__date {\r\n" +
                "        font-size: 20px;\r\n" +
                "        font-weight: bold;\r\n" +
                "      }\r\n\r\n" +
                "      .header__title {\r\n" +
                "        font-size: 24px;\r\n" +
                "        font-weight: bold;\r\n" +
                "      }\r\n\r\n" +
                "      .header__name {\r\n" +
                "        font-size: 20px;\r\n" +
                "        font-weight: bold;\r\n" +
                "      }\r\n " +
                "   </style>\r\n " +
                " </head>\r\n  " +
                "<body>\r\n " +
                "   <div class=\"header\">\r\n" +
                "      <div class=\"header__date\">{DATE}</div>\r\n" +
                "      <div class=\"header__title\">Distance: {DISTANCE} | Duration: {DURATION}</div>\r\n " +
                "     <div class=\"header__name\">{NAME}</div>\r\n " +
                "   </div>\r\n" +
                "  </body>\r\n" +
                "</html>\r\n");

            // Replace placeholders with actual values
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            htmlString = htmlString
                .Replace("{DATE}", date)
                .Replace("{DISTANCE}", practice.finaldist())
                .Replace("{DURATION}", timeString)
                .Replace("{NAME}", UserSession.Instance.Username);

            try
            {

                /* var users = database.GetCollection<BsonDocument>("user");
                  var gridFsBucket = new GridFSBucket(database);

                  string username = UserSession.Instance.Username;
                  string password = UserSession.Instance.Password;

                  // Query MongoDB to find the user document that matches the given username and password
                  var filteract = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("username", username),
                      Builders<BsonDocument>.Filter.Eq("password", password));
                  var userDocument = await users.Find(filteract).FirstOrDefaultAsync();

                  if (userDocument != null)
                  {
                      // Retrieve the documentId from the user document
                      string documentId = userDocument.GetValue("documentId").AsString;

                      // Use the documentId to store the PDF in the correct document
                      var fileId = gridFsBucket.UploadFromStream("practice_uploaded.pdf", pdfStream, new GridFSUploadOptions
                      {
                          Metadata = new BsonDocument
                                  {
                                      { "documentId", documentId },
                                      { "type", "practice" }
                                  }
                      }
                        );
                  }

         */
                MessageBox.Show("Generated practice");
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
