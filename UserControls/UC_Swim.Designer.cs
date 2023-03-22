﻿namespace The_Big_Pool.UserControls
{
    partial class UC_Swim
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Swim));
            panel1 = new Panel();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            panelCategory = new Panel();
            groupBoxCategory = new GroupBox();
            checkBoxSprint = new CheckBox();
            checkBoxPace = new CheckBox();
            checkBoxFreestyle = new CheckBox();
            checkBoxMedley = new CheckBox();
            checkBoxStroke = new CheckBox();
            panelDifficulty = new Panel();
            groupBoxDifficulty = new GroupBox();
            radioButtonSenior = new RadioButton();
            radioButtonGold = new RadioButton();
            radioButtonSilver = new RadioButton();
            radioButtonBronze = new RadioButton();
            radioButtonGarnet = new RadioButton();
            panelTime = new Panel();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panelDistance = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            groupBoxDistance = new GroupBox();
            label3 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panelCategory.SuspendLayout();
            groupBoxCategory.SuspendLayout();
            panelDifficulty.SuspendLayout();
            groupBoxDifficulty.SuspendLayout();
            panelTime.SuspendLayout();
            groupBox1.SuspendLayout();
            panelDistance.SuspendLayout();
            groupBoxDistance.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 73);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(183, 22);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 8;
            label8.Text = "Today's Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.MenuBar;
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(306, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 31);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 13);
            label1.Name = "label1";
            label1.Size = new Size(88, 45);
            label1.TabIndex = 0;
            label1.Text = "Swim";
            // 
            // button1
            // 
            button1.Location = new Point(485, 9);
            button1.Name = "button1";
            button1.Size = new Size(221, 53);
            button1.TabIndex = 1;
            button1.Text = "Generate Practice Swim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelCategory
            // 
            panelCategory.BackColor = Color.DeepSkyBlue;
            panelCategory.Controls.Add(groupBoxCategory);
            panelCategory.Location = new Point(131, 106);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(223, 258);
            panelCategory.TabIndex = 2;
            // 
            // groupBoxCategory
            // 
            groupBoxCategory.Controls.Add(checkBoxSprint);
            groupBoxCategory.Controls.Add(checkBoxPace);
            groupBoxCategory.Controls.Add(checkBoxFreestyle);
            groupBoxCategory.Controls.Add(checkBoxMedley);
            groupBoxCategory.Controls.Add(checkBoxStroke);
            groupBoxCategory.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxCategory.ForeColor = Color.White;
            groupBoxCategory.Location = new Point(20, 16);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Size = new Size(183, 227);
            groupBoxCategory.TabIndex = 0;
            groupBoxCategory.TabStop = false;
            groupBoxCategory.Text = "Categories";
            groupBoxCategory.Enter += groupBoxCategory_Enter;
            // 
            // checkBoxSprint
            // 
            checkBoxSprint.AutoSize = true;
            checkBoxSprint.Cursor = Cursors.No;
            checkBoxSprint.Location = new Point(34, 181);
            checkBoxSprint.Name = "checkBoxSprint";
            checkBoxSprint.Size = new Size(97, 35);
            checkBoxSprint.TabIndex = 9;
            checkBoxSprint.Text = "Sprint";
            checkBoxSprint.UseVisualStyleBackColor = true;
            // 
            // checkBoxPace
            // 
            checkBoxPace.AutoSize = true;
            checkBoxPace.Cursor = Cursors.No;
            checkBoxPace.Location = new Point(34, 146);
            checkBoxPace.Name = "checkBoxPace";
            checkBoxPace.Size = new Size(82, 35);
            checkBoxPace.TabIndex = 8;
            checkBoxPace.Text = "Pace";
            checkBoxPace.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreestyle
            // 
            checkBoxFreestyle.AutoSize = true;
            checkBoxFreestyle.Cursor = Cursors.No;
            checkBoxFreestyle.Location = new Point(34, 111);
            checkBoxFreestyle.Name = "checkBoxFreestyle";
            checkBoxFreestyle.Size = new Size(119, 35);
            checkBoxFreestyle.TabIndex = 7;
            checkBoxFreestyle.Text = "Freestyle";
            checkBoxFreestyle.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedley
            // 
            checkBoxMedley.AutoSize = true;
            checkBoxMedley.Cursor = Cursors.No;
            checkBoxMedley.Location = new Point(34, 76);
            checkBoxMedley.Name = "checkBoxMedley";
            checkBoxMedley.Size = new Size(103, 35);
            checkBoxMedley.TabIndex = 6;
            checkBoxMedley.Text = "Medley";
            checkBoxMedley.UseVisualStyleBackColor = true;
            // 
            // checkBoxStroke
            // 
            checkBoxStroke.AutoSize = true;
            checkBoxStroke.Cursor = Cursors.No;
            checkBoxStroke.Location = new Point(34, 38);
            checkBoxStroke.Name = "checkBoxStroke";
            checkBoxStroke.Size = new Size(98, 35);
            checkBoxStroke.TabIndex = 5;
            checkBoxStroke.Text = "Stroke";
            checkBoxStroke.UseVisualStyleBackColor = true;
            // 
            // panelDifficulty
            // 
            panelDifficulty.BackColor = Color.DeepSkyBlue;
            panelDifficulty.Controls.Add(groupBoxDifficulty);
            panelDifficulty.Location = new Point(376, 106);
            panelDifficulty.Name = "panelDifficulty";
            panelDifficulty.Size = new Size(223, 258);
            panelDifficulty.TabIndex = 3;
            // 
            // groupBoxDifficulty
            // 
            groupBoxDifficulty.Controls.Add(radioButtonSenior);
            groupBoxDifficulty.Controls.Add(radioButtonGold);
            groupBoxDifficulty.Controls.Add(radioButtonSilver);
            groupBoxDifficulty.Controls.Add(radioButtonBronze);
            groupBoxDifficulty.Controls.Add(radioButtonGarnet);
            groupBoxDifficulty.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDifficulty.ForeColor = Color.White;
            groupBoxDifficulty.Location = new Point(14, 20);
            groupBoxDifficulty.Name = "groupBoxDifficulty";
            groupBoxDifficulty.Size = new Size(194, 218);
            groupBoxDifficulty.TabIndex = 0;
            groupBoxDifficulty.TabStop = false;
            groupBoxDifficulty.Text = "Difficulty";
            // 
            // radioButtonSenior
            // 
            radioButtonSenior.AutoSize = true;
            radioButtonSenior.Location = new Point(46, 177);
            radioButtonSenior.Name = "radioButtonSenior";
            radioButtonSenior.Size = new Size(95, 35);
            radioButtonSenior.TabIndex = 4;
            radioButtonSenior.TabStop = true;
            radioButtonSenior.Text = "Senior";
            radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // radioButtonGold
            // 
            radioButtonGold.AutoSize = true;
            radioButtonGold.Location = new Point(46, 142);
            radioButtonGold.Name = "radioButtonGold";
            radioButtonGold.Size = new Size(80, 35);
            radioButtonGold.TabIndex = 3;
            radioButtonGold.TabStop = true;
            radioButtonGold.Text = "Gold";
            radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            radioButtonSilver.AutoSize = true;
            radioButtonSilver.Location = new Point(47, 107);
            radioButtonSilver.Name = "radioButtonSilver";
            radioButtonSilver.Size = new Size(88, 35);
            radioButtonSilver.TabIndex = 2;
            radioButtonSilver.TabStop = true;
            radioButtonSilver.Text = "Silver";
            radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonBronze
            // 
            radioButtonBronze.AutoSize = true;
            radioButtonBronze.Location = new Point(47, 72);
            radioButtonBronze.Name = "radioButtonBronze";
            radioButtonBronze.Size = new Size(101, 35);
            radioButtonBronze.TabIndex = 1;
            radioButtonBronze.TabStop = true;
            radioButtonBronze.Text = "Bronze";
            radioButtonBronze.UseVisualStyleBackColor = true;
            // 
            // radioButtonGarnet
            // 
            radioButtonGarnet.AutoSize = true;
            radioButtonGarnet.Location = new Point(47, 37);
            radioButtonGarnet.Name = "radioButtonGarnet";
            radioButtonGarnet.Size = new Size(102, 35);
            radioButtonGarnet.TabIndex = 0;
            radioButtonGarnet.TabStop = true;
            radioButtonGarnet.Text = "Garnet";
            radioButtonGarnet.UseVisualStyleBackColor = true;
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.DeepSkyBlue;
            panelTime.Controls.Add(groupBox1);
            panelTime.Location = new Point(376, 388);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(277, 121);
            panelTime.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(14, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 106);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 57);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "00";
            textBox4.Size = new Size(51, 39);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 57);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "00";
            textBox3.Size = new Size(51, 39);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "00";
            textBox2.Size = new Size(51, 39);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(173, 36);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 2;
            label6.Text = "Seconds";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(89, 36);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 1;
            label5.Text = "Minutes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(18, 36);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 0;
            label2.Text = "Hours";
            // 
            // panelDistance
            // 
            panelDistance.BackColor = Color.DeepSkyBlue;
            panelDistance.Controls.Add(label4);
            panelDistance.Controls.Add(textBox1);
            panelDistance.Controls.Add(groupBoxDistance);
            panelDistance.Location = new Point(77, 388);
            panelDistance.Name = "panelDistance";
            panelDistance.Size = new Size(277, 121);
            panelDistance.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(38, 43);
            label4.Name = "label4";
            label4.Size = new Size(201, 21);
            label4.TabIndex = 3;
            label4.Text = "Enter in 25 yard increments";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(43, 65);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "75";
            textBox1.Size = new Size(142, 39);
            textBox1.TabIndex = 0;
            // 
            // groupBoxDistance
            // 
            groupBoxDistance.Controls.Add(label3);
            groupBoxDistance.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDistance.ForeColor = Color.White;
            groupBoxDistance.Location = new Point(16, 7);
            groupBoxDistance.Name = "groupBoxDistance";
            groupBoxDistance.Size = new Size(245, 106);
            groupBoxDistance.TabIndex = 4;
            groupBoxDistance.TabStop = false;
            groupBoxDistance.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(178, 57);
            label3.Name = "label3";
            label3.Size = new Size(45, 31);
            label3.TabIndex = 2;
            label3.Text = "yds";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(179, 550);
            label7.Name = "label7";
            label7.Size = new Size(372, 25);
            label7.TabIndex = 6;
            label7.Text = "This is where we will have the workout appear";
            // 
            // UC_Swim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label7);
            Controls.Add(panelDistance);
            Controls.Add(panelTime);
            Controls.Add(panelDifficulty);
            Controls.Add(panelCategory);
            Controls.Add(panel1);
            Name = "UC_Swim";
            Size = new Size(731, 640);
            Load += UC_Swim_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCategory.ResumeLayout(false);
            groupBoxCategory.ResumeLayout(false);
            groupBoxCategory.PerformLayout();
            panelDifficulty.ResumeLayout(false);
            groupBoxDifficulty.ResumeLayout(false);
            groupBoxDifficulty.PerformLayout();
            panelTime.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelDistance.ResumeLayout(false);
            panelDistance.PerformLayout();
            groupBoxDistance.ResumeLayout(false);
            groupBoxDistance.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panelCategory;
        private Panel panelDifficulty;
        private Panel panelTime;
        private Panel panelDistance;
        private GroupBox groupBoxCategory;
        private GroupBox groupBoxDifficulty;
        private RadioButton radioButtonSenior;
        private RadioButton radioButtonGold;
        private RadioButton radioButtonSilver;
        private RadioButton radioButtonBronze;
        private RadioButton radioButtonGarnet;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private GroupBox groupBoxDistance;
        private Label label3;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private CheckBox checkBoxSprint;
        private CheckBox checkBoxPace;
        private CheckBox checkBoxFreestyle;
        private CheckBox checkBoxMedley;
        private CheckBox checkBoxStroke;
    }
}
