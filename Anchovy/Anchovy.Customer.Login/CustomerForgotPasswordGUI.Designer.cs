namespace CustomerForgotPassword
{
    partial class CustomerForgotPasswordGUI
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
            this.forgotEmail = new System.Windows.Forms.TextBox();
            this.cancelForgot = new System.Windows.Forms.Button();
            this.sendForgot = new System.Windows.Forms.Button();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.forgotMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotPhone = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // forgotEmail
            // 
            this.forgotEmail.Location = new System.Drawing.Point(137, 90);
            this.forgotEmail.Name = "forgotEmail";
            this.forgotEmail.Size = new System.Drawing.Size(268, 20);
            this.forgotEmail.TabIndex = 11;
            // 
            // cancelForgot
            // 
            this.cancelForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelForgot.ForeColor = System.Drawing.Color.Red;
            this.cancelForgot.Location = new System.Drawing.Point(98, 143);
            this.cancelForgot.Name = "cancelForgot";
            this.cancelForgot.Size = new System.Drawing.Size(116, 78);
            this.cancelForgot.TabIndex = 13;
            this.cancelForgot.Text = "Cancel";
            this.cancelForgot.UseVisualStyleBackColor = true;
            this.cancelForgot.Click += new System.EventHandler(this.cancelForgot_Click);
            // 
            // sendForgot
            // 
            this.sendForgot.BackColor = System.Drawing.Color.ForestGreen;
            this.sendForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendForgot.ForeColor = System.Drawing.Color.White;
            this.sendForgot.Location = new System.Drawing.Point(246, 143);
            this.sendForgot.Name = "sendForgot";
            this.sendForgot.Size = new System.Drawing.Size(120, 78);
            this.sendForgot.TabIndex = 14;
            this.sendForgot.Text = "Send!";
            this.sendForgot.UseVisualStyleBackColor = false;
            this.sendForgot.Click += new System.EventHandler(this.sendForgot_Click);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(51, 9);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(332, 26);
            this.forgotPasswordLabel.TabIndex = 15;
            this.forgotPasswordLabel.Text = "Please enter your email or phone";
            // 
            // forgotMessage
            // 
            this.forgotMessage.AutoSize = true;
            this.forgotMessage.ForeColor = System.Drawing.Color.LawnGreen;
            this.forgotMessage.Location = new System.Drawing.Point(439, 97);
            this.forgotMessage.Name = "forgotMessage";
            this.forgotMessage.Size = new System.Drawing.Size(70, 13);
            this.forgotMessage.TabIndex = 16;
            this.forgotMessage.Text = "                     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "number to have your password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(132, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "sent to you.";
            // 
            // forgotPhone
            // 
            this.forgotPhone.Location = new System.Drawing.Point(137, 117);
            this.forgotPhone.Name = "forgotPhone";
            this.forgotPhone.Size = new System.Drawing.Size(268, 20);
            this.forgotPhone.TabIndex = 19;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton1.Location = new System.Drawing.Point(45, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 24);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Email:";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton2.Location = new System.Drawing.Point(45, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 24);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Phone#:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CustomerForgotPasswordGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 274);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.forgotPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgotMessage);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.sendForgot);
            this.Controls.Add(this.cancelForgot);
            this.Controls.Add(this.forgotEmail);
            this.Name = "CustomerForgotPasswordGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox forgotEmail;
        private System.Windows.Forms.Button cancelForgot;
        private System.Windows.Forms.Button sendForgot;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Label forgotMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox forgotPhone;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

