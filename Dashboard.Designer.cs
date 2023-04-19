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
            ExitButton = new Button();
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
            panelSide.BackColor = Color.Gainsboro;
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
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsername.ForeColor = Color.MidnightBlue;
            labelUsername.Location = new Point(5, 106);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(184, 32);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Controls.Add(ExitButton);
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
            // ExitButton
            // 
            ExitButton.BackColor = Color.DeepSkyBlue;
            ExitButton.Dock = DockStyle.Right;
            ExitButton.FlatStyle = FlatStyle.System;
            ExitButton.ForeColor = Color.MidnightBlue;
            ExitButton.Location = new Point(939, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(63, 34);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
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
        private Button ExitButton;
        private Label label1;
    }
}