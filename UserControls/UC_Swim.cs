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
using SharpCompress.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Font = iTextSharp.text.Font;
using iTextSharp.text.pdf.draw;

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
        public static int ConvertTimeToSeconds(string time) //hh:mm:ss
        {
            TimeSpan timeSpan = TimeSpan.Parse(time);
            return (int)timeSpan.TotalSeconds;
        }
        public static int ConvertTimeStringToSeconds(string timeString) //MM;ss
        {
            if (string.IsNullOrWhiteSpace(timeString))
            {
                throw new ArgumentException("Invalid time string.", nameof(timeString));
            }

            string[] timeParts = timeString.Split(':');
            if (timeParts.Length != 2)
            {
                throw new ArgumentException("Invalid time string format.", nameof(timeString));
            }

            if (!int.TryParse(timeParts[0], out int minutes) || !int.TryParse(timeParts[1], out int seconds))
            {
                throw new ArgumentException("Invalid time string format.", nameof(timeString));
            }

            if (minutes < 0 || seconds < 0 || seconds >= 60)
            {
                throw new ArgumentException("Invalid time string format.", nameof(timeString));
            }

            return (minutes * 60) + seconds;
        }

        public static string ConvertSecondsToTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;

            return string.Format("{0}:{1:D2}:{2:D2}", hours, minutes, remainingSeconds);
        }
        private void button1_Click(object sender, EventArgs e)
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

            int practicelength = ConvertTimeToSeconds(timeString);

            var elapsedist = 0;
            var elapsedtime = 0;

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
            var totaltime = 0;


            var warmuptime = practicelength / 5;
            var mainsettime = (int)((practicelength - warmuptime) * .85);
            var warmdowntime = practicelength - (mainsettime + warmuptime);
            practicelength = warmdowntime + mainsettime + warmuptime;
            // keep selecting sets until the total distance is greater than or equal to the target distance
            while (totalDistance <= remainingWU || totaltime<= warmuptime)
            {
                // randomly select a set from the warmup sets
                var index = rng.Next(warmupSets.Count);
                var set = warmupSets[index];

                // add the set to the selected sets and update the total distance

                BsonValue x = set.GetValue("Distance");
                BsonValue y = set.GetValue("Reps");
                BsonValue w = set.GetValue("interval");
              
                var t = ConvertTimeStringToSeconds(w.ToString())*y.ToInt32();
                var z = x.ToInt32() * y.ToInt32();
                if (((z + totalDistance) >= (remainingWU + (remainingWU / 8)))||((t+totaltime)>=(warmuptime+(int)(warmuptime/8))))
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
                    totalDistance += z;
                    elapsedist += z;
                    totaltime += t;
                    elapsedtime += t;
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
            iTextSharp.text.Font fontTitle = FontFactory.GetFont("TimesNewRoman", 30, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fontLine = FontFactory.GetFont("TimesNewRoman", 15, iTextSharp.text.Font.BOLD, BaseColor.BLUE);
            iTextSharp.text.Font fontSub = FontFactory.GetFont("TimesNewRoman", 15, iTextSharp.text.Font.BOLD, BaseColor.ORANGE);
            //Create a paragraph with custom font and alignment
            Paragraph intro = new Paragraph("The Big Pool" + "\n", fontTitle);
            Paragraph line= new Paragraph("--------------------------------------------------------------------------------------------------------", fontLine);
            Paragraph instructions = new Paragraph(" Time to jump in the pool!  Below your practice swim set has been generated. " +
                "Based upon your selections a warm-up set, main set, and warmdown has been created with the given reps x Distance."+
                " Some sets contain extra information depending on the category selected.");
            line.Alignment = Element.ALIGN_CENTER;
            instructions.Alignment = Element.ALIGN_CENTER;
            intro.Alignment = Element.ALIGN_CENTER;

            //Add paragraph to the document
            doc.Add(intro);
            doc.Add(line);
            doc.Add(instructions);

            //Warm up set section
            Paragraph warmups = new Paragraph("Warm Up: \n",fontSub);
            warmups.Alignment = Element.ALIGN_LEFT;
            doc.Add(warmups);

            foreach (var set in selectedSets)
            {
                var description = set.GetValue("Set Description").ToString();
                var reps = set.GetValue("Reps").ToString();
                var distance = set.GetValue("Distance").ToString();
                var interval = set.GetValue("interval").ToString();
                if (interval != "00:00")
                {
                    // replace the comma in the distance with an x
                    distance = distance.Replace(",", "x");

                    // create a paragraph with the set description, reps, and distance
                    var paragraph = new Paragraph($" {reps} x {distance}     {interval}          {description}");

                    // add the paragraph to the document
                    paragraph.IndentationLeft = 30;
                    doc.Add(paragraph);
                }
                else
                {
                    var paragraph = new Paragraph($" {reps} x {distance}                 {description}");

                    // add the paragraph to the document
                    paragraph.IndentationLeft = 30;
                    doc.Add(paragraph);
                }
            }

            var p = new Paragraph("Total Distance: "+$"{totalDistance}"+"\n");
            doc.Add(p);


            //Main sets section
            Paragraph Mainset = new Paragraph("Main Sets:"+ "\n",fontSub);
            doc.Add(Mainset); 

            int remainingMS = practice.mainset();

            var filterBuilder = Builders<BsonDocument>.Filter;
            var checkedItems = new List<string>();
            var filters = new List<FilterDefinition<BsonDocument>>();


            if (checkBoxFreestyle.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("freestyle", "i")));
            }

            if (checkBoxMedley.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("medley", "i")));
            }

            if (checkBoxPace.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("pace", "i")));
            }

            if (checkBoxSprint.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("sprint", "i")));
            }

            if (checkBoxStroke.Checked)
            {
                filters.Add(Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("stroke", "i")));
            }


            filter = Builders<BsonDocument>.Filter.Or(filters);






            filter = Builders<BsonDocument>.Filter.And(filter, skillFilter);
            var MainSets = sets.Find(filter).ToList();

            // create variables to keep track of the selected sets and the total distance
            selectedSets = new List<BsonDocument>();
            totalDistance = 0;
            totaltime = 0;
            // keep selecting sets until the total distance is greater than or equal to the target distance
            while (totalDistance < remainingMS || totaltime < mainsettime)
            {
                // randomly select a set from the warmup sets
                var index = rng.Next(MainSets.Count);
                var set = MainSets[index];

                // add the set to the selected sets and update the total distance
                BsonValue x = set.GetValue("Distance");
                BsonValue y = set.GetValue("Reps");
                BsonValue w = set.GetValue("interval");
                var t = ConvertTimeStringToSeconds(w.ToString()) * y.ToInt32();
                var z = x.ToInt32() * y.ToInt32();
                if (((z + totalDistance) >= (remainingMS + (remainingMS / 4))) || ((t + totaltime) >= (mainsettime + (int)(mainsettime / 8))))
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
                    elapsedist += z;
                    totaltime += t;
                    elapsedtime += t;
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
                if (interval != "00:00")
                {
                    // replace the comma in the distance with an x
                    distance = distance.Replace(",", "x");

                    // create a paragraph with the set description, reps, and distance
                    var paragraph = new Paragraph($" {reps} x {distance}     {interval}          {description}");

                    // add the paragraph to the document
                    paragraph.IndentationLeft = 30;
                    doc.Add(paragraph);
                }
                else
                {
                    var paragraph = new Paragraph($" {reps} x {distance}                 {description}");

                    // add the paragraph to the document
                    paragraph.IndentationLeft = 30;
                    doc.Add(paragraph);
                }
            }

            p = new Paragraph("Total Distance:"+  $" {totalDistance}\n");
            doc.Add(p);

            int remainingWD = practice.warmdown();

            categoryFilter = Builders<BsonDocument>.Filter.Regex("Category", new BsonRegularExpression("warmdown", "i")); //When added change warmup to warmdown
            filter = Builders<BsonDocument>.Filter.And(categoryFilter, skillFilter);



            var warmdownSets = sets.Find(filter).ToList();
            selectedSets = new List<BsonDocument>();
            totalDistance = 0;
            totaltime = 0;
            // keep selecting sets until the total distance is greater than or equal to the target distance
            while (totalDistance < remainingWD || totaltime < warmdowntime)
            {
                // randomly select a set from the warmup sets
                if ((warmdownSets.Count == 0))
                {
                    break;
                }
                var index = rng.Next(warmdownSets.Count);
                var set = warmdownSets[index];

                // add the set to the selected sets and update the total distance

                BsonValue x = set.GetValue("Distance");
                BsonValue y = set.GetValue("Reps");
                BsonValue w = set.GetValue("interval");
                var t = ConvertTimeStringToSeconds(w.ToString()) * y.ToInt32();
                var z = x.ToInt32() * y.ToInt32();
                if (((z + totalDistance) >= (remainingWU + (remainingWU / 4))) || ((t + totaltime) >= (warmuptime + (int)(warmuptime / 4))))
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
                    totalDistance += z;
                    elapsedist += z;
                    totaltime += t;
                    elapsedtime += t;
                    // remove the set from the warmup sets to prevent duplicates
                    warmdownSets.RemoveAt(index);

                    // if all warmup sets have been selected, break out of the loop
                    if (warmdownSets.Count == 0)
                    {
                        break;
                    }
                }
            }

            Paragraph Sideset = new Paragraph("Warmdown: ", fontSub);
            doc.Add(Sideset);

            foreach (var setD in selectedSets)
            {
                var description = setD.GetValue("Set Description").ToString();
                var reps = setD.GetValue("Reps").ToString();
                var distance = setD.GetValue("Distance").ToString();
                var interval = setD.GetValue("interval").ToString();
                if (interval != "00:00")
                {
                    // replace the comma in the distance with an x
                    distance = distance.Replace(",", "x");

                    // create a paragraph with the set description, reps, and distance
                    var paragraph = new Paragraph($" {reps} x {distance}     {interval}          {description}");

                    // add the paragraph to the document
                    paragraph.IndentationLeft = 30;
                    doc.Add(paragraph);
                }
                else
                {
                    var paragraph = new Paragraph($" {reps} x {distance}                 {description}");

                    // add the paragraph to the document
                    paragraph.IndentationLeft = 30;
                    doc.Add(paragraph);
                }
            }



            p = new Paragraph("Total Duration of Practice:" + $" {ConvertSecondsToTime(elapsedtime)}\n");
            doc.Add(p);
            p = new Paragraph("Total Distance of Practice:" + $" {elapsedist}\n");
            doc.Add(p);
            doc.Close();
            MessageBox.Show("practice saved to desktop");
            try
            {
                var collection = database.GetCollection<BsonDocument>("user");
                string username = UserSession.Instance.Username;

                // Generate a unique ID for each document
                string documentId = "SelectedSets_" + Guid.NewGuid().ToString();

                // Create the PDF metadata
                var metadata = new BsonDocument
    {
        { "practices", documentId },
        { "date", TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
            TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")).ToString("MM/dd/yyyy") }
    };

                // Insert the metadata into the MongoDB collection
                var filter_user = Builders<BsonDocument>.Filter.Eq("Username", username);
                var update = Builders<BsonDocument>.Update.Push("metadata", metadata);
                var options = new FindOneAndUpdateOptions<BsonDocument>
                {
                    ReturnDocument = ReturnDocument.After,
                    IsUpsert = true //This inserts a new document if one doesn't exist
                };
                var updatedDocument = collection.FindOneAndUpdate(filter_user, update, options);

                // Divide the PDF file into chunks and add each chunk to the document
                var filePath = output;
                int chunkSize = 1024 * 1024; // 1 MB chunk size
                int chunkNumber = 1;

                using (var stream = File.OpenRead(filePath))
                {
                    byte[] buffer = new byte[chunkSize];
                    int bytesRead;

                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        var chunkData = new BsonDocument
            {
                            {"Date", TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
            TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")).ToString("MM/dd/yyyy") },
                            {"Total Time", ConvertSecondsToTime(elapsedtime) },
                            {"Total Distance", elapsedist },
                { "documentId", documentId },
                { "chunkNumber", chunkNumber },
                { "data", new BsonBinaryData(buffer, BsonBinarySubType.Binary, GuidRepresentation.Unspecified) }
          };

                        update = Builders<BsonDocument>.Update.Push("chunks", chunkData);
                        updatedDocument = collection.FindOneAndUpdate(filter_user, update, options);
                        chunkNumber++;
                    }
                }

                // Download the uploaded PDF to a local file on the desktop
                var filter_document = Builders<BsonDocument>.Filter.Eq("documentId", documentId);
                var chunks = collection.Find(filter_document).ToList();

                if (chunks.Any())
                {
                    var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    var downloadPath = Path.Combine(desktopFolder, "downloadtest.pdf");

                    using (var outputStream = File.Create(downloadPath))
                    {
                        foreach (var chunk in chunks.OrderBy(c => c["chunkNumber"].AsInt32))
                        {
                            var data = chunk["data"].AsByteArray;
                            outputStream.Write(data, 0, data.Length);
                        }
                    }
                }

                if (File.Exists(output))
                {
                    //File.Delete(output);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Failed to create practice or upload to MongoDB");
                Clipboard.SetText(ex.Message);
            }
        }

    }
}
