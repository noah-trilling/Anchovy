namespace Anchovy.Cook.GUI
{
    partial class CookLoginGUI
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.anchovyLabel = new System.Windows.Forms.Label();
            this.invalidUserLabel = new System.Windows.Forms.Label();
            this.invalidPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(66, 81);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(66, 116);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // loginbutton
            // 
            this.loginbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginbutton.Location = new System.Drawing.Point(144, 192);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(124, 23);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(155, 81);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(155, 116);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.UseWaitCursor = true;
            // 
            // anchovyLabel
            // 
            this.anchovyLabel.AutoSize = true;
            this.anchovyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchovyLabel.Location = new System.Drawing.Point(166, 12);
            this.anchovyLabel.Name = "anchovyLabel";
            this.anchovyLabel.Size = new System.Drawing.Size(102, 29);
            this.anchovyLabel.TabIndex = 5;
            this.anchovyLabel.Text = "Anchovy";
            this.anchovyLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // invalidUserLabel
            // 
            this.invalidUserLabel.AutoSize = true;
            this.invalidUserLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidUserLabel.Location = new System.Drawing.Point(261, 84);
            this.invalidUserLabel.Name = "invalidUserLabel";
            this.invalidUserLabel.Size = new System.Drawing.Size(37, 13);
            this.invalidUserLabel.TabIndex = 6;
            this.invalidUserLabel.Text = "          ";
            this.invalidUserLabel.Click += new System.EventHandler(this.invalidUserLabel_Click);
            // 
            // invalidPassLabel
            // 
            this.invalidPassLabel.AutoSize = true;
            this.invalidPassLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidPassLabel.Location = new System.Drawing.Point(261, 119);
            this.invalidPassLabel.Name = "invalidPassLabel";
            this.invalidPassLabel.Size = new System.Drawing.Size(37, 13);
            this.invalidPassLabel.TabIndex = 7;
            this.invalidPassLabel.Text = "          ";
            // 
            // CookLoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.Controls.Add(this.invalidPassLabel);
            this.Controls.Add(this.invalidUserLabel);
            this.Controls.Add(this.anchovyLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "CookLoginGUI";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label anchovyLabel;
        private System.Windows.Forms.Label invalidUserLabel;
        private System.Windows.Forms.Label invalidPassLabel;
    }
}

