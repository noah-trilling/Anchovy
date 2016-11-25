namespace Anchovy.Customer.ForgotPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.forgotEmail = new System.Windows.Forms.TextBox();
            this.cancelForgot = new System.Windows.Forms.Button();
            this.sendForgot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // forgotEmail
            // 
            this.forgotEmail.Location = new System.Drawing.Point(98, 112);
            this.forgotEmail.Name = "forgotEmail";
            this.forgotEmail.Size = new System.Drawing.Size(268, 20);
            this.forgotEmail.TabIndex = 11;
            // 
            // cancelForgot
            // 
            this.cancelForgot.ForeColor = System.Drawing.Color.Red;
            this.cancelForgot.Location = new System.Drawing.Point(98, 138);
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
            this.sendForgot.ForeColor = System.Drawing.Color.White;
            this.sendForgot.Location = new System.Drawing.Point(246, 138);
            this.sendForgot.Name = "sendForgot";
            this.sendForgot.Size = new System.Drawing.Size(120, 78);
            this.sendForgot.TabIndex = 14;
            this.sendForgot.Text = "Send!";
            this.sendForgot.UseVisualStyleBackColor = false;
            this.sendForgot.Click += new System.EventHandler(this.sendForgot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(100, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please enter your email";
            // 
            // forgotMessage
            // 
            this.forgotMessage.AutoSize = true;
            this.forgotMessage.ForeColor = System.Drawing.Color.LawnGreen;
            this.forgotMessage.Location = new System.Drawing.Point(372, 117);
            this.forgotMessage.Name = "forgotMessage";
            this.forgotMessage.Size = new System.Drawing.Size(70, 13);
            this.forgotMessage.TabIndex = 16;
            this.forgotMessage.Text = "                     ";
            // 
            // CustomerForgotPasswordGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 274);
            this.Controls.Add(this.forgotMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendForgot);
            this.Controls.Add(this.cancelForgot);
            this.Controls.Add(this.forgotEmail);
            this.Controls.Add(this.label2);
            this.Name = "CustomerForgotPasswordGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox forgotEmail;
        private System.Windows.Forms.Button cancelForgot;
        private System.Windows.Forms.Button sendForgot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forgotMessage;
    }
}

