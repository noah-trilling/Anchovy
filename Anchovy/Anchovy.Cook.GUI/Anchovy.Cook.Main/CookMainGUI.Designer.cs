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
            this.components = new System.ComponentModel.Container();
            this.anchovyLabel = new System.Windows.Forms.Label();
            this.myQLabel = new System.Windows.Forms.Label();
            this.myQueue = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.completeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalQueue = new System.Windows.Forms.ListBox();
            this.globalQLabel = new System.Windows.Forms.Label();
            this.ingredientsBox = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
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
            this.myQueue.ContextMenuStrip = this.contextMenuStrip1;
            this.myQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myQueue.ItemHeight = 18;
            this.myQueue.Location = new System.Drawing.Point(12, 78);
            this.myQueue.Name = "myQueue";
            this.myQueue.Size = new System.Drawing.Size(152, 166);
            this.myQueue.TabIndex = 3;
            this.myQueue.DragDrop += new System.Windows.Forms.DragEventHandler(this.myQueue_DragDrop);
            this.myQueue.DragEnter += new System.Windows.Forms.DragEventHandler(this.myQueue_DragEnter);
            this.myQueue.DragOver += new System.Windows.Forms.DragEventHandler(this.myQueue_DragOver);
            this.myQueue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myQueue_MouseDoubleClick);
            this.myQueue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myQueue_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completeToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 48);
            this.contextMenuStrip1.Text = "can";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // completeToolStripMenuItem
            // 
            this.completeToolStripMenuItem.Name = "completeToolStripMenuItem";
            this.completeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.completeToolStripMenuItem.Text = "Complete";
            this.completeToolStripMenuItem.Click += new System.EventHandler(this.completeToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // globalQueue
            // 
            this.globalQueue.AllowDrop = true;
            this.globalQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalQueue.ItemHeight = 18;
            this.globalQueue.Location = new System.Drawing.Point(221, 78);
            this.globalQueue.Name = "globalQueue";
            this.globalQueue.Size = new System.Drawing.Size(152, 166);
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
            // ingredientsBox
            // 
            this.ingredientsBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ingredientsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ingredientsBox.Location = new System.Drawing.Point(409, 78);
            this.ingredientsBox.Name = "ingredientsBox";
            this.ingredientsBox.Size = new System.Drawing.Size(323, 166);
            this.ingredientsBox.TabIndex = 8;
            this.ingredientsBox.UseCompatibleStateImageBehavior = false;
            this.ingredientsBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 320;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ingredientsLabel.Location = new System.Drawing.Point(515, 55);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(49, 20);
            this.ingredientsLabel.TabIndex = 9;
            this.ingredientsLabel.Text = "Order";
            // 
            // logoutButton
            // 
            this.logoutButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoutButton.Location = new System.Drawing.Point(664, 275);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(70, 23);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.Location = new System.Drawing.Point(253, 257);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // CookMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 316);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientsBox);
            this.Controls.Add(this.globalQueue);
            this.Controls.Add(this.globalQLabel);
            this.Controls.Add(this.myQueue);
            this.Controls.Add(this.myQLabel);
            this.Controls.Add(this.anchovyLabel);
            this.Name = "CookMainGUI";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CookMainGUI_FormClosed);
            this.Load += new System.EventHandler(this.CookMainGUI_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label anchovyLabel;
        private System.Windows.Forms.Label myQLabel;
        private System.Windows.Forms.ListBox myQueue;
        private System.Windows.Forms.ListBox globalQueue;
        private System.Windows.Forms.Label globalQLabel;
        private System.Windows.Forms.ListView ingredientsBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem completeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

