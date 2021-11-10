
namespace OOAD_Project
{
    partial class LoginForm
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
            this.emailLoginTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userSecretTextBox = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.Location = new System.Drawing.Point(127, 39);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Size = new System.Drawing.Size(185, 20);
            this.emailLoginTextBox.TabIndex = 0;
            this.emailLoginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailLoginTextBox_KeyDown);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(34, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // userSecretTextBox
            // 
            this.userSecretTextBox.AutoSize = true;
            this.userSecretTextBox.Location = new System.Drawing.Point(34, 88);
            this.userSecretTextBox.Name = "userSecretTextBox";
            this.userSecretTextBox.Size = new System.Drawing.Size(53, 13);
            this.userSecretTextBox.TabIndex = 5;
            this.userSecretTextBox.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(127, 82);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(185, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(37, 139);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(275, 38);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registrationBtn
            // 
            this.registrationBtn.Location = new System.Drawing.Point(37, 197);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(275, 38);
            this.registrationBtn.TabIndex = 3;
            this.registrationBtn.Text = "Register";
            this.registrationBtn.UseVisualStyleBackColor = true;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 278);
            this.Controls.Add(this.registrationBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userSecretTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailLoginTextBox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailLoginTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label userSecretTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registrationBtn;
    }
}