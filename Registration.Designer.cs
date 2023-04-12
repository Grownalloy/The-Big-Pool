﻿namespace The_Big_Pool
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            panelRegistration = new Panel();
            label8 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBoxConPass = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonRegister = new Button();
            buttonBacktoLogin = new Button();
            textBox1 = new TextBox();
            panelRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistration
            // 
            panelRegistration.BackColor = Color.Transparent;
            panelRegistration.BackgroundImage = (Image)resources.GetObject("panelRegistration.BackgroundImage");
            panelRegistration.Controls.Add(textBox1);
            panelRegistration.Controls.Add(label8);
            panelRegistration.Controls.Add(comboBox2);
            panelRegistration.Controls.Add(comboBox1);
            panelRegistration.Controls.Add(textBoxConPass);
            panelRegistration.Controls.Add(textBoxPassword);
            panelRegistration.Controls.Add(textBoxUsername);
            panelRegistration.Controls.Add(label7);
            panelRegistration.Controls.Add(label6);
            panelRegistration.Controls.Add(label5);
            panelRegistration.Controls.Add(label4);
            panelRegistration.Controls.Add(label3);
            panelRegistration.Controls.Add(label2);
            panelRegistration.Controls.Add(label1);
            panelRegistration.Controls.Add(buttonRegister);
            panelRegistration.Controls.Add(buttonBacktoLogin);
            panelRegistration.Dock = DockStyle.Fill;
            panelRegistration.Location = new Point(0, 0);
            panelRegistration.Name = "panelRegistration";
            panelRegistration.Size = new Size(613, 475);
            panelRegistration.TabIndex = 16;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(30, 202);
            label8.Name = "label8";
            label8.Size = new Size(552, 47);
            label8.TabIndex = 18;
            label8.Text = "Below please select a category, level of difficulty, and a typical distance that suits you skill level appropriately.";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Garnet", "Bronze", "Silver", "Gold", "Senior" });
            comboBox2.Location = new Point(271, 311);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(253, 33);
            comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Stroke", "Medley", "Freestyle", "Pace", "Sprint" });
            comboBox1.Location = new Point(271, 266);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 33);
            comboBox1.TabIndex = 15;
            // 
            // textBoxConPass
            // 
            textBoxConPass.Location = new Point(271, 147);
            textBoxConPass.Name = "textBoxConPass";
            textBoxConPass.PlaceholderText = "Confirm Password";
            textBoxConPass.Size = new Size(253, 31);
            textBoxConPass.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            textBoxPassword.ForeColor = SystemColors.WindowText;
            textBoxPassword.Location = new Point(271, 102);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(253, 31);
            textBoxPassword.TabIndex = 13;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(271, 57);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(253, 31);
            textBoxUsername.TabIndex = 12;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(94, 153);
            label7.Name = "label7";
            label7.Size = new Size(156, 25);
            label7.TabIndex = 8;
            label7.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(159, 63);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 7;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(163, 108);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(171, 361);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 5;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(124, 319);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 4;
            label3.Text = "Difficulty Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(166, 274);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(193, 18);
            label1.Name = "label1";
            label1.Size = new Size(226, 31);
            label1.TabIndex = 2;
            label1.Text = "Create Account";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Gold;
            buttonRegister.FlatStyle = FlatStyle.Popup;
            buttonRegister.Location = new Point(308, 408);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(199, 42);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "Register Account";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonBacktoLogin
            // 
            buttonBacktoLogin.BackColor = Color.Gold;
            buttonBacktoLogin.FlatStyle = FlatStyle.Popup;
            buttonBacktoLogin.Location = new Point(106, 408);
            buttonBacktoLogin.Name = "buttonBacktoLogin";
            buttonBacktoLogin.Size = new Size(199, 42);
            buttonBacktoLogin.TabIndex = 0;
            buttonBacktoLogin.Text = "Back to Login";
            buttonBacktoLogin.UseVisualStyleBackColor = false;
            buttonBacktoLogin.Click += buttonBacktoLogin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 359);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "100 yds";
            textBox1.Size = new Size(253, 31);
            textBox1.TabIndex = 19;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 475);
            Controls.Add(panelRegistration);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            panelRegistration.ResumeLayout(false);
            panelRegistration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegistration;
        private TextBox textBoxConPass;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonRegister;
        private Button buttonBacktoLogin;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBox2;
        private TextBox textBox1;
    }
}