namespace Anchovy.Cook.Main
{
    partial class CookMainGUI
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
            this.myQLabel = new System.Windows.Forms.Label();
            this.myQueue = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.globalQLabel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.completeQLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anchovy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // myQLabel
            // 
            this.myQLabel.AutoSize = true;
            this.myQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myQLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.myQLabel.Location = new System.Drawing.Point(53, 55);
            this.myQLabel.Name = "myQLabel";
            this.myQLabel.Size = new System.Drawing.Size(77, 20);
            this.myQLabel.TabIndex = 2;
            this.myQLabel.Text = "MyQueue";
            // 
            // myQueue
            // 
            this.myQueue.Items.AddRange(new object[] {
            "Large Pepperoni",
            "Small Veggie",
            "Medium All American"});
            this.myQueue.Location = new System.Drawing.Point(12, 78);
            this.myQueue.Name = "myQueue";
            this.myQueue.Size = new System.Drawing.Size(152, 173);
            this.myQueue.TabIndex = 3;
            this.myQueue.SelectedIndexChanged += new System.EventHandler(this.myQueue_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Items.AddRange(new object[] {
            "Large Pepperoni",
            "Small Veggie",
            "Medium All American"});
            this.listBox1.Location = new System.Drawing.Point(221, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 173);
            this.listBox1.TabIndex = 5;
            // 
            // globalQLabel
            // 
            this.globalQLabel.AutoSize = true;
            this.globalQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalQLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.globalQLabel.Location = new System.Drawing.Point(262, 55);
            this.globalQLabel.Name = "globalQLabel";
            this.globalQLabel.Size = new System.Drawing.Size(112, 20);
            this.globalQLabel.TabIndex = 4;
            this.globalQLabel.Text = "GloabalQueue";
            // 
            // listBox2
            // 
            this.listBox2.Items.AddRange(new object[] {
            "Large Pepperoni",
            "Small Veggie",
            "Medium All American"});
            this.listBox2.Location = new System.Drawing.Point(430, 78);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 173);
            this.listBox2.TabIndex = 7;
            // 
            // completeQLabel
            // 
            this.completeQLabel.AutoSize = true;
            this.completeQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeQLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.completeQLabel.Location = new System.Drawing.Point(439, 55);
            this.completeQLabel.Name = "completeQLabel";
            this.completeQLabel.Size = new System.Drawing.Size(134, 20);
            this.completeQLabel.TabIndex = 6;
            this.completeQLabel.Text = "CompletedQueue";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 310);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 97);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingredients";
            // 
            // logoutButton
            // 
            this.logoutButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoutButton.Location = new System.Drawing.Point(620, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(70, 23);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // CookMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 432);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.completeQLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.globalQLabel);
            this.Controls.Add(this.myQueue);
            this.Controls.Add(this.myQLabel);
            this.Controls.Add(this.label1);
            this.Name = "CookMainGUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label myQLabel;
        private System.Windows.Forms.ListBox myQueue;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label globalQLabel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label completeQLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutButton;
    }
}

