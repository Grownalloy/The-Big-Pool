namespace The_Big_Pool.UserControls
{
    partial class UC_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_History));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            label2 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
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
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(136, 45);
            label1.TabIndex = 0;
            label1.Text = "History";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 567);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(500, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 567);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(16, 250);
            label8.Name = "label8";
            label8.Size = new Size(103, 54);
            label8.TabIndex = 11;
            label8.Text = "0:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(16, 301);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 10;
            label9.Text = "Duration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(16, 378);
            label6.Name = "label6";
            label6.Size = new Size(46, 54);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(16, 424);
            label7.Name = "label7";
            label7.Size = new Size(145, 21);
            label7.TabIndex = 8;
            label7.Text = "Number of Workouts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(16, 122);
            label5.Name = "label5";
            label5.Size = new Size(103, 54);
            label5.TabIndex = 7;
            label5.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(16, 178);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 6;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(7, 11);
            label3.Name = "label3";
            label3.Size = new Size(221, 111);
            label3.TabIndex = 5;
            label3.Text = "Daily Performance";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(monthCalendar1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(501, 567);
            panel3.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.InactiveBorder;
            monthCalendar1.Location = new Point(89, 205);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(177, 489);
            button1.Name = "button1";
            button1.Size = new Size(141, 49);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(471, 157);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Location = new Point(7, 108);
            label10.Name = "label10";
            label10.Size = new Size(221, 24);
            label10.TabIndex = 12;
            label10.Text = "-------------------------------";
            // 
            // UC_History
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_History";
            Size = new Size(731, 640);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Label label10;
    }
}
