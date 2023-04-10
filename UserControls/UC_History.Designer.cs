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
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            panel3 = new Panel();
            button1 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
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
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(108, 45);
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
            panel4.Controls.Add(progressBar1);
            panel4.Location = new Point(500, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 567);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(15, 137);
            label10.Name = "label10";
            label10.Size = new Size(96, 21);
            label10.TabIndex = 12;
            label10.Text = "Habit Tracker";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(15, 332);
            label8.Name = "label8";
            label8.Size = new Size(103, 54);
            label8.TabIndex = 11;
            label8.Text = "0:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(15, 383);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 10;
            label9.Text = "Duration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(15, 460);
            label6.Name = "label6";
            label6.Size = new Size(46, 54);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(15, 506);
            label7.Name = "label7";
            label7.Size = new Size(145, 21);
            label7.TabIndex = 8;
            label7.Text = "Number of Workouts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(15, 204);
            label5.Name = "label5";
            label5.Size = new Size(103, 54);
            label5.TabIndex = 7;
            label5.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(15, 260);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 6;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 28);
            label3.Name = "label3";
            label3.Size = new Size(240, 53);
            label3.TabIndex = 5;
            label3.Text = "Weekly Performance";
            label3.Click += label3_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.ForeColor = Color.SteelBlue;
            progressBar1.Location = new Point(15, 95);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(201, 35);
            progressBar1.Step = 7;
            progressBar1.TabIndex = 4;
            progressBar1.Value = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(7, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(492, 548);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(343, 24);
            button1.Name = "button1";
            button1.Size = new Size(122, 32);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 28);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 2;
            label2.Text = "Select a day:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(164, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(436, 467);
            dataGridView1.TabIndex = 0;
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
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private ProgressBar progressBar1;
        private Panel panel3;
        private Button button1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
    }
}
