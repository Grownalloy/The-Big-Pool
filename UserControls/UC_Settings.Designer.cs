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
            button1 = new Button();
            label9 = new Label();
            panel1 = new Panel();
            labelSwimmerProfileCard = new Label();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
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
            panelSide.Controls.Add(button1);
            panelSide.Controls.Add(label9);
            panelSide.Dock = DockStyle.Fill;
            panelSide.Location = new Point(573, 3);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(221, 586);
            panelSide.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(27, 20);
            button1.Name = "button1";
            button1.Size = new Size(163, 37);
            button1.TabIndex = 0;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 75);
            label9.Name = "label9";
            label9.Size = new Size(221, 297);
            label9.TabIndex = 0;
            label9.Text = resources.GetString("label9.Text");
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(labelSwimmerProfileCard);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(profilePicture);
            panel1.Location = new Point(0, 65);
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
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(175, 513);
            button2.Name = "button2";
            button2.Size = new Size(216, 37);
            button2.TabIndex = 1;
            button2.Text = "Upload Profile Picture";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(291, 470);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 7;
            label8.Text = "Distance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(291, 440);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 6;
            label7.Text = "Skill Level";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = Color.Transparent;
            categoryLabel.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.White;
            categoryLabel.Location = new Point(291, 410);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(82, 25);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(197, 470);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 4;
            label5.Text = "Distance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(189, 440);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Skill Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(192, 410);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(237, 375);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.White;
            profilePicture.Image = (Image)resources.GetObject("profilePicture.Image");
            profilePicture.InitialImage = (Image)resources.GetObject("profilePicture.InitialImage");
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
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label categoryLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelSwimmerProfileCard;
        private Label label9;
    }
}
