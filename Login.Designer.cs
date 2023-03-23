namespace The_Big_Pool
{
    
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panelLogin = new Panel();
            buttonCreateAccount = new Button();
            buttonLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label1 = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackgroundImage = (Image)resources.GetObject("panelLogin.BackgroundImage");
            panelLogin.Controls.Add(buttonCreateAccount);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Controls.Add(textBoxUsername);
            panelLogin.Controls.Add(label1);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(613, 475);
            panelLogin.TabIndex = 0;
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.Location = new Point(91, 362);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(198, 42);
            buttonCreateAccount.TabIndex = 7;
            buttonCreateAccount.Text = "Create Account";
            buttonCreateAccount.UseVisualStyleBackColor = true;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(323, 362);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(198, 42);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(71, 90);
            label4.Name = "label4";
            label4.Size = new Size(479, 90);
            label4.TabIndex = 5;
            label4.Text = "Welcome to The Big Pool! New to the pool? Press the \"Create Account\" button below and get starter. Already have an account, continue logging in below.";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(98, 262);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 4;
            label3.Text = "Enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(94, 204);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter Username";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(262, 259);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(256, 31);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(262, 201);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(256, 31);
            textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(123, 45);
            label1.Name = "label1";
            label1.Size = new Size(366, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome To The Big Pool!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 475);
            Controls.Add(panelLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Button buttonCreateAccount;
        private Button buttonLogin;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label1;
    }
}