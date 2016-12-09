namespace Anchovy.Manager.Main
{
    partial class ManagerLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblInvaildPassword = new System.Windows.Forms.Label();
            this.lblInvaildUser = new System.Windows.Forms.Label();
            this.anchovyLabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Location = new System.Drawing.Point(149, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(288, 51);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInvaildPassword
            // 
            this.lblInvaildPassword.AutoSize = true;
            this.lblInvaildPassword.ForeColor = System.Drawing.Color.Red;
            this.lblInvaildPassword.Location = new System.Drawing.Point(406, 215);
            this.lblInvaildPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvaildPassword.Name = "lblInvaildPassword";
            this.lblInvaildPassword.Size = new System.Drawing.Size(49, 20);
            this.lblInvaildPassword.TabIndex = 15;
            this.lblInvaildPassword.Text = "          ";
            // 
            // lblInvaildUser
            // 
            this.lblInvaildUser.AutoSize = true;
            this.lblInvaildUser.ForeColor = System.Drawing.Color.Red;
            this.lblInvaildUser.Location = new System.Drawing.Point(406, 159);
            this.lblInvaildUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvaildUser.Name = "lblInvaildUser";
            this.lblInvaildUser.Size = new System.Drawing.Size(49, 20);
            this.lblInvaildUser.TabIndex = 14;
            this.lblInvaildUser.Text = "          ";
            // 
            // anchovyLabel
            // 
            this.anchovyLabel.AutoSize = true;
            this.anchovyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchovyLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.anchovyLabel.Location = new System.Drawing.Point(211, 23);
            this.anchovyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.anchovyLabel.Name = "anchovyLabel";
            this.anchovyLabel.Size = new System.Drawing.Size(155, 40);
            this.anchovyLabel.TabIndex = 13;
            this.anchovyLabel.Text = "Anchovy";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(246, 209);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 26);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.UseWaitCursor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(246, 156);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 26);
            this.txtUserName.TabIndex = 11;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.passwordLabel.Location = new System.Drawing.Point(113, 205);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 29);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.usernameLabel.Location = new System.Drawing.Point(113, 152);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(124, 29);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(224, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "(Manager)";
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(603, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInvaildPassword);
            this.Controls.Add(this.lblInvaildUser);
            this.Controls.Add(this.anchovyLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.btnLogin);
            this.Name = "ManagerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Login";
            this.Load += new System.EventHandler(this.ManagerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblInvaildPassword;
        private System.Windows.Forms.Label lblInvaildUser;
        private System.Windows.Forms.Label anchovyLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
    }
}