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
            panel1.BackColor = Color.MidnightBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 74);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(435, 24);
            label8.Name = "label8";
            label8.Size = new Size(120, 25);
            label8.TabIndex = 8;
            label8.Text = "Today's Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.MenuBar;
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(562, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 13);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 0;
            label1.Text = "Swim";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(255, 538);
            button1.Name = "button1";
            button1.Size = new Size(221, 53);
            button1.TabIndex = 1;
            button1.Text = "Generate Practice Swim";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelCategory
            // 
            panelCategory.BackColor = Color.MidnightBlue;
            panelCategory.Controls.Add(groupBoxCategory);
            panelCategory.Location = new Point(131, 107);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(223, 258);
            panelCategory.TabIndex = 2;
            // 
            // groupBoxCategory
            // 
            groupBoxCategory.BackColor = Color.Transparent;
            groupBoxCategory.Controls.Add(checkBoxSprint);
            groupBoxCategory.Controls.Add(checkBoxPace);
            groupBoxCategory.Controls.Add(checkBoxFreestyle);
            groupBoxCategory.Controls.Add(checkBoxMedley);
            groupBoxCategory.Controls.Add(checkBoxStroke);
            groupBoxCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxCategory.ForeColor = Color.WhiteSmoke;
            groupBoxCategory.Location = new Point(20, 17);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Size = new Size(183, 227);
            groupBoxCategory.TabIndex = 0;
            groupBoxCategory.TabStop = false;
            groupBoxCategory.Text = "Categories";
            // 
            // checkBoxSprint
            // 
            checkBoxSprint.AutoSize = true;
            checkBoxSprint.Location = new Point(34, 182);
            checkBoxSprint.Name = "checkBoxSprint";
            checkBoxSprint.Size = new Size(89, 29);
            checkBoxSprint.TabIndex = 9;
            checkBoxSprint.Text = "Sprint";
            checkBoxSprint.UseVisualStyleBackColor = true;
            // 
            // checkBoxPace
            // 
            checkBoxPace.AutoSize = true;
            checkBoxPace.Location = new Point(34, 147);
            checkBoxPace.Name = "checkBoxPace";
            checkBoxPace.Size = new Size(75, 29);
            checkBoxPace.TabIndex = 8;
            checkBoxPace.Text = "Pace";
            checkBoxPace.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreestyle
            // 
            checkBoxFreestyle.AutoSize = true;
            checkBoxFreestyle.Location = new Point(34, 112);
            checkBoxFreestyle.Name = "checkBoxFreestyle";
            checkBoxFreestyle.Size = new Size(113, 29);
            checkBoxFreestyle.TabIndex = 7;
            checkBoxFreestyle.Text = "Freestyle";
            checkBoxFreestyle.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedley
            // 
            checkBoxMedley.AutoSize = true;
            checkBoxMedley.Location = new Point(34, 77);
            checkBoxMedley.Name = "checkBoxMedley";
            checkBoxMedley.Size = new Size(100, 29);
            checkBoxMedley.TabIndex = 6;
            checkBoxMedley.Text = "Medley";
            checkBoxMedley.UseVisualStyleBackColor = true;
            // 
            // checkBoxStroke
            // 
            checkBoxStroke.AutoSize = true;
            checkBoxStroke.Location = new Point(34, 38);
            checkBoxStroke.Name = "checkBoxStroke";
            checkBoxStroke.Size = new Size(91, 29);
            checkBoxStroke.TabIndex = 5;
            checkBoxStroke.Text = "Stroke";
            checkBoxStroke.UseVisualStyleBackColor = true;
            // 
            // panelDifficulty
            // 
            panelDifficulty.BackColor = Color.MidnightBlue;
            panelDifficulty.Controls.Add(groupBoxDifficulty);
            panelDifficulty.Location = new Point(376, 107);
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
            groupBoxDifficulty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDifficulty.ForeColor = Color.WhiteSmoke;
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
            radioButtonSenior.Size = new Size(91, 29);
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
            radioButtonGold.Size = new Size(77, 29);
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
            radioButtonSilver.Size = new Size(83, 29);
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
            radioButtonBronze.Size = new Size(95, 29);
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
            radioButtonGarnet.Size = new Size(94, 29);
            radioButtonGarnet.TabIndex = 0;
            radioButtonGarnet.TabStop = true;
            radioButtonGarnet.Text = "Garnet";
            radioButtonGarnet.UseVisualStyleBackColor = true;
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.MidnightBlue;
            panelTime.Controls.Add(groupBox1);
            panelTime.Location = new Point(376, 388);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(277, 122);
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
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(14, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 57);
            textBox4.MaxLength = 2;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(51, 31);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 57);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 57);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(51, 31);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(173, 37);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 2;
            label6.Text = "Seconds";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(89, 37);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 1;
            label5.Text = "Minutes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 37);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 0;
            label2.Text = "Hours";
            // 
            // panelDistance
            // 
            panelDistance.BackColor = Color.MidnightBlue;
            panelDistance.Controls.Add(label4);
            panelDistance.Controls.Add(textBox1);
            panelDistance.Controls.Add(groupBoxDistance);
            panelDistance.Location = new Point(77, 388);
            panelDistance.Name = "panelDistance";
            panelDistance.Size = new Size(277, 122);
            panelDistance.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 43);
            label4.Name = "label4";
            label4.Size = new Size(201, 21);
            label4.TabIndex = 3;
            label4.Text = "Enter in 25 yard increments";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(43, 65);
            textBox1.MaxLength = 6;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1000";
            textBox1.Size = new Size(143, 39);
            textBox1.TabIndex = 0;
            // 
            // groupBoxDistance
            // 
            groupBoxDistance.Controls.Add(label3);
            groupBoxDistance.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDistance.ForeColor = Color.WhiteSmoke;
            groupBoxDistance.Location = new Point(16, 7);
            groupBoxDistance.Name = "groupBoxDistance";
            groupBoxDistance.Size = new Size(246, 107);
            groupBoxDistance.TabIndex = 4;
            groupBoxDistance.TabStop = false;
            groupBoxDistance.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(179, 62);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 2;
            label3.Text = "yds";
            // 
            // UC_Swim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panelDistance);
            Controls.Add(panelTime);
            Controls.Add(panelDifficulty);
            Controls.Add(button1);
            Controls.Add(panelCategory);
            Controls.Add(panel1);
            Name = "UC_Swim";
            Size = new Size(797, 654);
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
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private CheckBox checkBoxSprint;
        private CheckBox checkBoxPace;
        private CheckBox checkBoxFreestyle;
        private CheckBox checkBoxMedley;
        private CheckBox checkBoxStroke;
    }
}
