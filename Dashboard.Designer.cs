namespace The_Big_Pool
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelSide = new Panel();
            buttonSettings = new Button();
            panel2 = new Panel();
            labelUsername = new Label();
            pictureBox1 = new PictureBox();
            buttonHome = new Button();
            buttonHistory = new Button();
            buttonSwim = new Button();
            panelDashboard = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panelSide.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BorderStyle = BorderStyle.FixedSingle;
            panelSide.Controls.Add(buttonSettings);
            panelSide.Controls.Add(panel2);
            panelSide.Controls.Add(buttonHome);
            panelSide.Controls.Add(buttonHistory);
            panelSide.Controls.Add(buttonSwim);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(203, 690);
            panelSide.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.White;
            buttonSettings.BackgroundImage = (Image)resources.GetObject("buttonSettings.BackgroundImage");
            buttonSettings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSettings.FlatStyle = FlatStyle.Popup;
            buttonSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.DeepSkyBlue;
            buttonSettings.Location = new Point(3, 630);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(195, 55);
            buttonSettings.TabIndex = 3;
            buttonSettings.TextAlign = ContentAlignment.TopLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 166);
            panel2.TabIndex = 4;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.ForeColor = Color.Black;
            labelUsername.Location = new Point(53, 113);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            labelUsername.Click += labelUsername_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.White;
            buttonHome.BackgroundImage = (Image)resources.GetObject("buttonHome.BackgroundImage");
            buttonHome.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.DeepSkyBlue;
            buttonHome.Location = new Point(3, 206);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(195, 55);
            buttonHome.TabIndex = 0;
            buttonHome.TextAlign = ContentAlignment.TopLeft;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.White;
            buttonHistory.BackgroundImage = (Image)resources.GetObject("buttonHistory.BackgroundImage");
            buttonHistory.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHistory.FlatStyle = FlatStyle.Popup;
            buttonHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHistory.ForeColor = Color.DeepSkyBlue;
            buttonHistory.Location = new Point(3, 328);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(195, 55);
            buttonHistory.TabIndex = 2;
            buttonHistory.TextAlign = ContentAlignment.TopLeft;
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonSwim
            // 
            buttonSwim.BackColor = Color.White;
            buttonSwim.BackgroundImage = (Image)resources.GetObject("buttonSwim.BackgroundImage");
            buttonSwim.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSwim.FlatStyle = FlatStyle.Popup;
            buttonSwim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSwim.ForeColor = Color.DeepSkyBlue;
            buttonSwim.Location = new Point(3, 267);
            buttonSwim.Name = "buttonSwim";
            buttonSwim.Size = new Size(195, 55);
            buttonSwim.TabIndex = 1;
            buttonSwim.TextAlign = ContentAlignment.TopLeft;
            buttonSwim.UseVisualStyleBackColor = false;
            buttonSwim.Click += buttonSwim_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.BackgroundImage = (Image)resources.GetObject("panelDashboard.BackgroundImage");
            panelDashboard.BorderStyle = BorderStyle.FixedSingle;
            panelDashboard.Controls.Add(pictureBox2);
            panelDashboard.Dock = DockStyle.Bottom;
            panelDashboard.Location = new Point(203, 34);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(799, 656);
            panelDashboard.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(797, 654);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 34);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "The Big Pool";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(939, 0);
            button1.Name = "button1";
            button1.Size = new Size(63, 34);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1002, 690);
            Controls.Add(panel1);
            Controls.Add(panelDashboard);
            Controls.Add(panelSide);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panelSide.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSide;
        private Button buttonHome;
        private Button buttonSwim;
        private Button buttonHistory;
        private Button buttonSettings;
        private Panel panel2;
        private Label labelUsername;
        private PictureBox pictureBox1;
        private Panel panelDashboard;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button button1;
        private Label label1;
    }
}