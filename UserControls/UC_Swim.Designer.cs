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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panelCategory.SuspendLayout();
            panelDifficulty.SuspendLayout();
            panelDistance.SuspendLayout();
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
            panelCategory.Controls.Add(label2);
            panelCategory.Location = new Point(92, 106);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(262, 195);
            panelCategory.TabIndex = 2;
            // 
            // panelDifficulty
            // 
            panelDifficulty.BackColor = Color.DeepSkyBlue;
            panelDifficulty.Controls.Add(label3);
            panelDifficulty.Location = new Point(376, 106);
            panelDifficulty.Name = "panelDifficulty";
            panelDifficulty.Size = new Size(262, 195);
            panelDifficulty.TabIndex = 3;
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.DeepSkyBlue;
            panelTime.Location = new Point(376, 329);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(262, 82);
            panelTime.TabIndex = 4;
            // 
            // panelDistance
            // 
            panelDistance.BackColor = Color.DeepSkyBlue;
            panelDistance.Controls.Add(label4);
            panelDistance.Location = new Point(92, 329);
            panelDistance.Name = "panelDistance";
            panelDistance.Size = new Size(262, 82);
            panelDistance.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(50, 10);
            label2.Name = "label2";
            label2.Size = new Size(162, 27);
            label2.TabIndex = 0;
            label2.Text = "Choose a catgeory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(52, 10);
            label3.Name = "label3";
            label3.Size = new Size(161, 27);
            label3.TabIndex = 0;
            label3.Text = "Choose a difficulty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(27, 28);
            label4.Name = "label4";
            label4.Size = new Size(81, 27);
            label4.TabIndex = 0;
            label4.Text = "Distance";
            label4.Click += label4_Click;
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
            panelCategory.PerformLayout();
            panelDifficulty.ResumeLayout(false);
            panelDifficulty.PerformLayout();
            panelDistance.ResumeLayout(false);
            panelDistance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panelCategory;
        private Label label2;
        private Panel panelDifficulty;
        private Label label3;
        private Panel panelTime;
        private Panel panelDistance;
        private Label label4;
    }
}
