namespace CustomerLogin
{
    partial class CustomerLoginGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.guestCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(226, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(152, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please login or create an account.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(153, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(153, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(246, 222);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(268, 20);
            this.passwordBox.TabIndex = 13;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(246, 180);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(268, 20);
            this.usernameBox.TabIndex = 12;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.ForestGreen;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(312, 282);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(134, 65);
            this.signInButton.TabIndex = 15;
            this.signInButton.Text = "Sign In!";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword.Location = new System.Drawing.Point(343, 245);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(171, 20);
            this.forgotPassword.TabIndex = 14;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "Forgot your password?";
            this.forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassword_LinkClicked);
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.Red;
            this.createAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.White;
            this.createAccountButton.Location = new System.Drawing.Point(246, 381);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(268, 78);
            this.createAccountButton.TabIndex = 16;
            this.createAccountButton.Text = "Create New Account!";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(168, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(429, 2);
            this.label5.TabIndex = 16;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(521, 184);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(94, 13);
            this.usernameError.TabIndex = 17;
            this.usernameError.Text = "                             ";
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(520, 227);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(85, 13);
            this.passwordError.TabIndex = 18;
            this.passwordError.Text = "                          ";
            // 
            // guestCheckout
            // 
            this.guestCheckout.BackColor = System.Drawing.Color.DodgerBlue;
            this.guestCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCheckout.ForeColor = System.Drawing.Color.White;
            this.guestCheckout.Location = new System.Drawing.Point(580, 12);
            this.guestCheckout.Name = "guestCheckout";
            this.guestCheckout.Size = new System.Drawing.Size(134, 65);
            this.guestCheckout.TabIndex = 17;
            this.guestCheckout.Text = "Guest Checkout";
            this.guestCheckout.UseVisualStyleBackColor = false;
            this.guestCheckout.Click += new System.EventHandler(this.guestCheckout_Click);
            // 
            // CustomerLoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(726, 496);
            this.Controls.Add(this.guestCheckout);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerLoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.LinkLabel forgotPassword;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Button guestCheckout;
    }
}

