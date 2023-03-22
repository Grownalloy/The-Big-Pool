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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
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
            panel2.Controls.Add(label3);
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 567);
            panel2.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 28);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 2;
            label2.Text = "Select a day:";
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
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.ForeColor = Color.SteelBlue;
            progressBar1.Location = new Point(521, 80);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(193, 35);
            progressBar1.Step = 7;
            progressBar1.TabIndex = 4;
            progressBar1.Value = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(522, 47);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 5;
            label3.Text = "Week Progress:";
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
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}
