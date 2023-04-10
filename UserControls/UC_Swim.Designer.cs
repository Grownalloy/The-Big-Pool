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
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 45);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 13);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 8;
            label8.Text = "Today's Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.MenuBar;
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(214, 11);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 30);
            label1.TabIndex = 0;
            label1.Text = "Swim";
            // 
            // button1
            // 
            button1.Location = new Point(340, 5);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(155, 32);
            button1.TabIndex = 1;
            button1.Text = "Generate Practice Swim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelCategory
            // 
            panelCategory.BackColor = Color.DeepSkyBlue;
            panelCategory.Controls.Add(groupBoxCategory);
            panelCategory.Location = new Point(92, 64);
            panelCategory.Margin = new Padding(2, 2, 2, 2);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(156, 155);
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
            groupBoxCategory.Location = new Point(14, 10);
            groupBoxCategory.Margin = new Padding(2, 2, 2, 2);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Padding = new Padding(2, 2, 2, 2);
            groupBoxCategory.Size = new Size(128, 136);
            groupBoxCategory.TabIndex = 0;
            groupBoxCategory.TabStop = false;
            groupBoxCategory.Text = "Categories";
            // 
            // checkBoxSprint
            // 
            checkBoxSprint.AutoSize = true;
            checkBoxSprint.Location = new Point(24, 109);
            checkBoxSprint.Margin = new Padding(2, 2, 2, 2);
            checkBoxSprint.Name = "checkBoxSprint";
            checkBoxSprint.Size = new Size(68, 25);
            checkBoxSprint.TabIndex = 9;
            checkBoxSprint.Text = "Sprint";
            checkBoxSprint.UseVisualStyleBackColor = true;
            // 
            // checkBoxPace
            // 
            checkBoxPace.AutoSize = true;
            checkBoxPace.Location = new Point(24, 88);
            checkBoxPace.Margin = new Padding(2, 2, 2, 2);
            checkBoxPace.Name = "checkBoxPace";
            checkBoxPace.Size = new Size(56, 25);
            checkBoxPace.TabIndex = 8;
            checkBoxPace.Text = "Pace";
            checkBoxPace.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreestyle
            // 
            checkBoxFreestyle.AutoSize = true;
            checkBoxFreestyle.Location = new Point(24, 67);
            checkBoxFreestyle.Margin = new Padding(2, 2, 2, 2);
            checkBoxFreestyle.Name = "checkBoxFreestyle";
            checkBoxFreestyle.Size = new Size(81, 25);
            checkBoxFreestyle.TabIndex = 7;
            checkBoxFreestyle.Text = "Freestyle";
            checkBoxFreestyle.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedley
            // 
            checkBoxMedley.AutoSize = true;
            checkBoxMedley.Location = new Point(24, 46);
            checkBoxMedley.Margin = new Padding(2, 2, 2, 2);
            checkBoxMedley.Name = "checkBoxMedley";
            checkBoxMedley.Size = new Size(70, 25);
            checkBoxMedley.TabIndex = 6;
            checkBoxMedley.Text = "Medley";
            checkBoxMedley.UseVisualStyleBackColor = true;
            // 
            // checkBoxStroke
            // 
            checkBoxStroke.AutoSize = true;
            checkBoxStroke.Location = new Point(24, 23);
            checkBoxStroke.Margin = new Padding(2, 2, 2, 2);
            checkBoxStroke.Name = "checkBoxStroke";
            checkBoxStroke.Size = new Size(69, 25);
            checkBoxStroke.TabIndex = 5;
            checkBoxStroke.Text = "Stroke";
            checkBoxStroke.UseVisualStyleBackColor = true;
            // 
            // panelDifficulty
            // 
            panelDifficulty.BackColor = Color.DeepSkyBlue;
            panelDifficulty.Controls.Add(groupBoxDifficulty);
            panelDifficulty.Location = new Point(263, 64);
            panelDifficulty.Margin = new Padding(2, 2, 2, 2);
            panelDifficulty.Name = "panelDifficulty";
            panelDifficulty.Size = new Size(156, 155);
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
            groupBoxDifficulty.Location = new Point(10, 12);
            groupBoxDifficulty.Margin = new Padding(2, 2, 2, 2);
            groupBoxDifficulty.Name = "groupBoxDifficulty";
            groupBoxDifficulty.Padding = new Padding(2, 2, 2, 2);
            groupBoxDifficulty.Size = new Size(136, 131);
            groupBoxDifficulty.TabIndex = 0;
            groupBoxDifficulty.TabStop = false;
            groupBoxDifficulty.Text = "Difficulty";
            // 
            // radioButtonSenior
            // 
            radioButtonSenior.AutoSize = true;
            radioButtonSenior.Location = new Point(32, 106);
            radioButtonSenior.Margin = new Padding(2, 2, 2, 2);
            radioButtonSenior.Name = "radioButtonSenior";
            radioButtonSenior.Size = new Size(66, 25);
            radioButtonSenior.TabIndex = 4;
            radioButtonSenior.TabStop = true;
            radioButtonSenior.Text = "Senior";
            radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // radioButtonGold
            // 
            radioButtonGold.AutoSize = true;
            radioButtonGold.Location = new Point(32, 85);
            radioButtonGold.Margin = new Padding(2, 2, 2, 2);
            radioButtonGold.Name = "radioButtonGold";
            radioButtonGold.Size = new Size(55, 25);
            radioButtonGold.TabIndex = 3;
            radioButtonGold.TabStop = true;
            radioButtonGold.Text = "Gold";
            radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            radioButtonSilver.AutoSize = true;
            radioButtonSilver.Location = new Point(33, 64);
            radioButtonSilver.Margin = new Padding(2, 2, 2, 2);
            radioButtonSilver.Name = "radioButtonSilver";
            radioButtonSilver.Size = new Size(61, 25);
            radioButtonSilver.TabIndex = 2;
            radioButtonSilver.TabStop = true;
            radioButtonSilver.Text = "Silver";
            radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonBronze
            // 
            radioButtonBronze.AutoSize = true;
            radioButtonBronze.Location = new Point(33, 43);
            radioButtonBronze.Margin = new Padding(2, 2, 2, 2);
            radioButtonBronze.Name = "radioButtonBronze";
            radioButtonBronze.Size = new Size(70, 25);
            radioButtonBronze.TabIndex = 1;
            radioButtonBronze.TabStop = true;
            radioButtonBronze.Text = "Bronze";
            radioButtonBronze.UseVisualStyleBackColor = true;
            // 
            // radioButtonGarnet
            // 
            radioButtonGarnet.AutoSize = true;
            radioButtonGarnet.Location = new Point(33, 22);
            radioButtonGarnet.Margin = new Padding(2, 2, 2, 2);
            radioButtonGarnet.Name = "radioButtonGarnet";
            radioButtonGarnet.Size = new Size(70, 25);
            radioButtonGarnet.TabIndex = 0;
            radioButtonGarnet.TabStop = true;
            radioButtonGarnet.Text = "Garnet";
            radioButtonGarnet.UseVisualStyleBackColor = true;
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.DeepSkyBlue;
            panelTime.Controls.Add(groupBox1);
            panelTime.Location = new Point(263, 233);
            panelTime.Margin = new Padding(2, 2, 2, 2);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(194, 73);
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
            groupBox1.Location = new Point(10, 4);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(172, 64);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 34);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.MaxLength = 2;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(37, 29);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(67, 34);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(37, 29);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 34);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 29);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(121, 22);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 13);
            label6.TabIndex = 2;
            label6.Text = "Seconds";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(62, 22);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 13);
            label5.TabIndex = 1;
            label5.Text = "Minutes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(13, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 0;
            label2.Text = "Hours";
            // 
            // panelDistance
            // 
            panelDistance.BackColor = Color.DeepSkyBlue;
            panelDistance.Controls.Add(label4);
            panelDistance.Controls.Add(textBox1);
            panelDistance.Controls.Add(groupBoxDistance);
            panelDistance.Location = new Point(54, 233);
            panelDistance.Margin = new Padding(2, 2, 2, 2);
            panelDistance.Name = "panelDistance";
            panelDistance.Size = new Size(194, 73);
            panelDistance.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(27, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 13);
            label4.TabIndex = 3;
            label4.Text = "Enter in 25 yard increments";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(30, 39);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.MaxLength = 6;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1000";
            textBox1.Size = new Size(101, 29);
            textBox1.TabIndex = 0;
            // 
            // groupBoxDistance
            // 
            groupBoxDistance.Controls.Add(label3);
            groupBoxDistance.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxDistance.ForeColor = Color.White;
            groupBoxDistance.Location = new Point(11, 4);
            groupBoxDistance.Margin = new Padding(2, 2, 2, 2);
            groupBoxDistance.Name = "groupBoxDistance";
            groupBoxDistance.Padding = new Padding(2, 2, 2, 2);
            groupBoxDistance.Size = new Size(172, 64);
            groupBoxDistance.TabIndex = 4;
            groupBoxDistance.TabStop = false;
            groupBoxDistance.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(125, 34);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 21);
            label3.TabIndex = 2;
            label3.Text = "yds";
            // 
            // UC_Swim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panelDistance);
            Controls.Add(panelTime);
            Controls.Add(panelDifficulty);
            Controls.Add(panelCategory);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UC_Swim";
            Size = new Size(512, 384);
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
