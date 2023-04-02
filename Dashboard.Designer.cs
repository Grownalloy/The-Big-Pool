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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonHome = new Button();
            buttonSwim = new Button();
            buttonHistory = new Button();
            buttonSettings = new Button();
            panel2 = new Panel();
            labelUsername = new Label();
            pictureBox1 = new PictureBox();
            panelDashboard = new Panel();
            pictureBox2 = new PictureBox();
            panelSide.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BorderStyle = BorderStyle.FixedSingle;
            panelSide.Controls.Add(tableLayoutPanel1);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 0);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(203, 640);
            panelSide.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonHome, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonSwim, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonHistory, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonSettings, 0, 4);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel1.Size = new Size(201, 638);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.DeepSkyBlue;
            buttonHome.Dock = DockStyle.Fill;
            buttonHome.Location = new Point(3, 162);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(195, 113);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonSwim
            // 
            buttonSwim.BackColor = Color.DeepSkyBlue;
            buttonSwim.Dock = DockStyle.Fill;
            buttonSwim.Location = new Point(3, 281);
            buttonSwim.Name = "buttonSwim";
            buttonSwim.Size = new Size(195, 113);
            buttonSwim.TabIndex = 1;
            buttonSwim.Text = "Swim";
            buttonSwim.UseVisualStyleBackColor = false;
            buttonSwim.Click += buttonSwim_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.DeepSkyBlue;
            buttonHistory.Dock = DockStyle.Fill;
            buttonHistory.Location = new Point(3, 400);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(195, 113);
            buttonHistory.TabIndex = 2;
            buttonHistory.Text = "History";
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.DeepSkyBlue;
            buttonSettings.Dock = DockStyle.Fill;
            buttonSettings.Location = new Point(3, 519);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(195, 116);
            buttonSettings.TabIndex = 3;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 153);
            panel2.TabIndex = 4;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(53, 113);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDashboard
            // 
            panelDashboard.BackgroundImage = (Image)resources.GetObject("panelDashboard.BackgroundImage");
            panelDashboard.BorderStyle = BorderStyle.FixedSingle;
            panelDashboard.Controls.Add(pictureBox2);
            panelDashboard.Dock = DockStyle.Right;
            panelDashboard.Location = new Point(210, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(731, 640);
            panelDashboard.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(729, 638);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 640);
            Controls.Add(panelDashboard);
            Controls.Add(panelSide);
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panelSide.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSide;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonHome;
        private Button buttonSwim;
        private Button buttonHistory;
        private Button buttonSettings;
        private Panel panel2;
        private Label labelUsername;
        private PictureBox pictureBox1;
        private Panel panelDashboard;
        private PictureBox pictureBox2;
    }
}