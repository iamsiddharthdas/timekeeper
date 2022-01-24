
namespace TimeSheet1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(139, 65);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(73, 20);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(139, 133);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(72, 20);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(324, 65);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(121, 27);
            this.textBoxUser.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(324, 133);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 27);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(235, 214);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 29);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationBtn
            // 
            this.registrationBtn.Location = new System.Drawing.Point(198, 20);
            this.registrationBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(196, 27);
            this.registrationBtn.TabIndex = 5;
            this.registrationBtn.Text = "First Time? Register here";
            this.registrationBtn.UseVisualStyleBackColor = true;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 370);
            this.Controls.Add(this.registrationBtn);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registrationBtn;
    }
}

