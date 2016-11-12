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
            this.anchovyLabel = new System.Windows.Forms.Label();
            this.myQLabel = new System.Windows.Forms.Label();
            this.myQueue = new System.Windows.Forms.ListBox();
            this.globalQueue = new System.Windows.Forms.ListBox();
            this.globalQLabel = new System.Windows.Forms.Label();
            this.completedQueue = new System.Windows.Forms.ListBox();
            this.completeQLabel = new System.Windows.Forms.Label();
            this.ingredientsBox = new System.Windows.Forms.ListView();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.clearQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anchovyLabel
            // 
            this.anchovyLabel.AutoSize = true;
            this.anchovyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchovyLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.anchovyLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.anchovyLabel.Location = new System.Drawing.Point(248, 9);
            this.anchovyLabel.Name = "anchovyLabel";
            this.anchovyLabel.Size = new System.Drawing.Size(102, 29);
            this.anchovyLabel.TabIndex = 1;
            this.anchovyLabel.Text = "Anchovy";
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
            this.myQueue.AllowDrop = true;
            this.myQueue.Items.AddRange(new object[] {
            "Large Pepperoni",
            "Small Veggie",
            "Medium All American"});
            this.myQueue.Location = new System.Drawing.Point(12, 78);
            this.myQueue.Name = "myQueue";
            this.myQueue.Size = new System.Drawing.Size(152, 173);
            this.myQueue.TabIndex = 3;
            this.myQueue.DragDrop += new System.Windows.Forms.DragEventHandler(this.myQueue_DragDrop);
            this.myQueue.DragEnter += new System.Windows.Forms.DragEventHandler(this.myQueue_DragEnter);
            this.myQueue.DragOver += new System.Windows.Forms.DragEventHandler(this.myQueue_DragOver);
            this.myQueue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myQueue_MouseDoubleClick);
            this.myQueue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myQueue_MouseDown);
            // 
            // globalQueue
            // 
            this.globalQueue.AllowDrop = true;
            this.globalQueue.Items.AddRange(new object[] {
            "Large Pepperoni",
            "Small Veggie",
            "Medium All American"});
            this.globalQueue.Location = new System.Drawing.Point(221, 78);
            this.globalQueue.Name = "globalQueue";
            this.globalQueue.Size = new System.Drawing.Size(152, 173);
            this.globalQueue.TabIndex = 5;
            this.globalQueue.DragDrop += new System.Windows.Forms.DragEventHandler(this.globalQueue_DragDrop);
            this.globalQueue.DragEnter += new System.Windows.Forms.DragEventHandler(this.globalQueue_DragEnter);
            this.globalQueue.DragOver += new System.Windows.Forms.DragEventHandler(this.globalQueue_DragOver);
            this.globalQueue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.globalQueue_MouseDown);
            // 
            // globalQLabel
            // 
            this.globalQLabel.AutoSize = true;
            this.globalQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalQLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.globalQLabel.Location = new System.Drawing.Point(238, 55);
            this.globalQLabel.Name = "globalQLabel";
            this.globalQLabel.Size = new System.Drawing.Size(112, 20);
            this.globalQLabel.TabIndex = 4;
            this.globalQLabel.Text = "GloabalQueue";
            // 
            // completedQueue
            // 
            this.completedQueue.AllowDrop = true;
            this.completedQueue.Items.AddRange(new object[] {
            "Large Pepperoni",
            "Small Veggie",
            "Medium All American"});
            this.completedQueue.Location = new System.Drawing.Point(430, 78);
            this.completedQueue.Name = "completedQueue";
            this.completedQueue.Size = new System.Drawing.Size(152, 173);
            this.completedQueue.TabIndex = 7;
            this.completedQueue.DragDrop += new System.Windows.Forms.DragEventHandler(this.completedQueue_DragDrop);
            this.completedQueue.DragEnter += new System.Windows.Forms.DragEventHandler(this.completedQueue_DragEnter);
            this.completedQueue.DragOver += new System.Windows.Forms.DragEventHandler(this.completedQueue_DragOver);
            this.completedQueue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.completedQueue_MouseDown);
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
            // ingredientsBox
            // 
            this.ingredientsBox.AllowDrop = true;
            this.ingredientsBox.Location = new System.Drawing.Point(12, 310);
            this.ingredientsBox.Name = "ingredientsBox";
            this.ingredientsBox.Size = new System.Drawing.Size(229, 97);
            this.ingredientsBox.TabIndex = 8;
            this.ingredientsBox.UseCompatibleStateImageBehavior = false;
            this.ingredientsBox.View = System.Windows.Forms.View.List;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ingredientsLabel.Location = new System.Drawing.Point(24, 287);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(89, 20);
            this.ingredientsLabel.TabIndex = 9;
            this.ingredientsLabel.Text = "Ingredients";
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
            // clearQueue
            // 
            this.clearQueue.BackColor = System.Drawing.SystemColors.Control;
            this.clearQueue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.clearQueue.Location = new System.Drawing.Point(470, 257);
            this.clearQueue.Name = "clearQueue";
            this.clearQueue.Size = new System.Drawing.Size(75, 23);
            this.clearQueue.TabIndex = 12;
            this.clearQueue.Text = "Clear";
            this.clearQueue.UseVisualStyleBackColor = false;
            this.clearQueue.Click += new System.EventHandler(this.clearQueue_Click);
            // 
            // CookMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 432);
            this.Controls.Add(this.clearQueue);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientsBox);
            this.Controls.Add(this.completedQueue);
            this.Controls.Add(this.completeQLabel);
            this.Controls.Add(this.globalQueue);
            this.Controls.Add(this.globalQLabel);
            this.Controls.Add(this.myQueue);
            this.Controls.Add(this.myQLabel);
            this.Controls.Add(this.anchovyLabel);
            this.Name = "CookMainGUI";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CookMainGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label anchovyLabel;
        private System.Windows.Forms.Label myQLabel;
        private System.Windows.Forms.ListBox myQueue;
        private System.Windows.Forms.ListBox globalQueue;
        private System.Windows.Forms.Label globalQLabel;
        private System.Windows.Forms.ListBox completedQueue;
        private System.Windows.Forms.Label completeQLabel;
        private System.Windows.Forms.ListView ingredientsBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button clearQueue;
    }
}

