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
            panelLogin.Margin = new Padding(2, 2, 2, 2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(429, 285);
            panelLogin.TabIndex = 0;
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.BackColor = Color.MidnightBlue;
            buttonCreateAccount.FlatStyle = FlatStyle.Popup;
            buttonCreateAccount.ForeColor = Color.White;
            buttonCreateAccount.Location = new Point(64, 217);
            buttonCreateAccount.Margin = new Padding(2, 2, 2, 2);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(139, 25);
            buttonCreateAccount.TabIndex = 7;
            buttonCreateAccount.Text = "Create Account";
            buttonCreateAccount.UseVisualStyleBackColor = false;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.MidnightBlue;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(226, 217);
            buttonLogin.Margin = new Padding(2, 2, 2, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(139, 25);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 54);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(335, 54);
            label4.TabIndex = 5;
            label4.Text = "Welcome to The Big Pool! New to the pool? Press the \"Create Account\" button below and get starter. Already have an account, continue logging in below.";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(69, 157);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(66, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter Username";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(183, 155);
            textBoxPassword.Margin = new Padding(2, 2, 2, 2);
            textBoxPassword.MaxLength = 20;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(180, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(183, 121);
            textBoxUsername.Margin = new Padding(2, 2, 2, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(180, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(86, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 22);
            label1.TabIndex = 0;
            label1.Text = "Welcome To The Big Pool!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 285);
            Controls.Add(panelLogin);
            Margin = new Padding(2, 2, 2, 2);
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