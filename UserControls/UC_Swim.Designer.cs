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
            label1 = new Label();
            button1 = new Button();
            panelCategory = new Panel();
            panelDifficulty = new Panel();
            panelTime = new Panel();
            panelDistance = new Panel();
            groupBoxCategory = new GroupBox();
            radioButtonStroke = new RadioButton();
            radioButtonMedley = new RadioButton();
            radioButtonFreestyle = new RadioButton();
            radioButtonPace = new RadioButton();
            radioButtonSprint = new RadioButton();
            groupBoxDifficulty = new GroupBox();
            radioButtonGarnet = new RadioButton();
            radioButtonBronze = new RadioButton();
            radioButtonSilver = new RadioButton();
            radioButtonGold = new RadioButton();
            radioButtonSenior = new RadioButton();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBoxDistance = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            panelCategory.SuspendLayout();
            panelDifficulty.SuspendLayout();
            panelTime.SuspendLayout();
            panelDistance.SuspendLayout();
            groupBoxCategory.SuspendLayout();
            groupBoxDifficulty.SuspendLayout();
            groupBoxDistance.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 73);
            panel1.TabIndex = 0;
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
            button1.Location = new Point(15, 573);
            button1.Name = "button1";
            button1.Size = new Size(221, 53);
            button1.TabIndex = 1;
            button1.Text = "Generate Practice Swim";
            button1.UseVisualStyleBackColor = true;
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
            // panelDifficulty
            // 
            panelDifficulty.BackColor = Color.DeepSkyBlue;
            panelDifficulty.Controls.Add(groupBoxDifficulty);
            panelDifficulty.Location = new Point(376, 106);
            panelDifficulty.Name = "panelDifficulty";
            panelDifficulty.Size = new Size(223, 258);
            panelDifficulty.TabIndex = 3;
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
            // groupBoxCategory
            // 
            groupBoxCategory.Controls.Add(radioButtonSprint);
            groupBoxCategory.Controls.Add(radioButtonPace);
            groupBoxCategory.Controls.Add(radioButtonFreestyle);
            groupBoxCategory.Controls.Add(radioButtonMedley);
            groupBoxCategory.Controls.Add(radioButtonStroke);
            groupBoxCategory.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxCategory.ForeColor = Color.White;
            groupBoxCategory.Location = new Point(20, 16);
            groupBoxCategory.Name = "groupBoxCategory";
            groupBoxCategory.Size = new Size(183, 227);
            groupBoxCategory.TabIndex = 0;
            groupBoxCategory.TabStop = false;
            groupBoxCategory.Text = "Category";
            // 
            // radioButtonStroke
            // 
            radioButtonStroke.AutoSize = true;
            radioButtonStroke.Location = new Point(38, 33);
            radioButtonStroke.Name = "radioButtonStroke";
            radioButtonStroke.Size = new Size(97, 35);
            radioButtonStroke.TabIndex = 0;
            radioButtonStroke.TabStop = true;
            radioButtonStroke.Text = "Stroke";
            radioButtonStroke.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedley
            // 
            radioButtonMedley.AutoSize = true;
            radioButtonMedley.Location = new Point(38, 68);
            radioButtonMedley.Name = "radioButtonMedley";
            radioButtonMedley.Size = new Size(102, 35);
            radioButtonMedley.TabIndex = 1;
            radioButtonMedley.TabStop = true;
            radioButtonMedley.Text = "Medley";
            radioButtonMedley.UseVisualStyleBackColor = true;
            // 
            // radioButtonFreestyle
            // 
            radioButtonFreestyle.AutoSize = true;
            radioButtonFreestyle.Location = new Point(38, 103);
            radioButtonFreestyle.Name = "radioButtonFreestyle";
            radioButtonFreestyle.Size = new Size(118, 35);
            radioButtonFreestyle.TabIndex = 2;
            radioButtonFreestyle.TabStop = true;
            radioButtonFreestyle.Text = "Freestyle";
            radioButtonFreestyle.UseVisualStyleBackColor = true;
            // 
            // radioButtonPace
            // 
            radioButtonPace.AutoSize = true;
            radioButtonPace.Location = new Point(38, 138);
            radioButtonPace.Name = "radioButtonPace";
            radioButtonPace.Size = new Size(81, 35);
            radioButtonPace.TabIndex = 3;
            radioButtonPace.TabStop = true;
            radioButtonPace.Text = "Pace";
            radioButtonPace.UseVisualStyleBackColor = true;
            // 
            // radioButtonSprint
            // 
            radioButtonSprint.AutoSize = true;
            radioButtonSprint.Location = new Point(38, 173);
            radioButtonSprint.Name = "radioButtonSprint";
            radioButtonSprint.Size = new Size(96, 35);
            radioButtonSprint.TabIndex = 4;
            radioButtonSprint.TabStop = true;
            radioButtonSprint.Text = "Sprint";
            radioButtonSprint.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(43, 65);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "75";
            textBox1.Size = new Size(142, 39);
            textBox1.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.Location = new Point(18, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "00";
            textBox2.Size = new Size(51, 39);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 57);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "00";
            textBox3.Size = new Size(51, 39);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 57);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "00";
            textBox4.Size = new Size(51, 39);
            textBox4.TabIndex = 5;
            // 
            // UC_Swim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panelDistance);
            Controls.Add(panelTime);
            Controls.Add(panelDifficulty);
            Controls.Add(panelCategory);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "UC_Swim";
            Size = new Size(731, 640);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCategory.ResumeLayout(false);
            panelDifficulty.ResumeLayout(false);
            panelTime.ResumeLayout(false);
            panelDistance.ResumeLayout(false);
            panelDistance.PerformLayout();
            groupBoxCategory.ResumeLayout(false);
            groupBoxCategory.PerformLayout();
            groupBoxDifficulty.ResumeLayout(false);
            groupBoxDifficulty.PerformLayout();
            groupBoxDistance.ResumeLayout(false);
            groupBoxDistance.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private RadioButton radioButtonSprint;
        private RadioButton radioButtonPace;
        private RadioButton radioButtonFreestyle;
        private RadioButton radioButtonMedley;
        private RadioButton radioButtonStroke;
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
    }
}
