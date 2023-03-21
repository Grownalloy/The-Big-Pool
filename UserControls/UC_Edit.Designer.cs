namespace The_Big_Pool.UserControls
{
    partial class UC_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Edit));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            panelEdit = new Panel();
            panelEdit.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 581);
            button1.Name = "button1";
            button1.Size = new Size(221, 53);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 528);
            button2.Name = "button2";
            button2.Size = new Size(221, 53);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 3);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 2;
            label1.Text = "Edit Account Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 49);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 73);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "First Name";
            textBox1.Size = new Size(190, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 137);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Last Name";
            textBox2.Size = new Size(190, 31);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(17, 113);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 265);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Username";
            textBox3.Size = new Size(190, 31);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(17, 241);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 329);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Password";
            textBox4.Size = new Size(190, 31);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 305);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 9;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(17, 201);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email";
            textBox5.Size = new Size(190, 31);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(17, 177);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 393);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Confirm Password";
            textBox6.Size = new Size(190, 31);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(14, 369);
            label7.Name = "label7";
            label7.Size = new Size(137, 21);
            label7.TabIndex = 13;
            label7.Text = "Confirm Password";
            // 
            // panelEdit
            // 
            panelEdit.BackColor = Color.Transparent;
            panelEdit.Controls.Add(textBox6);
            panelEdit.Controls.Add(label7);
            panelEdit.Controls.Add(textBox5);
            panelEdit.Controls.Add(label6);
            panelEdit.Controls.Add(textBox4);
            panelEdit.Controls.Add(label5);
            panelEdit.Controls.Add(textBox3);
            panelEdit.Controls.Add(label4);
            panelEdit.Controls.Add(textBox2);
            panelEdit.Controls.Add(label3);
            panelEdit.Controls.Add(textBox1);
            panelEdit.Controls.Add(label2);
            panelEdit.Controls.Add(label1);
            panelEdit.Dock = DockStyle.Fill;
            panelEdit.Location = new Point(0, 0);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(221, 634);
            panelEdit.TabIndex = 15;
            // 
            // UC_Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panelEdit);
            Name = "UC_Edit";
            Size = new Size(221, 634);
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Panel panelEdit;
    }
}
