using IronPdf;
using IronPdf.PrintDoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
      
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

            // Render HTML string as PDF
            try
            {
                HtmlToPdf practice = new HtmlToPdf();
                PdfDocument pdf = practice.RenderHtmlAsPdf(htmlString);
                pdf.SaveAs("practice.pdf");
                MessageBox.Show("Generated practice");

            }
            catch (Exception ex)
            {
                MessageBox.Show("failed to create practice");
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
