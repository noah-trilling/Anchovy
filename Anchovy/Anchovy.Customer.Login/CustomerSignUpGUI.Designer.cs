namespace CustomerSignUp
{
    partial class CustomerSignUpGUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordSignup1 = new System.Windows.Forms.TextBox();
            this.passwordSignup2 = new System.Windows.Forms.TextBox();
            this.emailSignup = new System.Windows.Forms.TextBox();
            this.usernameSignup = new System.Windows.Forms.TextBox();
            this.signUpSignup = new System.Windows.Forms.Button();
            this.cancelSignup = new System.Windows.Forms.Button();
            this.signUpError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(94, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your login information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(92, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(97, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(127, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(39, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirm password:";
            // 
            // passwordSignup1
            // 
            this.passwordSignup1.Location = new System.Drawing.Point(185, 176);
            this.passwordSignup1.Name = "passwordSignup1";
            this.passwordSignup1.Size = new System.Drawing.Size(268, 20);
            this.passwordSignup1.TabIndex = 6;
            this.passwordSignup1.UseSystemPasswordChar = true;
            // 
            // passwordSignup2
            // 
            this.passwordSignup2.Location = new System.Drawing.Point(185, 202);
            this.passwordSignup2.Name = "passwordSignup2";
            this.passwordSignup2.Size = new System.Drawing.Size(268, 20);
            this.passwordSignup2.TabIndex = 7;
            this.passwordSignup2.UseSystemPasswordChar = true;
            // 
            // emailSignup
            // 
            this.emailSignup.Location = new System.Drawing.Point(185, 150);
            this.emailSignup.Name = "emailSignup";
            this.emailSignup.Size = new System.Drawing.Size(268, 20);
            this.emailSignup.TabIndex = 8;
            // 
            // usernameSignup
            // 
            this.usernameSignup.Location = new System.Drawing.Point(185, 124);
            this.usernameSignup.Name = "usernameSignup";
            this.usernameSignup.Size = new System.Drawing.Size(268, 20);
            this.usernameSignup.TabIndex = 10;
            // 
            // signUpSignup
            // 
            this.signUpSignup.BackColor = System.Drawing.Color.ForestGreen;
            this.signUpSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpSignup.ForeColor = System.Drawing.Color.White;
            this.signUpSignup.Location = new System.Drawing.Point(331, 228);
            this.signUpSignup.Name = "signUpSignup";
            this.signUpSignup.Size = new System.Drawing.Size(122, 63);
            this.signUpSignup.TabIndex = 11;
            this.signUpSignup.Text = "Sign Up!";
            this.signUpSignup.UseVisualStyleBackColor = false;
            this.signUpSignup.Click += new System.EventHandler(this.signUpSignup_Click);
            // 
            // cancelSignup
            // 
            this.cancelSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSignup.ForeColor = System.Drawing.Color.Red;
            this.cancelSignup.Location = new System.Drawing.Point(185, 228);
            this.cancelSignup.Name = "cancelSignup";
            this.cancelSignup.Size = new System.Drawing.Size(111, 63);
            this.cancelSignup.TabIndex = 12;
            this.cancelSignup.Text = "Cancel";
            this.cancelSignup.UseVisualStyleBackColor = true;
            this.cancelSignup.Click += new System.EventHandler(this.cancelSignup_Click);
            // 
            // signUpError
            // 
            this.signUpError.AutoSize = true;
            this.signUpError.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpError.ForeColor = System.Drawing.Color.Red;
            this.signUpError.Location = new System.Drawing.Point(203, 34);
            this.signUpError.Name = "signUpError";
            this.signUpError.Size = new System.Drawing.Size(63, 20);
            this.signUpError.TabIndex = 13;
            this.signUpError.Text = "                  ";
            // 
            // CustomerSignUpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(541, 340);
            this.Controls.Add(this.signUpError);
            this.Controls.Add(this.cancelSignup);
            this.Controls.Add(this.signUpSignup);
            this.Controls.Add(this.usernameSignup);
            this.Controls.Add(this.emailSignup);
            this.Controls.Add(this.passwordSignup2);
            this.Controls.Add(this.passwordSignup1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSignUpGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordSignup1;
        private System.Windows.Forms.TextBox passwordSignup2;
        private System.Windows.Forms.TextBox emailSignup;
        private System.Windows.Forms.TextBox usernameSignup;
        private System.Windows.Forms.Button signUpSignup;
        private System.Windows.Forms.Button cancelSignup;
        private System.Windows.Forms.Label signUpError;
    }
}

