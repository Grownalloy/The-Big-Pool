namespace The_Big_Pool.UserControls
{
    partial class UC_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Settings));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSide = new Panel();
            label14 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label12 = new Label();
            textBox3 = new TextBox();
            label13 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            labelSwimmerProfileCard = new Label();
            distanceLabel = new Label();
            skillLabel = new Label();
            categoryLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            profilePicture = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelSide.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 227F));
            tableLayoutPanel1.Controls.Add(panelSide, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(797, 592);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.BackgroundImage = (Image)resources.GetObject("panelSide.BackgroundImage");
            panelSide.Controls.Add(label14);
            panelSide.Controls.Add(textBox1);
            panelSide.Controls.Add(comboBox2);
            panelSide.Controls.Add(comboBox1);
            panelSide.Controls.Add(label6);
            panelSide.Controls.Add(label9);
            panelSide.Controls.Add(label10);
            panelSide.Controls.Add(textBox6);
            panelSide.Controls.Add(label11);
            panelSide.Controls.Add(textBox4);
            panelSide.Controls.Add(label12);
            panelSide.Controls.Add(textBox3);
            panelSide.Controls.Add(label13);
            panelSide.Controls.Add(button1);
            panelSide.Dock = DockStyle.Fill;
            panelSide.Location = new Point(573, 3);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(221, 586);
            panelSide.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(27, 34);
            label14.Name = "label14";
            label14.Size = new Size(167, 21);
            label14.TabIndex = 33;
            label14.Text = "Edit Account Settings";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 424);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "100 yds";
            textBox1.Size = new Size(190, 31);
            textBox1.TabIndex = 32;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Garnet", "Bronze", "Silver", "Gold", "Senior" });
            comboBox2.Location = new Point(15, 357);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 33);
            comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Stroke", "Medley", "Freestyle", "Pace", "Sprint" });
            comboBox1.Location = new Point(15, 291);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 33);
            comboBox1.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(15, 396);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 29;
            label6.Text = "Distance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(15, 331);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 28;
            label9.Text = "Skill Level";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(15, 266);
            label10.Name = "label10";
            label10.Size = new Size(74, 21);
            label10.TabIndex = 27;
            label10.Text = "Category";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 226);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Confirm Password";
            textBox6.Size = new Size(190, 31);
            textBox6.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(15, 201);
            label11.Name = "label11";
            label11.Size = new Size(137, 21);
            label11.TabIndex = 25;
            label11.Text = "Confirm Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 161);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Password";
            textBox4.Size = new Size(190, 31);
            textBox4.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(15, 136);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 23;
            label12.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 96);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Username";
            textBox3.Size = new Size(190, 31);
            textBox3.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(15, 71);
            label13.Name = "label13";
            label13.Size = new Size(81, 21);
            label13.TabIndex = 21;
            label13.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(42, 530);
            button1.Name = "button1";
            button1.Size = new Size(138, 41);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(labelSwimmerProfileCard);
            panel1.Controls.Add(distanceLabel);
            panel1.Controls.Add(skillLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(profilePicture);
            panel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 586);
            panel1.TabIndex = 0;
            // 
            // labelSwimmerProfileCard
            // 
            labelSwimmerProfileCard.AutoSize = true;
            labelSwimmerProfileCard.BackColor = Color.Transparent;
            labelSwimmerProfileCard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSwimmerProfileCard.ForeColor = Color.White;
            labelSwimmerProfileCard.Location = new Point(151, 25);
            labelSwimmerProfileCard.Name = "labelSwimmerProfileCard";
            labelSwimmerProfileCard.Size = new Size(263, 32);
            labelSwimmerProfileCard.TabIndex = 8;
            labelSwimmerProfileCard.Text = "Swimmer Profile Card";
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.BackColor = Color.Transparent;
            distanceLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distanceLabel.ForeColor = Color.White;
            distanceLabel.Location = new Point(300, 510);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(88, 25);
            distanceLabel.TabIndex = 7;
            distanceLabel.Text = "Distance";
            // 
            // skillLabel
            // 
            skillLabel.AutoSize = true;
            skillLabel.BackColor = Color.Transparent;
            skillLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            skillLabel.ForeColor = Color.White;
            skillLabel.Location = new Point(300, 464);
            skillLabel.Name = "skillLabel";
            skillLabel.Size = new Size(100, 25);
            skillLabel.TabIndex = 6;
            skillLabel.Text = "Skill Level";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = Color.Transparent;
            categoryLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.White;
            categoryLabel.Location = new Point(300, 418);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(92, 25);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(190, 507);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 4;
            label5.Text = "Distance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(182, 461);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 3;
            label4.Text = "Skill Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(185, 415);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(221, 375);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.White;
            profilePicture.BackgroundImage = (Image)resources.GetObject("profilePicture.BackgroundImage");
            profilePicture.BackgroundImageLayout = ImageLayout.Zoom;
            profilePicture.InitialImage = null;
            profilePicture.Location = new Point(130, 75);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(304, 292);
            profilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 73);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 14);
            label2.Name = "label2";
            label2.Size = new Size(146, 45);
            label2.TabIndex = 0;
            label2.Text = "Settings";
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Settings";
            Size = new Size(797, 654);
            tableLayoutPanel1.ResumeLayout(false);
            panelSide.ResumeLayout(false);
            panelSide.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private PictureBox profilePicture;
        private Panel panelSide;
        private Panel panel2;
        private Label label2;
        private Label distanceLabel;
        private Label skillLabel;
        private Label categoryLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelSwimmerProfileCard;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox3;
        private Label label13;
        private Label label14;
    }
}
