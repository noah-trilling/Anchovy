namespace CustomerMain
{
    partial class AnchovyCustomerMainGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AppetizersPanel = new System.Windows.Forms.Panel();
            this.toppingsError = new System.Windows.Forms.Label();
            this.selectedToppings = new System.Windows.Forms.ListBox();
            this.sauceGroup = new System.Windows.Forms.GroupBox();
            this.removeAll = new System.Windows.Forms.Button();
            this.removeOne = new System.Windows.Forms.Button();
            this.addOne = new System.Windows.Forms.Button();
            this.addAll = new System.Windows.Forms.Button();
            this.allToppings = new System.Windows.Forms.ListBox();
            this.cancelToppings = new System.Windows.Forms.Button();
            this.saveToppings = new System.Windows.Forms.Button();
            this.orderError = new System.Windows.Forms.Label();
            this.crustGroup = new System.Windows.Forms.GroupBox();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.appetizersButton = new System.Windows.Forms.Button();
            this.pizzaGroup = new System.Windows.Forms.GroupBox();
            this.shoppingCart1 = new System.Windows.Forms.LinkLabel();
            this.logoutButton1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.orderHistory = new System.Windows.Forms.GroupBox();
            this.shoppingCart2 = new System.Windows.Forms.LinkLabel();
            this.logoutButton2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.infoError = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cancelInfo = new System.Windows.Forms.Button();
            this.updateInfo = new System.Windows.Forms.Button();
            this.infoPassword2 = new System.Windows.Forms.TextBox();
            this.infoPassword1 = new System.Windows.Forms.TextBox();
            this.infoUsername = new System.Windows.Forms.TextBox();
            this.infoEmail = new System.Windows.Forms.TextBox();
            this.infoPhone = new System.Windows.Forms.TextBox();
            this.infoState = new System.Windows.Forms.TextBox();
            this.infoCity = new System.Windows.Forms.TextBox();
            this.infoAddress = new System.Windows.Forms.TextBox();
            this.infoLastName = new System.Windows.Forms.TextBox();
            this.infoMiddleName = new System.Windows.Forms.TextBox();
            this.infoFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shoppingCart3 = new System.Windows.Forms.LinkLabel();
            this.logoutButton3 = new System.Windows.Forms.Button();
            this.outOfStock = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AppetizersPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 48);
            this.tabControl1.Location = new System.Drawing.Point(-2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AppetizersPanel);
            this.tabPage1.Controls.Add(this.orderError);
            this.tabPage1.Controls.Add(this.crustGroup);
            this.tabPage1.Controls.Add(this.sizeGroup);
            this.tabPage1.Controls.Add(this.appetizersButton);
            this.tabPage1.Controls.Add(this.pizzaGroup);
            this.tabPage1.Controls.Add(this.shoppingCart1);
            this.tabPage1.Controls.Add(this.logoutButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 52);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AppetizersPanel
            // 
            this.AppetizersPanel.Controls.Add(this.outOfStock);
            this.AppetizersPanel.Controls.Add(this.toppingsError);
            this.AppetizersPanel.Controls.Add(this.selectedToppings);
            this.AppetizersPanel.Controls.Add(this.sauceGroup);
            this.AppetizersPanel.Controls.Add(this.removeAll);
            this.AppetizersPanel.Controls.Add(this.removeOne);
            this.AppetizersPanel.Controls.Add(this.addOne);
            this.AppetizersPanel.Controls.Add(this.addAll);
            this.AppetizersPanel.Controls.Add(this.allToppings);
            this.AppetizersPanel.Controls.Add(this.cancelToppings);
            this.AppetizersPanel.Controls.Add(this.saveToppings);
            this.AppetizersPanel.Location = new System.Drawing.Point(21, 73);
            this.AppetizersPanel.Name = "AppetizersPanel";
            this.AppetizersPanel.Size = new System.Drawing.Size(882, 492);
            this.AppetizersPanel.TabIndex = 37;
            this.AppetizersPanel.Visible = false;
            // 
            // toppingsError
            // 
            this.toppingsError.AutoSize = true;
            this.toppingsError.ForeColor = System.Drawing.Color.Red;
            this.toppingsError.Location = new System.Drawing.Point(200, 379);
            this.toppingsError.Name = "toppingsError";
            this.toppingsError.Size = new System.Drawing.Size(130, 13);
            this.toppingsError.TabIndex = 29;
            this.toppingsError.Text = "                                         ";
            // 
            // selectedToppings
            // 
            this.selectedToppings.FormattingEnabled = true;
            this.selectedToppings.Location = new System.Drawing.Point(593, 32);
            this.selectedToppings.Name = "selectedToppings";
            this.selectedToppings.Size = new System.Drawing.Size(171, 212);
            this.selectedToppings.TabIndex = 22;
            this.selectedToppings.SelectedIndexChanged += new System.EventHandler(this.selectedToppings_SelectedIndexChanged);
            // 
            // sauceGroup
            // 
            this.sauceGroup.Location = new System.Drawing.Point(17, 32);
            this.sauceGroup.Name = "sauceGroup";
            this.sauceGroup.Size = new System.Drawing.Size(166, 212);
            this.sauceGroup.TabIndex = 28;
            this.sauceGroup.TabStop = false;
            this.sauceGroup.Text = "Sauces";
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(484, 184);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(75, 23);
            this.removeAll.TabIndex = 26;
            this.removeAll.Text = "<<";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // removeOne
            // 
            this.removeOne.Location = new System.Drawing.Point(484, 140);
            this.removeOne.Name = "removeOne";
            this.removeOne.Size = new System.Drawing.Size(75, 23);
            this.removeOne.TabIndex = 25;
            this.removeOne.Text = "<";
            this.removeOne.UseVisualStyleBackColor = true;
            this.removeOne.Click += new System.EventHandler(this.removeOne_Click);
            // 
            // addOne
            // 
            this.addOne.Location = new System.Drawing.Point(484, 91);
            this.addOne.Name = "addOne";
            this.addOne.Size = new System.Drawing.Size(75, 23);
            this.addOne.TabIndex = 24;
            this.addOne.Text = ">";
            this.addOne.UseVisualStyleBackColor = true;
            this.addOne.Click += new System.EventHandler(this.addOne_Click);
            // 
            // addAll
            // 
            this.addAll.Location = new System.Drawing.Point(484, 49);
            this.addAll.Name = "addAll";
            this.addAll.Size = new System.Drawing.Size(75, 23);
            this.addAll.TabIndex = 23;
            this.addAll.Text = ">>";
            this.addAll.UseVisualStyleBackColor = true;
            this.addAll.Click += new System.EventHandler(this.addAll_Click);
            // 
            // allToppings
            // 
            this.allToppings.FormattingEnabled = true;
            this.allToppings.Location = new System.Drawing.Point(284, 32);
            this.allToppings.Name = "allToppings";
            this.allToppings.Size = new System.Drawing.Size(171, 212);
            this.allToppings.TabIndex = 21;
            // 
            // cancelToppings
            // 
            this.cancelToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelToppings.ForeColor = System.Drawing.Color.Red;
            this.cancelToppings.Location = new System.Drawing.Point(200, 286);
            this.cancelToppings.Name = "cancelToppings";
            this.cancelToppings.Size = new System.Drawing.Size(111, 63);
            this.cancelToppings.TabIndex = 20;
            this.cancelToppings.Text = "Cancel";
            this.cancelToppings.UseVisualStyleBackColor = true;
            this.cancelToppings.Click += new System.EventHandler(this.cancelApps_Click);
            // 
            // saveToppings
            // 
            this.saveToppings.BackColor = System.Drawing.Color.ForestGreen;
            this.saveToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToppings.ForeColor = System.Drawing.Color.White;
            this.saveToppings.Location = new System.Drawing.Point(368, 286);
            this.saveToppings.Name = "saveToppings";
            this.saveToppings.Size = new System.Drawing.Size(134, 65);
            this.saveToppings.TabIndex = 19;
            this.saveToppings.Text = "Save";
            this.saveToppings.UseVisualStyleBackColor = false;
            this.saveToppings.Click += new System.EventHandler(this.saveToppings_Click);
            // 
            // orderError
            // 
            this.orderError.AutoSize = true;
            this.orderError.ForeColor = System.Drawing.Color.Red;
            this.orderError.Location = new System.Drawing.Point(65, 30);
            this.orderError.Name = "orderError";
            this.orderError.Size = new System.Drawing.Size(139, 13);
            this.orderError.TabIndex = 41;
            this.orderError.Text = "                                            ";
            // 
            // crustGroup
            // 
            this.crustGroup.Location = new System.Drawing.Point(745, 309);
            this.crustGroup.Name = "crustGroup";
            this.crustGroup.Size = new System.Drawing.Size(164, 172);
            this.crustGroup.TabIndex = 40;
            this.crustGroup.TabStop = false;
            this.crustGroup.Text = "Crusts";
            // 
            // sizeGroup
            // 
            this.sizeGroup.Location = new System.Drawing.Point(745, 92);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(164, 198);
            this.sizeGroup.TabIndex = 39;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Sizes";
            // 
            // appetizersButton
            // 
            this.appetizersButton.BackColor = System.Drawing.Color.ForestGreen;
            this.appetizersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appetizersButton.ForeColor = System.Drawing.Color.White;
            this.appetizersButton.Location = new System.Drawing.Point(745, 495);
            this.appetizersButton.Name = "appetizersButton";
            this.appetizersButton.Size = new System.Drawing.Size(134, 65);
            this.appetizersButton.TabIndex = 18;
            this.appetizersButton.Text = "Select";
            this.appetizersButton.UseVisualStyleBackColor = false;
            this.appetizersButton.Click += new System.EventHandler(this.appetizersButton_Click);
            // 
            // pizzaGroup
            // 
            this.pizzaGroup.Location = new System.Drawing.Point(21, 63);
            this.pizzaGroup.Name = "pizzaGroup";
            this.pizzaGroup.Size = new System.Drawing.Size(703, 508);
            this.pizzaGroup.TabIndex = 38;
            this.pizzaGroup.TabStop = false;
            this.pizzaGroup.Text = "Pizza Selections";
            // 
            // shoppingCart1
            // 
            this.shoppingCart1.AutoSize = true;
            this.shoppingCart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCart1.Location = new System.Drawing.Point(660, 21);
            this.shoppingCart1.Name = "shoppingCart1";
            this.shoppingCart1.Size = new System.Drawing.Size(151, 26);
            this.shoppingCart1.TabIndex = 16;
            this.shoppingCart1.TabStop = true;
            this.shoppingCart1.Text = "Shopping Cart";
            // 
            // logoutButton1
            // 
            this.logoutButton1.BackColor = System.Drawing.Color.Red;
            this.logoutButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton1.ForeColor = System.Drawing.Color.White;
            this.logoutButton1.Location = new System.Drawing.Point(817, 6);
            this.logoutButton1.Name = "logoutButton1";
            this.logoutButton1.Size = new System.Drawing.Size(109, 61);
            this.logoutButton1.TabIndex = 15;
            this.logoutButton1.Text = "Logout";
            this.logoutButton1.UseVisualStyleBackColor = false;
            this.logoutButton1.Click += new System.EventHandler(this.logoutButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.orderHistory);
            this.tabPage2.Controls.Add(this.shoppingCart2);
            this.tabPage2.Controls.Add(this.logoutButton2);
            this.tabPage2.Location = new System.Drawing.Point(4, 52);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // orderHistory
            // 
            this.orderHistory.Location = new System.Drawing.Point(50, 85);
            this.orderHistory.Name = "orderHistory";
            this.orderHistory.Size = new System.Drawing.Size(824, 456);
            this.orderHistory.TabIndex = 18;
            this.orderHistory.TabStop = false;
            this.orderHistory.Text = "Order History";
            // 
            // shoppingCart2
            // 
            this.shoppingCart2.AutoSize = true;
            this.shoppingCart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCart2.Location = new System.Drawing.Point(655, 21);
            this.shoppingCart2.Name = "shoppingCart2";
            this.shoppingCart2.Size = new System.Drawing.Size(151, 26);
            this.shoppingCart2.TabIndex = 17;
            this.shoppingCart2.TabStop = true;
            this.shoppingCart2.Text = "Shopping Cart";
            // 
            // logoutButton2
            // 
            this.logoutButton2.BackColor = System.Drawing.Color.Red;
            this.logoutButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton2.ForeColor = System.Drawing.Color.White;
            this.logoutButton2.Location = new System.Drawing.Point(812, 6);
            this.logoutButton2.Name = "logoutButton2";
            this.logoutButton2.Size = new System.Drawing.Size(109, 61);
            this.logoutButton2.TabIndex = 15;
            this.logoutButton2.Text = "Logout";
            this.logoutButton2.UseVisualStyleBackColor = false;
            this.logoutButton2.Click += new System.EventHandler(this.logoutButton2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.infoError);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cancelInfo);
            this.tabPage3.Controls.Add(this.updateInfo);
            this.tabPage3.Controls.Add(this.infoPassword2);
            this.tabPage3.Controls.Add(this.infoPassword1);
            this.tabPage3.Controls.Add(this.infoUsername);
            this.tabPage3.Controls.Add(this.infoEmail);
            this.tabPage3.Controls.Add(this.infoPhone);
            this.tabPage3.Controls.Add(this.infoState);
            this.tabPage3.Controls.Add(this.infoCity);
            this.tabPage3.Controls.Add(this.infoAddress);
            this.tabPage3.Controls.Add(this.infoLastName);
            this.tabPage3.Controls.Add(this.infoMiddleName);
            this.tabPage3.Controls.Add(this.infoFirstName);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.shoppingCart3);
            this.tabPage3.Controls.Add(this.logoutButton3);
            this.tabPage3.Location = new System.Drawing.Point(4, 52);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(929, 579);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Account Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // infoError
            // 
            this.infoError.AutoSize = true;
            this.infoError.ForeColor = System.Drawing.Color.Red;
            this.infoError.Location = new System.Drawing.Point(621, 190);
            this.infoError.Name = "infoError";
            this.infoError.Size = new System.Drawing.Size(106, 13);
            this.infoError.TabIndex = 44;
            this.infoError.Text = "                                 ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label19.Location = new System.Drawing.Point(268, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(204, 29);
            this.label19.TabIndex = 43;
            this.label19.Text = "Login Information:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(164, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(418, 51);
            this.label12.TabIndex = 42;
            this.label12.Text = "Account Information:";
            // 
            // cancelInfo
            // 
            this.cancelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelInfo.ForeColor = System.Drawing.Color.Red;
            this.cancelInfo.Location = new System.Drawing.Point(187, 382);
            this.cancelInfo.Name = "cancelInfo";
            this.cancelInfo.Size = new System.Drawing.Size(150, 84);
            this.cancelInfo.TabIndex = 41;
            this.cancelInfo.Text = "Cancel";
            this.cancelInfo.UseVisualStyleBackColor = true;
            this.cancelInfo.Click += new System.EventHandler(this.cancelInfo_Click);
            // 
            // updateInfo
            // 
            this.updateInfo.BackColor = System.Drawing.Color.ForestGreen;
            this.updateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateInfo.ForeColor = System.Drawing.Color.White;
            this.updateInfo.Location = new System.Drawing.Point(404, 382);
            this.updateInfo.Name = "updateInfo";
            this.updateInfo.Size = new System.Drawing.Size(169, 84);
            this.updateInfo.TabIndex = 40;
            this.updateInfo.Text = "Update!";
            this.updateInfo.UseVisualStyleBackColor = false;
            this.updateInfo.Click += new System.EventHandler(this.updateInfo_Click);
            // 
            // infoPassword2
            // 
            this.infoPassword2.Location = new System.Drawing.Point(187, 356);
            this.infoPassword2.Name = "infoPassword2";
            this.infoPassword2.Size = new System.Drawing.Size(386, 20);
            this.infoPassword2.TabIndex = 39;
            this.infoPassword2.UseSystemPasswordChar = true;
            // 
            // infoPassword1
            // 
            this.infoPassword1.Location = new System.Drawing.Point(187, 322);
            this.infoPassword1.Name = "infoPassword1";
            this.infoPassword1.Size = new System.Drawing.Size(386, 20);
            this.infoPassword1.TabIndex = 38;
            this.infoPassword1.UseSystemPasswordChar = true;
            // 
            // infoUsername
            // 
            this.infoUsername.Enabled = false;
            this.infoUsername.Location = new System.Drawing.Point(187, 288);
            this.infoUsername.Name = "infoUsername";
            this.infoUsername.Size = new System.Drawing.Size(386, 20);
            this.infoUsername.TabIndex = 37;
            // 
            // infoEmail
            // 
            this.infoEmail.Location = new System.Drawing.Point(421, 222);
            this.infoEmail.Name = "infoEmail";
            this.infoEmail.Size = new System.Drawing.Size(161, 20);
            this.infoEmail.TabIndex = 36;
            // 
            // infoPhone
            // 
            this.infoPhone.Location = new System.Drawing.Point(187, 222);
            this.infoPhone.Name = "infoPhone";
            this.infoPhone.Size = new System.Drawing.Size(161, 20);
            this.infoPhone.TabIndex = 35;
            // 
            // infoState
            // 
            this.infoState.Location = new System.Drawing.Point(526, 190);
            this.infoState.Name = "infoState";
            this.infoState.Size = new System.Drawing.Size(47, 20);
            this.infoState.TabIndex = 34;
            // 
            // infoCity
            // 
            this.infoCity.Location = new System.Drawing.Point(187, 192);
            this.infoCity.Name = "infoCity";
            this.infoCity.Size = new System.Drawing.Size(268, 20);
            this.infoCity.TabIndex = 33;
            // 
            // infoAddress
            // 
            this.infoAddress.Location = new System.Drawing.Point(187, 158);
            this.infoAddress.Name = "infoAddress";
            this.infoAddress.Size = new System.Drawing.Size(386, 20);
            this.infoAddress.TabIndex = 32;
            // 
            // infoLastName
            // 
            this.infoLastName.Location = new System.Drawing.Point(187, 125);
            this.infoLastName.Name = "infoLastName";
            this.infoLastName.Size = new System.Drawing.Size(386, 20);
            this.infoLastName.TabIndex = 31;
            // 
            // infoMiddleName
            // 
            this.infoMiddleName.Location = new System.Drawing.Point(526, 89);
            this.infoMiddleName.Name = "infoMiddleName";
            this.infoMiddleName.Size = new System.Drawing.Size(47, 20);
            this.infoMiddleName.TabIndex = 30;
            // 
            // infoFirstName
            // 
            this.infoFirstName.Location = new System.Drawing.Point(187, 89);
            this.infoFirstName.Name = "infoFirstName";
            this.infoFirstName.Size = new System.Drawing.Size(268, 20);
            this.infoFirstName.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(137, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "First:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(461, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Middle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(137, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Last:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(94, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(99, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(40, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(109, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(142, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(468, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "State:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(363, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(122, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone:";
            // 
            // shoppingCart3
            // 
            this.shoppingCart3.AutoSize = true;
            this.shoppingCart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCart3.Location = new System.Drawing.Point(655, 21);
            this.shoppingCart3.Name = "shoppingCart3";
            this.shoppingCart3.Size = new System.Drawing.Size(151, 26);
            this.shoppingCart3.TabIndex = 17;
            this.shoppingCart3.TabStop = true;
            this.shoppingCart3.Text = "Shopping Cart";
            // 
            // logoutButton3
            // 
            this.logoutButton3.BackColor = System.Drawing.Color.Red;
            this.logoutButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton3.ForeColor = System.Drawing.Color.White;
            this.logoutButton3.Location = new System.Drawing.Point(812, 6);
            this.logoutButton3.Name = "logoutButton3";
            this.logoutButton3.Size = new System.Drawing.Size(109, 61);
            this.logoutButton3.TabIndex = 14;
            this.logoutButton3.Text = "Logout";
            this.logoutButton3.UseVisualStyleBackColor = false;
            this.logoutButton3.Click += new System.EventHandler(this.logoutButton3_Click);
            // 
            // outOfStock
            // 
            this.outOfStock.Location = new System.Drawing.Point(593, 275);
            this.outOfStock.Name = "outOfStock";
            this.outOfStock.Size = new System.Drawing.Size(171, 189);
            this.outOfStock.TabIndex = 30;
            this.outOfStock.TabStop = false;
            this.outOfStock.Text = "Out Of Stock";
            // 
            // AnchovyCustomerMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 638);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnchovyCustomerMainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AppetizersPanel.ResumeLayout(false);
            this.AppetizersPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel shoppingCart1;
        private System.Windows.Forms.Button logoutButton1;
        private System.Windows.Forms.Button logoutButton2;
        private System.Windows.Forms.Button logoutButton3;
        private System.Windows.Forms.LinkLabel shoppingCart2;
        private System.Windows.Forms.LinkLabel shoppingCart3;
        private System.Windows.Forms.Button appetizersButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox infoPassword2;
        private System.Windows.Forms.TextBox infoPassword1;
        private System.Windows.Forms.TextBox infoUsername;
        private System.Windows.Forms.TextBox infoEmail;
        private System.Windows.Forms.TextBox infoPhone;
        private System.Windows.Forms.TextBox infoState;
        private System.Windows.Forms.TextBox infoCity;
        private System.Windows.Forms.TextBox infoAddress;
        private System.Windows.Forms.TextBox infoLastName;
        private System.Windows.Forms.TextBox infoMiddleName;
        private System.Windows.Forms.TextBox infoFirstName;
        private System.Windows.Forms.Button updateInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel AppetizersPanel;
        private System.Windows.Forms.Button saveToppings;
        private System.Windows.Forms.Button cancelToppings;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label infoError;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button removeOne;
        private System.Windows.Forms.Button addOne;
        private System.Windows.Forms.Button addAll;
        private System.Windows.Forms.ListBox selectedToppings;
        private System.Windows.Forms.ListBox allToppings;
        private System.Windows.Forms.Button cancelInfo;
        private System.Windows.Forms.GroupBox sauceGroup;
        private System.Windows.Forms.GroupBox pizzaGroup;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.GroupBox crustGroup;
        private System.Windows.Forms.GroupBox orderHistory;
        private System.Windows.Forms.Label orderError;
        private System.Windows.Forms.Label toppingsError;
        private System.Windows.Forms.GroupBox outOfStock;
    }
}

