namespace The_Big_Pool.UserControls
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.checkBoxSprint = new System.Windows.Forms.CheckBox();
            this.checkBoxPace = new System.Windows.Forms.CheckBox();
            this.checkBoxFreestyle = new System.Windows.Forms.CheckBox();
            this.checkBoxMedley = new System.Windows.Forms.CheckBox();
            this.checkBoxStroke = new System.Windows.Forms.CheckBox();
            this.panelDifficulty = new System.Windows.Forms.Panel();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioButtonSenior = new System.Windows.Forms.RadioButton();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonBronze = new System.Windows.Forms.RadioButton();
            this.radioButtonGarnet = new System.Windows.Forms.RadioButton();
            this.panelTime = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDistance = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxDistance = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.panelDifficulty.SuspendLayout();
            this.groupBoxDifficulty.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelDistance.SuspendLayout();
            this.groupBoxDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 93);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Today\'s Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 39);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Swim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Practice Swim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelCategory.Controls.Add(this.groupBoxCategory);
            this.panelCategory.Location = new System.Drawing.Point(170, 136);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(290, 330);
            this.panelCategory.TabIndex = 2;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.checkBoxSprint);
            this.groupBoxCategory.Controls.Add(this.checkBoxPace);
            this.groupBoxCategory.Controls.Add(this.checkBoxFreestyle);
            this.groupBoxCategory.Controls.Add(this.checkBoxMedley);
            this.groupBoxCategory.Controls.Add(this.checkBoxStroke);
            this.groupBoxCategory.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCategory.ForeColor = System.Drawing.Color.White;
            this.groupBoxCategory.Location = new System.Drawing.Point(26, 20);
            this.groupBoxCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCategory.Size = new System.Drawing.Size(238, 291);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Categories";
            // 
            // checkBoxSprint
            // 
            this.checkBoxSprint.AutoSize = true;
            this.checkBoxSprint.Cursor = System.Windows.Forms.Cursors.No;
            this.checkBoxSprint.Location = new System.Drawing.Point(44, 232);
            this.checkBoxSprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSprint.Name = "checkBoxSprint";
            this.checkBoxSprint.Size = new System.Drawing.Size(127, 47);
            this.checkBoxSprint.TabIndex = 9;
            this.checkBoxSprint.Text = "Sprint";
            this.checkBoxSprint.UseVisualStyleBackColor = true;
            // 
            // checkBoxPace
            // 
            this.checkBoxPace.AutoSize = true;
            this.checkBoxPace.Cursor = System.Windows.Forms.Cursors.No;
            this.checkBoxPace.Location = new System.Drawing.Point(44, 187);
            this.checkBoxPace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPace.Name = "checkBoxPace";
            this.checkBoxPace.Size = new System.Drawing.Size(106, 47);
            this.checkBoxPace.TabIndex = 8;
            this.checkBoxPace.Text = "Pace";
            this.checkBoxPace.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreestyle
            // 
            this.checkBoxFreestyle.AutoSize = true;
            this.checkBoxFreestyle.Cursor = System.Windows.Forms.Cursors.No;
            this.checkBoxFreestyle.Location = new System.Drawing.Point(44, 142);
            this.checkBoxFreestyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxFreestyle.Name = "checkBoxFreestyle";
            this.checkBoxFreestyle.Size = new System.Drawing.Size(155, 47);
            this.checkBoxFreestyle.TabIndex = 7;
            this.checkBoxFreestyle.Text = "Freestyle";
            this.checkBoxFreestyle.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedley
            // 
            this.checkBoxMedley.AutoSize = true;
            this.checkBoxMedley.Cursor = System.Windows.Forms.Cursors.No;
            this.checkBoxMedley.Location = new System.Drawing.Point(44, 97);
            this.checkBoxMedley.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMedley.Name = "checkBoxMedley";
            this.checkBoxMedley.Size = new System.Drawing.Size(135, 47);
            this.checkBoxMedley.TabIndex = 6;
            this.checkBoxMedley.Text = "Medley";
            this.checkBoxMedley.UseVisualStyleBackColor = true;
            // 
            // checkBoxStroke
            // 
            this.checkBoxStroke.AutoSize = true;
            this.checkBoxStroke.Cursor = System.Windows.Forms.Cursors.No;
            this.checkBoxStroke.Location = new System.Drawing.Point(44, 49);
            this.checkBoxStroke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxStroke.Name = "checkBoxStroke";
            this.checkBoxStroke.Size = new System.Drawing.Size(129, 47);
            this.checkBoxStroke.TabIndex = 5;
            this.checkBoxStroke.Text = "Stroke";
            this.checkBoxStroke.UseVisualStyleBackColor = true;
            // 
            // panelDifficulty
            // 
            this.panelDifficulty.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelDifficulty.Controls.Add(this.groupBoxDifficulty);
            this.panelDifficulty.Location = new System.Drawing.Point(489, 136);
            this.panelDifficulty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDifficulty.Name = "panelDifficulty";
            this.panelDifficulty.Size = new System.Drawing.Size(290, 330);
            this.panelDifficulty.TabIndex = 3;
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.radioButtonSenior);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonGold);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonSilver);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonBronze);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonGarnet);
            this.groupBoxDifficulty.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDifficulty.ForeColor = System.Drawing.Color.White;
            this.groupBoxDifficulty.Location = new System.Drawing.Point(18, 26);
            this.groupBoxDifficulty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDifficulty.Size = new System.Drawing.Size(252, 279);
            this.groupBoxDifficulty.TabIndex = 0;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "Difficulty";
            // 
            // radioButtonSenior
            // 
            this.radioButtonSenior.AutoSize = true;
            this.radioButtonSenior.Location = new System.Drawing.Point(60, 227);
            this.radioButtonSenior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSenior.Name = "radioButtonSenior";
            this.radioButtonSenior.Size = new System.Drawing.Size(126, 47);
            this.radioButtonSenior.TabIndex = 4;
            this.radioButtonSenior.TabStop = true;
            this.radioButtonSenior.Text = "Senior";
            this.radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // radioButtonGold
            // 
            this.radioButtonGold.AutoSize = true;
            this.radioButtonGold.Location = new System.Drawing.Point(60, 182);
            this.radioButtonGold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.Size = new System.Drawing.Size(106, 47);
            this.radioButtonGold.TabIndex = 3;
            this.radioButtonGold.TabStop = true;
            this.radioButtonGold.Text = "Gold";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            this.radioButtonSilver.AutoSize = true;
            this.radioButtonSilver.Location = new System.Drawing.Point(61, 137);
            this.radioButtonSilver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.Size = new System.Drawing.Size(116, 47);
            this.radioButtonSilver.TabIndex = 2;
            this.radioButtonSilver.TabStop = true;
            this.radioButtonSilver.Text = "Silver";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonBronze
            // 
            this.radioButtonBronze.AutoSize = true;
            this.radioButtonBronze.Location = new System.Drawing.Point(61, 92);
            this.radioButtonBronze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonBronze.Name = "radioButtonBronze";
            this.radioButtonBronze.Size = new System.Drawing.Size(134, 47);
            this.radioButtonBronze.TabIndex = 1;
            this.radioButtonBronze.TabStop = true;
            this.radioButtonBronze.Text = "Bronze";
            this.radioButtonBronze.UseVisualStyleBackColor = true;
            // 
            // radioButtonGarnet
            // 
            this.radioButtonGarnet.AutoSize = true;
            this.radioButtonGarnet.Location = new System.Drawing.Point(61, 47);
            this.radioButtonGarnet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonGarnet.Name = "radioButtonGarnet";
            this.radioButtonGarnet.Size = new System.Drawing.Size(134, 47);
            this.radioButtonGarnet.TabIndex = 0;
            this.radioButtonGarnet.TabStop = true;
            this.radioButtonGarnet.Text = "Garnet";
            this.radioButtonGarnet.UseVisualStyleBackColor = true;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTime.Controls.Add(this.groupBox1);
            this.panelTime.Location = new System.Drawing.Point(489, 497);
            this.panelTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(360, 155);
            this.panelTime.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(318, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(235, 73);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "00";
            this.textBox4.Size = new System.Drawing.Size(65, 50);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 73);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "00";
            this.textBox3.Size = new System.Drawing.Size(65, 50);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "00";
            this.textBox2.Size = new System.Drawing.Size(65, 50);
            this.textBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(225, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(116, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hours";
            // 
            // panelDistance
            // 
            this.panelDistance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelDistance.Controls.Add(this.label4);
            this.panelDistance.Controls.Add(this.textBox1);
            this.panelDistance.Controls.Add(this.groupBoxDistance);
            this.panelDistance.Location = new System.Drawing.Point(100, 497);
            this.panelDistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDistance.Name = "panelDistance";
            this.panelDistance.Size = new System.Drawing.Size(360, 155);
            this.panelDistance.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(49, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter in 25 yard increments";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(56, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "75";
            this.textBox1.Size = new System.Drawing.Size(183, 50);
            this.textBox1.TabIndex = 0;
            // 
            // groupBoxDistance
            // 
            this.groupBoxDistance.Controls.Add(this.label3);
            this.groupBoxDistance.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDistance.ForeColor = System.Drawing.Color.White;
            this.groupBoxDistance.Location = new System.Drawing.Point(21, 9);
            this.groupBoxDistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDistance.Name = "groupBoxDistance";
            this.groupBoxDistance.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDistance.Size = new System.Drawing.Size(318, 136);
            this.groupBoxDistance.TabIndex = 4;
            this.groupBoxDistance.TabStop = false;
            this.groupBoxDistance.Text = "Distance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(231, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "yds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 704);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(505, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "This is where we will have the workout appear";
            // 
            // UC_Swim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelDistance);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelDifficulty);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Swim";
            this.Size = new System.Drawing.Size(950, 819);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.panelDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDistance.ResumeLayout(false);
            this.panelDistance.PerformLayout();
            this.groupBoxDistance.ResumeLayout(false);
            this.groupBoxDistance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
