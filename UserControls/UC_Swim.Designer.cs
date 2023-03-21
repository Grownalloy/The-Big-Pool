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
<<<<<<< HEAD
            SuspendLayout();
            // 
=======
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 239);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome Swim";
            // 
>>>>>>> bc294c9973078a78aa10d7ab3c65ac4f9f6625b1
            // UC_Swim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            Name = "UC_Swim";
            Size = new Size(731, 640);
            ResumeLayout(false);
=======
            Controls.Add(label1);
            Name = "UC_Swim";
            Size = new Size(731, 640);
            ResumeLayout(false);
            PerformLayout();
>>>>>>> bc294c9973078a78aa10d7ab3c65ac4f9f6625b1
        }

        #endregion

        private Label label1;
    }
}
