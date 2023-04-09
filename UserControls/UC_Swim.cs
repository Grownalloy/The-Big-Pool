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
            string Time = "";

            if (IsDigitsOnly(textBox2.Text) && textBox2.Text != "")
            {
                Time = textBox2.Text + ":";

                if (IsDigitsOnly(textBox3.Text) && textBox3.Text != "")
                {
                    if (int.TryParse(textBox3.Text, out int minutes) && minutes < 60 && minutes >= 0)
                    {
                        Time += textBox3.Text + ":";
                        if (int.TryParse(textBox4.Text, out int seconds) && seconds < 60 && seconds >= 0)
                        {
                            Time += textBox4.Text;
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
            Practicespecs practice = new Practicespecs(int.Parse(textBox1.Text), Skill, category, Time);

            string htmlString = "<!DOCTYPE html>\r\n<html>\r\n " +
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
                "</html>\r\n";
            // Replace placeholders with actual values
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string distance = "10 miles";
            string duration = "2 hours";
            string name = "John Doe";
            htmlString = htmlString
                .Replace("{DATE}", date)
                .Replace("{DISTANCE}", distance)
                .Replace("{DURATION}", duration)
                .Replace("{NAME}", name);

            try
            {
                HtmlToPdf practic = new HtmlToPdf();
                using (PdfDocument pdf = practic.RenderHtmlAsPdf(htmlString))
                {
                    var pdfStream = pdf.Stream;

                    //Connect to MongoDB
                    IConfiguration config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
                    string connectionString = config.GetConnectionString("MongoDB");

                    var client = new MongoClient(connectionString);
                    var database = client.GetDatabase("TheBigPool");

                    var users = database.GetCollection<BsonDocument>("user");
                    var gridFsBucket = new GridFSBucket(database);

                    string username = UserSession.Instance.Username;
                    string password = UserSession.Instance.Password;

                    // Query MongoDB to find the user document that matches the given username and password
                    var filter = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("username", username),
                        Builders<BsonDocument>.Filter.Eq("password", password));
                    var userDocument = await users.Find(filter).FirstOrDefaultAsync();

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
                }
                MessageBox.Show("Generated practice");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create practice or upload to MongoDB");
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
