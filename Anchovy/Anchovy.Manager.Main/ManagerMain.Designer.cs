namespace Anchovy.Manager.Main
{
    partial class ManagerMain
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ManagersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AnchovyContextDataSet = new Anchovy.Manager.Main.AnchovyContextDataSet();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.btnRefreshSales = new System.Windows.Forms.Button();
            this.lblMonthlyAveragesValue = new System.Windows.Forms.Label();
            this.lbllblWeeklyAveragesValue = new System.Windows.Forms.Label();
            this.lblDailyAveragesValue = new System.Windows.Forms.Label();
            this.lblMonthlyAverages = new System.Windows.Forms.Label();
            this.lblWeeklyAverages = new System.Windows.Forms.Label();
            this.lblDailyAverages = new System.Windows.Forms.Label();
            this.lblMonthlySalesValue = new System.Windows.Forms.Label();
            this.lblWeeklySalesValue = new System.Windows.Forms.Label();
            this.lblDailySalesValue = new System.Windows.Forms.Label();
            this.lblMonthlySales = new System.Windows.Forms.Label();
            this.lblWeeklySales = new System.Windows.Forms.Label();
            this.lblDailySales = new System.Windows.Forms.Label();
            this.lblAverageSales = new System.Windows.Forms.Label();
            this.lblCurrentSales = new System.Windows.Forms.Label();
            this.tabPageCooks = new System.Windows.Forms.TabPage();
            this.btnAddNewCook = new System.Windows.Forms.Button();
            this.lblCookPieceWrkError = new System.Windows.Forms.Label();
            this.lblCookHourError = new System.Windows.Forms.Label();
            this.btnCookSave = new System.Windows.Forms.Button();
            this.btnCookEdit = new System.Windows.Forms.Button();
            this.txtCookPieceWorkRate = new System.Windows.Forms.TextBox();
            this.txtCookHourlyWage = new System.Windows.Forms.TextBox();
            this.txtCookPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCookEmail = new System.Windows.Forms.TextBox();
            this.txtCookState = new System.Windows.Forms.TextBox();
            this.txtCookCity = new System.Windows.Forms.TextBox();
            this.txtCookAddress = new System.Windows.Forms.TextBox();
            this.txtCookPassword = new System.Windows.Forms.TextBox();
            this.txtCookUsername = new System.Windows.Forms.TextBox();
            this.txtCookLastName = new System.Windows.Forms.TextBox();
            this.txtCookMiddleName = new System.Windows.Forms.TextBox();
            this.txtCookFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCookMiddleName = new System.Windows.Forms.Label();
            this.lblCookFirstName = new System.Windows.Forms.Label();
            this.comboCooks = new System.Windows.Forms.ComboBox();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.comboReports = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPageManagers = new System.Windows.Forms.TabPage();
            this.lblManagerIdValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewManager = new System.Windows.Forms.Button();
            this.lblManagerSalaryError = new System.Windows.Forms.Label();
            this.btnManagerSave = new System.Windows.Forms.Button();
            this.btnManagerEdit = new System.Windows.Forms.Button();
            this.txtManagerSalary = new System.Windows.Forms.TextBox();
            this.txtManagerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtManagerEmail = new System.Windows.Forms.TextBox();
            this.txtManagerState = new System.Windows.Forms.TextBox();
            this.txtManagerCity = new System.Windows.Forms.TextBox();
            this.txtManagerAddress = new System.Windows.Forms.TextBox();
            this.txtManagerPwd = new System.Windows.Forms.TextBox();
            this.txtManagerUName = new System.Windows.Forms.TextBox();
            this.txtManagerLName = new System.Windows.Forms.TextBox();
            this.txtManagerMName = new System.Windows.Forms.TextBox();
            this.txtManagerFName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboManager = new System.Windows.Forms.ComboBox();
            this.btnManLogout = new System.Windows.Forms.Button();
            this.ManagersTableAdapter = new Anchovy.Manager.Main.AnchovyContextDataSetTableAdapters.ManagersTableAdapter();
            this.anchovyContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstBoxInventory = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtInventoryName = new System.Windows.Forms.TextBox();
            this.txtInventoryCost = new System.Windows.Forms.TextBox();
            this.txtInventoryQuantity = new System.Windows.Forms.TextBox();
            this.txtInventoryLowLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnchovyContextDataSet)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            this.tabPageCooks.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            this.tabPageManagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anchovyContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagersBindingSource
            // 
            this.ManagersBindingSource.DataMember = "Managers";
            this.ManagersBindingSource.DataSource = this.AnchovyContextDataSet;
            // 
            // AnchovyContextDataSet
            // 
            this.AnchovyContextDataSet.DataSetName = "AnchovyContextDataSet";
            this.AnchovyContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInventory);
            this.tabControl.Controls.Add(this.tabPageSales);
            this.tabControl.Controls.Add(this.tabPageCooks);
            this.tabControl.Controls.Add(this.tabPageManagers);
            this.tabControl.Controls.Add(this.tabPageReports);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 34);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1760, 804);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.txtInventoryLowLevel);
            this.tabPageInventory.Controls.Add(this.txtInventoryQuantity);
            this.tabPageInventory.Controls.Add(this.txtInventoryCost);
            this.tabPageInventory.Controls.Add(this.txtInventoryName);
            this.tabPageInventory.Controls.Add(this.label28);
            this.tabPageInventory.Controls.Add(this.label27);
            this.tabPageInventory.Controls.Add(this.label26);
            this.tabPageInventory.Controls.Add(this.label25);
            this.tabPageInventory.Controls.Add(this.label13);
            this.tabPageInventory.Controls.Add(this.label12);
            this.tabPageInventory.Controls.Add(this.lstBoxInventory);
            this.tabPageInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInventory.Location = new System.Drawing.Point(4, 46);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(1752, 754);
            this.tabPageInventory.TabIndex = 0;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.btnRefreshSales);
            this.tabPageSales.Controls.Add(this.lblMonthlyAveragesValue);
            this.tabPageSales.Controls.Add(this.lbllblWeeklyAveragesValue);
            this.tabPageSales.Controls.Add(this.lblDailyAveragesValue);
            this.tabPageSales.Controls.Add(this.lblMonthlyAverages);
            this.tabPageSales.Controls.Add(this.lblWeeklyAverages);
            this.tabPageSales.Controls.Add(this.lblDailyAverages);
            this.tabPageSales.Controls.Add(this.lblMonthlySalesValue);
            this.tabPageSales.Controls.Add(this.lblWeeklySalesValue);
            this.tabPageSales.Controls.Add(this.lblDailySalesValue);
            this.tabPageSales.Controls.Add(this.lblMonthlySales);
            this.tabPageSales.Controls.Add(this.lblWeeklySales);
            this.tabPageSales.Controls.Add(this.lblDailySales);
            this.tabPageSales.Controls.Add(this.lblAverageSales);
            this.tabPageSales.Controls.Add(this.lblCurrentSales);
            this.tabPageSales.Location = new System.Drawing.Point(4, 46);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(1752, 754);
            this.tabPageSales.TabIndex = 1;
            this.tabPageSales.Text = "Sales";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSales
            // 
            this.btnRefreshSales.Location = new System.Drawing.Point(678, 638);
            this.btnRefreshSales.Name = "btnRefreshSales";
            this.btnRefreshSales.Size = new System.Drawing.Size(211, 83);
            this.btnRefreshSales.TabIndex = 23;
            this.btnRefreshSales.Text = "Refresh";
            this.btnRefreshSales.UseVisualStyleBackColor = true;
            this.btnRefreshSales.Click += new System.EventHandler(this.btnRefreshSales_Click);
            // 
            // lblMonthlyAveragesValue
            // 
            this.lblMonthlyAveragesValue.AutoSize = true;
            this.lblMonthlyAveragesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAveragesValue.Location = new System.Drawing.Point(1301, 587);
            this.lblMonthlyAveragesValue.Name = "lblMonthlyAveragesValue";
            this.lblMonthlyAveragesValue.Size = new System.Drawing.Size(185, 37);
            this.lblMonthlyAveragesValue.TabIndex = 22;
            this.lblMonthlyAveragesValue.Text = "$14,123.90";
            // 
            // lbllblWeeklyAveragesValue
            // 
            this.lbllblWeeklyAveragesValue.AutoSize = true;
            this.lbllblWeeklyAveragesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblWeeklyAveragesValue.Location = new System.Drawing.Point(1301, 377);
            this.lbllblWeeklyAveragesValue.Name = "lbllblWeeklyAveragesValue";
            this.lbllblWeeklyAveragesValue.Size = new System.Drawing.Size(168, 37);
            this.lbllblWeeklyAveragesValue.TabIndex = 21;
            this.lbllblWeeklyAveragesValue.Text = "$3,345.12";
            // 
            // lblDailyAveragesValue
            // 
            this.lblDailyAveragesValue.AutoSize = true;
            this.lblDailyAveragesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyAveragesValue.Location = new System.Drawing.Point(1301, 196);
            this.lblDailyAveragesValue.Name = "lblDailyAveragesValue";
            this.lblDailyAveragesValue.Size = new System.Drawing.Size(141, 37);
            this.lblDailyAveragesValue.TabIndex = 20;
            this.lblDailyAveragesValue.Text = "$398.55";
            // 
            // lblMonthlyAverages
            // 
            this.lblMonthlyAverages.AutoSize = true;
            this.lblMonthlyAverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAverages.Location = new System.Drawing.Point(929, 587);
            this.lblMonthlyAverages.Name = "lblMonthlyAverages";
            this.lblMonthlyAverages.Size = new System.Drawing.Size(287, 37);
            this.lblMonthlyAverages.TabIndex = 19;
            this.lblMonthlyAverages.Text = "Monthly Averages";
            // 
            // lblWeeklyAverages
            // 
            this.lblWeeklyAverages.AutoSize = true;
            this.lblWeeklyAverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyAverages.Location = new System.Drawing.Point(929, 377);
            this.lblWeeklyAverages.Name = "lblWeeklyAverages";
            this.lblWeeklyAverages.Size = new System.Drawing.Size(278, 37);
            this.lblWeeklyAverages.TabIndex = 18;
            this.lblWeeklyAverages.Text = "Weekly Averages";
            // 
            // lblDailyAverages
            // 
            this.lblDailyAverages.AutoSize = true;
            this.lblDailyAverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyAverages.Location = new System.Drawing.Point(929, 196);
            this.lblDailyAverages.Name = "lblDailyAverages";
            this.lblDailyAverages.Size = new System.Drawing.Size(244, 37);
            this.lblDailyAverages.TabIndex = 17;
            this.lblDailyAverages.Text = "Daily Averages";
            // 
            // lblMonthlySalesValue
            // 
            this.lblMonthlySalesValue.AutoSize = true;
            this.lblMonthlySalesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySalesValue.Location = new System.Drawing.Point(447, 587);
            this.lblMonthlySalesValue.Name = "lblMonthlySalesValue";
            this.lblMonthlySalesValue.Size = new System.Drawing.Size(187, 37);
            this.lblMonthlySalesValue.TabIndex = 16;
            this.lblMonthlySalesValue.Text = "$15,458.52";
            // 
            // lblWeeklySalesValue
            // 
            this.lblWeeklySalesValue.AutoSize = true;
            this.lblWeeklySalesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklySalesValue.Location = new System.Drawing.Point(447, 377);
            this.lblWeeklySalesValue.Name = "lblWeeklySalesValue";
            this.lblWeeklySalesValue.Size = new System.Drawing.Size(170, 37);
            this.lblWeeklySalesValue.TabIndex = 15;
            this.lblWeeklySalesValue.Text = "$3,679.34";
            // 
            // lblDailySalesValue
            // 
            this.lblDailySalesValue.AutoSize = true;
            this.lblDailySalesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailySalesValue.Location = new System.Drawing.Point(447, 196);
            this.lblDailySalesValue.Name = "lblDailySalesValue";
            this.lblDailySalesValue.Size = new System.Drawing.Size(139, 37);
            this.lblDailySalesValue.TabIndex = 14;
            this.lblDailySalesValue.Text = "$421.76";
            // 
            // lblMonthlySales
            // 
            this.lblMonthlySales.AutoSize = true;
            this.lblMonthlySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlySales.Location = new System.Drawing.Point(75, 587);
            this.lblMonthlySales.Name = "lblMonthlySales";
            this.lblMonthlySales.Size = new System.Drawing.Size(229, 37);
            this.lblMonthlySales.TabIndex = 13;
            this.lblMonthlySales.Text = "Monthly Sales";
            // 
            // lblWeeklySales
            // 
            this.lblWeeklySales.AutoSize = true;
            this.lblWeeklySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklySales.Location = new System.Drawing.Point(75, 377);
            this.lblWeeklySales.Name = "lblWeeklySales";
            this.lblWeeklySales.Size = new System.Drawing.Size(220, 37);
            this.lblWeeklySales.TabIndex = 12;
            this.lblWeeklySales.Text = "Weekly Sales";
            // 
            // lblDailySales
            // 
            this.lblDailySales.AutoSize = true;
            this.lblDailySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailySales.Location = new System.Drawing.Point(75, 196);
            this.lblDailySales.Name = "lblDailySales";
            this.lblDailySales.Size = new System.Drawing.Size(186, 37);
            this.lblDailySales.TabIndex = 11;
            this.lblDailySales.Text = "Daily Sales";
            // 
            // lblAverageSales
            // 
            this.lblAverageSales.AutoSize = true;
            this.lblAverageSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageSales.Location = new System.Drawing.Point(1002, 59);
            this.lblAverageSales.Name = "lblAverageSales";
            this.lblAverageSales.Size = new System.Drawing.Size(364, 55);
            this.lblAverageSales.TabIndex = 10;
            this.lblAverageSales.Text = "Average Sales ";
            // 
            // lblCurrentSales
            // 
            this.lblCurrentSales.AutoSize = true;
            this.lblCurrentSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSales.Location = new System.Drawing.Point(217, 59);
            this.lblCurrentSales.Name = "lblCurrentSales";
            this.lblCurrentSales.Size = new System.Drawing.Size(345, 55);
            this.lblCurrentSales.TabIndex = 9;
            this.lblCurrentSales.Text = "Current Sales ";
            // 
            // tabPageCooks
            // 
            this.tabPageCooks.Controls.Add(this.btnAddNewCook);
            this.tabPageCooks.Controls.Add(this.lblCookPieceWrkError);
            this.tabPageCooks.Controls.Add(this.lblCookHourError);
            this.tabPageCooks.Controls.Add(this.btnCookSave);
            this.tabPageCooks.Controls.Add(this.btnCookEdit);
            this.tabPageCooks.Controls.Add(this.txtCookPieceWorkRate);
            this.tabPageCooks.Controls.Add(this.txtCookHourlyWage);
            this.tabPageCooks.Controls.Add(this.txtCookPhoneNumber);
            this.tabPageCooks.Controls.Add(this.txtCookEmail);
            this.tabPageCooks.Controls.Add(this.txtCookState);
            this.tabPageCooks.Controls.Add(this.txtCookCity);
            this.tabPageCooks.Controls.Add(this.txtCookAddress);
            this.tabPageCooks.Controls.Add(this.txtCookPassword);
            this.tabPageCooks.Controls.Add(this.txtCookUsername);
            this.tabPageCooks.Controls.Add(this.txtCookLastName);
            this.tabPageCooks.Controls.Add(this.txtCookMiddleName);
            this.tabPageCooks.Controls.Add(this.txtCookFirstName);
            this.tabPageCooks.Controls.Add(this.label4);
            this.tabPageCooks.Controls.Add(this.label5);
            this.tabPageCooks.Controls.Add(this.label8);
            this.tabPageCooks.Controls.Add(this.label9);
            this.tabPageCooks.Controls.Add(this.label10);
            this.tabPageCooks.Controls.Add(this.label11);
            this.tabPageCooks.Controls.Add(this.label6);
            this.tabPageCooks.Controls.Add(this.label7);
            this.tabPageCooks.Controls.Add(this.label2);
            this.tabPageCooks.Controls.Add(this.label3);
            this.tabPageCooks.Controls.Add(this.lblCookMiddleName);
            this.tabPageCooks.Controls.Add(this.lblCookFirstName);
            this.tabPageCooks.Controls.Add(this.comboCooks);
            this.tabPageCooks.Location = new System.Drawing.Point(4, 46);
            this.tabPageCooks.Name = "tabPageCooks";
            this.tabPageCooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCooks.Size = new System.Drawing.Size(1752, 754);
            this.tabPageCooks.TabIndex = 2;
            this.tabPageCooks.Text = "Cooks";
            this.tabPageCooks.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCook
            // 
            this.btnAddNewCook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCook.Location = new System.Drawing.Point(1399, 23);
            this.btnAddNewCook.Name = "btnAddNewCook";
            this.btnAddNewCook.Size = new System.Drawing.Size(322, 63);
            this.btnAddNewCook.TabIndex = 40;
            this.btnAddNewCook.Text = "Add New Cook";
            this.btnAddNewCook.UseVisualStyleBackColor = true;
            this.btnAddNewCook.Click += new System.EventHandler(this.btnAddNewCook_Click);
            // 
            // lblCookPieceWrkError
            // 
            this.lblCookPieceWrkError.AutoSize = true;
            this.lblCookPieceWrkError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookPieceWrkError.ForeColor = System.Drawing.Color.Red;
            this.lblCookPieceWrkError.Location = new System.Drawing.Point(1366, 695);
            this.lblCookPieceWrkError.Name = "lblCookPieceWrkError";
            this.lblCookPieceWrkError.Size = new System.Drawing.Size(317, 29);
            this.lblCookPieceWrkError.TabIndex = 39;
            this.lblCookPieceWrkError.Text = "Please enter a valid Number";
            this.lblCookPieceWrkError.Visible = false;
            // 
            // lblCookHourError
            // 
            this.lblCookHourError.AutoSize = true;
            this.lblCookHourError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookHourError.ForeColor = System.Drawing.Color.Red;
            this.lblCookHourError.Location = new System.Drawing.Point(1366, 582);
            this.lblCookHourError.Name = "lblCookHourError";
            this.lblCookHourError.Size = new System.Drawing.Size(317, 29);
            this.lblCookHourError.TabIndex = 38;
            this.lblCookHourError.Text = "Please enter a valid Number";
            this.lblCookHourError.Visible = false;
            // 
            // btnCookSave
            // 
            this.btnCookSave.BackColor = System.Drawing.Color.Green;
            this.btnCookSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCookSave.Location = new System.Drawing.Point(1507, 407);
            this.btnCookSave.Name = "btnCookSave";
            this.btnCookSave.Size = new System.Drawing.Size(153, 63);
            this.btnCookSave.TabIndex = 37;
            this.btnCookSave.Text = "Save";
            this.btnCookSave.UseVisualStyleBackColor = false;
            this.btnCookSave.Click += new System.EventHandler(this.btnCookSave_Click);
            // 
            // btnCookEdit
            // 
            this.btnCookEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCookEdit.Location = new System.Drawing.Point(1507, 331);
            this.btnCookEdit.Name = "btnCookEdit";
            this.btnCookEdit.Size = new System.Drawing.Size(153, 63);
            this.btnCookEdit.TabIndex = 36;
            this.btnCookEdit.Text = "Edit";
            this.btnCookEdit.UseVisualStyleBackColor = true;
            this.btnCookEdit.Click += new System.EventHandler(this.btnCookEdit_Click);
            // 
            // txtCookPieceWorkRate
            // 
            this.txtCookPieceWorkRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookPieceWorkRate.Location = new System.Drawing.Point(978, 686);
            this.txtCookPieceWorkRate.Name = "txtCookPieceWorkRate";
            this.txtCookPieceWorkRate.ReadOnly = true;
            this.txtCookPieceWorkRate.Size = new System.Drawing.Size(369, 44);
            this.txtCookPieceWorkRate.TabIndex = 35;
            // 
            // txtCookHourlyWage
            // 
            this.txtCookHourlyWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookHourlyWage.Location = new System.Drawing.Point(978, 579);
            this.txtCookHourlyWage.Name = "txtCookHourlyWage";
            this.txtCookHourlyWage.ReadOnly = true;
            this.txtCookHourlyWage.Size = new System.Drawing.Size(369, 44);
            this.txtCookHourlyWage.TabIndex = 34;
            // 
            // txtCookPhoneNumber
            // 
            this.txtCookPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookPhoneNumber.Location = new System.Drawing.Point(978, 475);
            this.txtCookPhoneNumber.Name = "txtCookPhoneNumber";
            this.txtCookPhoneNumber.ReadOnly = true;
            this.txtCookPhoneNumber.Size = new System.Drawing.Size(369, 44);
            this.txtCookPhoneNumber.TabIndex = 33;
            // 
            // txtCookEmail
            // 
            this.txtCookEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookEmail.Location = new System.Drawing.Point(978, 354);
            this.txtCookEmail.Name = "txtCookEmail";
            this.txtCookEmail.ReadOnly = true;
            this.txtCookEmail.Size = new System.Drawing.Size(369, 44);
            this.txtCookEmail.TabIndex = 32;
            // 
            // txtCookState
            // 
            this.txtCookState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookState.Location = new System.Drawing.Point(978, 240);
            this.txtCookState.Name = "txtCookState";
            this.txtCookState.ReadOnly = true;
            this.txtCookState.Size = new System.Drawing.Size(369, 44);
            this.txtCookState.TabIndex = 31;
            // 
            // txtCookCity
            // 
            this.txtCookCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookCity.Location = new System.Drawing.Point(978, 119);
            this.txtCookCity.Name = "txtCookCity";
            this.txtCookCity.ReadOnly = true;
            this.txtCookCity.Size = new System.Drawing.Size(369, 44);
            this.txtCookCity.TabIndex = 30;
            // 
            // txtCookAddress
            // 
            this.txtCookAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookAddress.Location = new System.Drawing.Point(272, 686);
            this.txtCookAddress.Name = "txtCookAddress";
            this.txtCookAddress.ReadOnly = true;
            this.txtCookAddress.Size = new System.Drawing.Size(369, 44);
            this.txtCookAddress.TabIndex = 29;
            // 
            // txtCookPassword
            // 
            this.txtCookPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookPassword.Location = new System.Drawing.Point(272, 579);
            this.txtCookPassword.Name = "txtCookPassword";
            this.txtCookPassword.ReadOnly = true;
            this.txtCookPassword.Size = new System.Drawing.Size(369, 44);
            this.txtCookPassword.TabIndex = 28;
            // 
            // txtCookUsername
            // 
            this.txtCookUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookUsername.Location = new System.Drawing.Point(272, 475);
            this.txtCookUsername.Name = "txtCookUsername";
            this.txtCookUsername.ReadOnly = true;
            this.txtCookUsername.Size = new System.Drawing.Size(369, 44);
            this.txtCookUsername.TabIndex = 27;
            // 
            // txtCookLastName
            // 
            this.txtCookLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookLastName.Location = new System.Drawing.Point(272, 354);
            this.txtCookLastName.Name = "txtCookLastName";
            this.txtCookLastName.ReadOnly = true;
            this.txtCookLastName.Size = new System.Drawing.Size(369, 44);
            this.txtCookLastName.TabIndex = 26;
            // 
            // txtCookMiddleName
            // 
            this.txtCookMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookMiddleName.Location = new System.Drawing.Point(272, 240);
            this.txtCookMiddleName.Name = "txtCookMiddleName";
            this.txtCookMiddleName.ReadOnly = true;
            this.txtCookMiddleName.Size = new System.Drawing.Size(369, 44);
            this.txtCookMiddleName.TabIndex = 25;
            // 
            // txtCookFirstName
            // 
            this.txtCookFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCookFirstName.Location = new System.Drawing.Point(272, 119);
            this.txtCookFirstName.Name = "txtCookFirstName";
            this.txtCookFirstName.ReadOnly = true;
            this.txtCookFirstName.Size = new System.Drawing.Size(369, 44);
            this.txtCookFirstName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 689);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Piece Work Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hourly Wage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(671, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 37);
            this.label8.TabIndex = 21;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(671, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 37);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(671, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(671, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 37);
            this.label11.TabIndex = 18;
            this.label11.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 689);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name";
            // 
            // lblCookMiddleName
            // 
            this.lblCookMiddleName.AutoSize = true;
            this.lblCookMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookMiddleName.Location = new System.Drawing.Point(29, 243);
            this.lblCookMiddleName.Name = "lblCookMiddleName";
            this.lblCookMiddleName.Size = new System.Drawing.Size(216, 37);
            this.lblCookMiddleName.TabIndex = 13;
            this.lblCookMiddleName.Text = "Middle Name";
            // 
            // lblCookFirstName
            // 
            this.lblCookFirstName.AutoSize = true;
            this.lblCookFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookFirstName.Location = new System.Drawing.Point(29, 122);
            this.lblCookFirstName.Name = "lblCookFirstName";
            this.lblCookFirstName.Size = new System.Drawing.Size(185, 37);
            this.lblCookFirstName.TabIndex = 12;
            this.lblCookFirstName.Text = "First Name";
            // 
            // comboCooks
            // 
            this.comboCooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCooks.FormattingEnabled = true;
            this.comboCooks.Location = new System.Drawing.Point(36, 41);
            this.comboCooks.Name = "comboCooks";
            this.comboCooks.Size = new System.Drawing.Size(327, 45);
            this.comboCooks.TabIndex = 2;
            this.comboCooks.Text = "Choose Cook...";
            this.comboCooks.SelectedIndexChanged += new System.EventHandler(this.comboCooks_SelectedIndexChanged);
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.btnRunReport);
            this.tabPageReports.Controls.Add(this.dateTimePickerEnd);
            this.tabPageReports.Controls.Add(this.dateTimePickerStart);
            this.tabPageReports.Controls.Add(this.lblEndDate);
            this.tabPageReports.Controls.Add(this.lblStartDate);
            this.tabPageReports.Controls.Add(this.comboReports);
            this.tabPageReports.Controls.Add(this.reportViewer1);
            this.tabPageReports.Location = new System.Drawing.Point(4, 46);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(1752, 754);
            this.tabPageReports.TabIndex = 3;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(1052, 36);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(159, 49);
            this.btnRunReport.TabIndex = 6;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(537, 64);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(509, 44);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(537, 14);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(509, 44);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(370, 64);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(150, 37);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(370, 14);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(161, 37);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // comboReports
            // 
            this.comboReports.FormattingEnabled = true;
            this.comboReports.Location = new System.Drawing.Point(20, 18);
            this.comboReports.Name = "comboReports";
            this.comboReports.Size = new System.Drawing.Size(327, 45);
            this.comboReports.TabIndex = 1;
            this.comboReports.Text = "Choose Report...";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ManagersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anchovy.Manager.Main.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1740, 627);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPageManagers
            // 
            this.tabPageManagers.Controls.Add(this.lblManagerIdValue);
            this.tabPageManagers.Controls.Add(this.label1);
            this.tabPageManagers.Controls.Add(this.btnAddNewManager);
            this.tabPageManagers.Controls.Add(this.lblManagerSalaryError);
            this.tabPageManagers.Controls.Add(this.btnManagerSave);
            this.tabPageManagers.Controls.Add(this.btnManagerEdit);
            this.tabPageManagers.Controls.Add(this.txtManagerSalary);
            this.tabPageManagers.Controls.Add(this.txtManagerPhoneNumber);
            this.tabPageManagers.Controls.Add(this.txtManagerEmail);
            this.tabPageManagers.Controls.Add(this.txtManagerState);
            this.tabPageManagers.Controls.Add(this.txtManagerCity);
            this.tabPageManagers.Controls.Add(this.txtManagerAddress);
            this.tabPageManagers.Controls.Add(this.txtManagerPwd);
            this.tabPageManagers.Controls.Add(this.txtManagerUName);
            this.tabPageManagers.Controls.Add(this.txtManagerLName);
            this.tabPageManagers.Controls.Add(this.txtManagerMName);
            this.tabPageManagers.Controls.Add(this.txtManagerFName);
            this.tabPageManagers.Controls.Add(this.label14);
            this.tabPageManagers.Controls.Add(this.label15);
            this.tabPageManagers.Controls.Add(this.label16);
            this.tabPageManagers.Controls.Add(this.label17);
            this.tabPageManagers.Controls.Add(this.label18);
            this.tabPageManagers.Controls.Add(this.label19);
            this.tabPageManagers.Controls.Add(this.label20);
            this.tabPageManagers.Controls.Add(this.label21);
            this.tabPageManagers.Controls.Add(this.label22);
            this.tabPageManagers.Controls.Add(this.label23);
            this.tabPageManagers.Controls.Add(this.label24);
            this.tabPageManagers.Controls.Add(this.comboManager);
            this.tabPageManagers.Location = new System.Drawing.Point(4, 46);
            this.tabPageManagers.Name = "tabPageManagers";
            this.tabPageManagers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagers.Size = new System.Drawing.Size(1752, 754);
            this.tabPageManagers.TabIndex = 4;
            this.tabPageManagers.Text = "Managers";
            this.tabPageManagers.UseVisualStyleBackColor = true;
            // 
            // lblManagerIdValue
            // 
            this.lblManagerIdValue.AutoSize = true;
            this.lblManagerIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerIdValue.Location = new System.Drawing.Point(972, 690);
            this.lblManagerIdValue.Name = "lblManagerIdValue";
            this.lblManagerIdValue.Size = new System.Drawing.Size(36, 37);
            this.lblManagerIdValue.TabIndex = 72;
            this.lblManagerIdValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 690);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 71;
            this.label1.Text = "Manager ID";
            // 
            // btnAddNewManager
            // 
            this.btnAddNewManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewManager.Location = new System.Drawing.Point(1400, 24);
            this.btnAddNewManager.Name = "btnAddNewManager";
            this.btnAddNewManager.Size = new System.Drawing.Size(322, 63);
            this.btnAddNewManager.TabIndex = 70;
            this.btnAddNewManager.Text = "Add New Manager";
            this.btnAddNewManager.UseVisualStyleBackColor = true;
            this.btnAddNewManager.Click += new System.EventHandler(this.btnAddNewManager_Click);
            // 
            // lblManagerSalaryError
            // 
            this.lblManagerSalaryError.AutoSize = true;
            this.lblManagerSalaryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerSalaryError.ForeColor = System.Drawing.Color.Red;
            this.lblManagerSalaryError.Location = new System.Drawing.Point(1367, 583);
            this.lblManagerSalaryError.Name = "lblManagerSalaryError";
            this.lblManagerSalaryError.Size = new System.Drawing.Size(317, 29);
            this.lblManagerSalaryError.TabIndex = 68;
            this.lblManagerSalaryError.Text = "Please enter a valid Number";
            this.lblManagerSalaryError.Visible = false;
            // 
            // btnManagerSave
            // 
            this.btnManagerSave.BackColor = System.Drawing.Color.Green;
            this.btnManagerSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerSave.Location = new System.Drawing.Point(1508, 408);
            this.btnManagerSave.Name = "btnManagerSave";
            this.btnManagerSave.Size = new System.Drawing.Size(153, 63);
            this.btnManagerSave.TabIndex = 67;
            this.btnManagerSave.Text = "Save";
            this.btnManagerSave.UseVisualStyleBackColor = false;
            this.btnManagerSave.Click += new System.EventHandler(this.btnManagerSave_Click);
            // 
            // btnManagerEdit
            // 
            this.btnManagerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerEdit.Location = new System.Drawing.Point(1508, 332);
            this.btnManagerEdit.Name = "btnManagerEdit";
            this.btnManagerEdit.Size = new System.Drawing.Size(153, 63);
            this.btnManagerEdit.TabIndex = 66;
            this.btnManagerEdit.Text = "Edit";
            this.btnManagerEdit.UseVisualStyleBackColor = true;
            this.btnManagerEdit.Click += new System.EventHandler(this.btnManagerEdit_Click);
            // 
            // txtManagerSalary
            // 
            this.txtManagerSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerSalary.Location = new System.Drawing.Point(979, 580);
            this.txtManagerSalary.Name = "txtManagerSalary";
            this.txtManagerSalary.ReadOnly = true;
            this.txtManagerSalary.Size = new System.Drawing.Size(369, 44);
            this.txtManagerSalary.TabIndex = 64;
            // 
            // txtManagerPhoneNumber
            // 
            this.txtManagerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerPhoneNumber.Location = new System.Drawing.Point(979, 476);
            this.txtManagerPhoneNumber.Name = "txtManagerPhoneNumber";
            this.txtManagerPhoneNumber.ReadOnly = true;
            this.txtManagerPhoneNumber.Size = new System.Drawing.Size(369, 44);
            this.txtManagerPhoneNumber.TabIndex = 63;
            // 
            // txtManagerEmail
            // 
            this.txtManagerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerEmail.Location = new System.Drawing.Point(979, 355);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.ReadOnly = true;
            this.txtManagerEmail.Size = new System.Drawing.Size(369, 44);
            this.txtManagerEmail.TabIndex = 62;
            // 
            // txtManagerState
            // 
            this.txtManagerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerState.Location = new System.Drawing.Point(979, 241);
            this.txtManagerState.Name = "txtManagerState";
            this.txtManagerState.ReadOnly = true;
            this.txtManagerState.Size = new System.Drawing.Size(369, 44);
            this.txtManagerState.TabIndex = 61;
            // 
            // txtManagerCity
            // 
            this.txtManagerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerCity.Location = new System.Drawing.Point(979, 120);
            this.txtManagerCity.Name = "txtManagerCity";
            this.txtManagerCity.ReadOnly = true;
            this.txtManagerCity.Size = new System.Drawing.Size(369, 44);
            this.txtManagerCity.TabIndex = 60;
            // 
            // txtManagerAddress
            // 
            this.txtManagerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerAddress.Location = new System.Drawing.Point(273, 687);
            this.txtManagerAddress.Name = "txtManagerAddress";
            this.txtManagerAddress.ReadOnly = true;
            this.txtManagerAddress.Size = new System.Drawing.Size(369, 44);
            this.txtManagerAddress.TabIndex = 59;
            // 
            // txtManagerPwd
            // 
            this.txtManagerPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerPwd.Location = new System.Drawing.Point(273, 580);
            this.txtManagerPwd.Name = "txtManagerPwd";
            this.txtManagerPwd.ReadOnly = true;
            this.txtManagerPwd.Size = new System.Drawing.Size(369, 44);
            this.txtManagerPwd.TabIndex = 58;
            // 
            // txtManagerUName
            // 
            this.txtManagerUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerUName.Location = new System.Drawing.Point(273, 476);
            this.txtManagerUName.Name = "txtManagerUName";
            this.txtManagerUName.ReadOnly = true;
            this.txtManagerUName.Size = new System.Drawing.Size(369, 44);
            this.txtManagerUName.TabIndex = 57;
            // 
            // txtManagerLName
            // 
            this.txtManagerLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerLName.Location = new System.Drawing.Point(273, 355);
            this.txtManagerLName.Name = "txtManagerLName";
            this.txtManagerLName.ReadOnly = true;
            this.txtManagerLName.Size = new System.Drawing.Size(369, 44);
            this.txtManagerLName.TabIndex = 56;
            // 
            // txtManagerMName
            // 
            this.txtManagerMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerMName.Location = new System.Drawing.Point(273, 241);
            this.txtManagerMName.Name = "txtManagerMName";
            this.txtManagerMName.ReadOnly = true;
            this.txtManagerMName.Size = new System.Drawing.Size(369, 44);
            this.txtManagerMName.TabIndex = 55;
            // 
            // txtManagerFName
            // 
            this.txtManagerFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerFName.Location = new System.Drawing.Point(273, 120);
            this.txtManagerFName.Name = "txtManagerFName";
            this.txtManagerFName.ReadOnly = true;
            this.txtManagerFName.Size = new System.Drawing.Size(369, 44);
            this.txtManagerFName.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(672, 583);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 37);
            this.label14.TabIndex = 52;
            this.label14.Text = "Salary";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(672, 479);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(245, 37);
            this.label15.TabIndex = 51;
            this.label15.Text = "Phone Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(672, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 37);
            this.label16.TabIndex = 50;
            this.label16.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(672, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 37);
            this.label17.TabIndex = 49;
            this.label17.Text = "State";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(672, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 37);
            this.label18.TabIndex = 48;
            this.label18.Text = "City";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 690);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 37);
            this.label19.TabIndex = 47;
            this.label19.Text = "Address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(30, 583);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 37);
            this.label20.TabIndex = 46;
            this.label20.Text = "Password";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(30, 479);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(172, 37);
            this.label21.TabIndex = 45;
            this.label21.Text = "Username";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(30, 358);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(182, 37);
            this.label22.TabIndex = 44;
            this.label22.Text = "Last Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(30, 244);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(216, 37);
            this.label23.TabIndex = 43;
            this.label23.Text = "Middle Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(30, 123);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(185, 37);
            this.label24.TabIndex = 42;
            this.label24.Text = "First Name";
            // 
            // comboManager
            // 
            this.comboManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboManager.FormattingEnabled = true;
            this.comboManager.Location = new System.Drawing.Point(37, 42);
            this.comboManager.Name = "comboManager";
            this.comboManager.Size = new System.Drawing.Size(327, 45);
            this.comboManager.TabIndex = 41;
            this.comboManager.Text = "Choose Manager...";
            this.comboManager.SelectedIndexChanged += new System.EventHandler(this.comboManager_SelectedIndexChanged);
            // 
            // btnManLogout
            // 
            this.btnManLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnManLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManLogout.ForeColor = System.Drawing.Color.Red;
            this.btnManLogout.Location = new System.Drawing.Point(1616, 12);
            this.btnManLogout.Name = "btnManLogout";
            this.btnManLogout.Size = new System.Drawing.Size(156, 46);
            this.btnManLogout.TabIndex = 0;
            this.btnManLogout.Text = "Logout";
            this.btnManLogout.UseVisualStyleBackColor = false;
            this.btnManLogout.Click += new System.EventHandler(this.btnManLogout_Click);
            // 
            // ManagersTableAdapter
            // 
            this.ManagersTableAdapter.ClearBeforeFill = true;
            // 
            // anchovyContextDataSetBindingSource
            // 
            this.anchovyContextDataSetBindingSource.DataSource = this.AnchovyContextDataSet;
            this.anchovyContextDataSetBindingSource.Position = 0;
            // 
            // toppingBindingSource
            // 
            this.toppingBindingSource.DataSource = typeof(Anchovy.API.Client.Models.Topping);
            // 
            // lstBoxInventory
            // 
            this.lstBoxInventory.FormattingEnabled = true;
            this.lstBoxInventory.ItemHeight = 37;
            this.lstBoxInventory.Location = new System.Drawing.Point(7, 44);
            this.lstBoxInventory.Name = "lstBoxInventory";
            this.lstBoxInventory.Size = new System.Drawing.Size(546, 707);
            this.lstBoxInventory.TabIndex = 0;
            this.lstBoxInventory.SelectedIndexChanged += new System.EventHandler(this.lstBoxInventory_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 37);
            this.label12.TabIndex = 12;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(409, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 37);
            this.label13.TabIndex = 13;
            this.label13.Text = "Quantity";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(629, 199);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 37);
            this.label25.TabIndex = 14;
            this.label25.Text = "Name";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(629, 267);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 37);
            this.label26.TabIndex = 15;
            this.label26.Text = "Cost";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(629, 341);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(144, 37);
            this.label27.TabIndex = 16;
            this.label27.Text = "Quantity";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(629, 420);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(168, 37);
            this.label28.TabIndex = 17;
            this.label28.Text = "Low Level";
            // 
            // txtInventoryName
            // 
            this.txtInventoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryName.Location = new System.Drawing.Point(825, 196);
            this.txtInventoryName.Name = "txtInventoryName";
            this.txtInventoryName.ReadOnly = true;
            this.txtInventoryName.Size = new System.Drawing.Size(239, 44);
            this.txtInventoryName.TabIndex = 55;
            // 
            // txtInventoryCost
            // 
            this.txtInventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryCost.Location = new System.Drawing.Point(825, 264);
            this.txtInventoryCost.Name = "txtInventoryCost";
            this.txtInventoryCost.ReadOnly = true;
            this.txtInventoryCost.Size = new System.Drawing.Size(239, 44);
            this.txtInventoryCost.TabIndex = 56;
            // 
            // txtInventoryQuantity
            // 
            this.txtInventoryQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryQuantity.Location = new System.Drawing.Point(825, 338);
            this.txtInventoryQuantity.Name = "txtInventoryQuantity";
            this.txtInventoryQuantity.ReadOnly = true;
            this.txtInventoryQuantity.Size = new System.Drawing.Size(239, 44);
            this.txtInventoryQuantity.TabIndex = 57;
            // 
            // txtInventoryLowLevel
            // 
            this.txtInventoryLowLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventoryLowLevel.Location = new System.Drawing.Point(825, 417);
            this.txtInventoryLowLevel.Name = "txtInventoryLowLevel";
            this.txtInventoryLowLevel.ReadOnly = true;
            this.txtInventoryLowLevel.Size = new System.Drawing.Size(239, 44);
            this.txtInventoryLowLevel.TabIndex = 58;
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1784, 850);
            this.Controls.Add(this.btnManLogout);
            this.Controls.Add(this.tabControl);
            this.Name = "ManagerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnchovyContextDataSet)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageInventory.PerformLayout();
            this.tabPageSales.ResumeLayout(false);
            this.tabPageSales.PerformLayout();
            this.tabPageCooks.ResumeLayout(false);
            this.tabPageCooks.PerformLayout();
            this.tabPageReports.ResumeLayout(false);
            this.tabPageReports.PerformLayout();
            this.tabPageManagers.ResumeLayout(false);
            this.tabPageManagers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anchovyContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.TabPage tabPageCooks;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.Button btnManLogout;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ManagersBindingSource;
        private AnchovyContextDataSet AnchovyContextDataSet;
        private AnchovyContextDataSetTableAdapters.ManagersTableAdapter ManagersTableAdapter;
        private System.Windows.Forms.ComboBox comboReports;
        private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMonthlyAveragesValue;
        private System.Windows.Forms.Label lbllblWeeklyAveragesValue;
        private System.Windows.Forms.Label lblDailyAveragesValue;
        private System.Windows.Forms.Label lblMonthlyAverages;
        private System.Windows.Forms.Label lblWeeklyAverages;
        private System.Windows.Forms.Label lblDailyAverages;
        private System.Windows.Forms.Label lblMonthlySalesValue;
        private System.Windows.Forms.Label lblWeeklySalesValue;
        private System.Windows.Forms.Label lblDailySalesValue;
        private System.Windows.Forms.Label lblMonthlySales;
        private System.Windows.Forms.Label lblWeeklySales;
        private System.Windows.Forms.Label lblDailySales;
        private System.Windows.Forms.Label lblAverageSales;
        private System.Windows.Forms.Label lblCurrentSales;
        private System.Windows.Forms.ComboBox comboCooks;
        private System.Windows.Forms.BindingSource anchovyContextDataSetBindingSource;
        private System.Windows.Forms.BindingSource toppingBindingSource;
        private System.Windows.Forms.Button btnRefreshSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCookMiddleName;
        private System.Windows.Forms.Label lblCookFirstName;
        private System.Windows.Forms.Button btnCookSave;
        private System.Windows.Forms.Button btnCookEdit;
        private System.Windows.Forms.TextBox txtCookPieceWorkRate;
        private System.Windows.Forms.TextBox txtCookHourlyWage;
        private System.Windows.Forms.TextBox txtCookPhoneNumber;
        private System.Windows.Forms.TextBox txtCookEmail;
        private System.Windows.Forms.TextBox txtCookState;
        private System.Windows.Forms.TextBox txtCookCity;
        private System.Windows.Forms.TextBox txtCookAddress;
        private System.Windows.Forms.TextBox txtCookPassword;
        private System.Windows.Forms.TextBox txtCookUsername;
        private System.Windows.Forms.TextBox txtCookLastName;
        private System.Windows.Forms.TextBox txtCookMiddleName;
        private System.Windows.Forms.TextBox txtCookFirstName;
        private System.Windows.Forms.Label lblCookPieceWrkError;
        private System.Windows.Forms.Label lblCookHourError;
        private System.Windows.Forms.Button btnAddNewCook;
        private System.Windows.Forms.TabPage tabPageManagers;
        private System.Windows.Forms.Button btnAddNewManager;
        private System.Windows.Forms.Label lblManagerSalaryError;
        private System.Windows.Forms.Button btnManagerSave;
        private System.Windows.Forms.Button btnManagerEdit;
        private System.Windows.Forms.TextBox txtManagerSalary;
        private System.Windows.Forms.TextBox txtManagerPhoneNumber;
        private System.Windows.Forms.TextBox txtManagerEmail;
        private System.Windows.Forms.TextBox txtManagerState;
        private System.Windows.Forms.TextBox txtManagerCity;
        private System.Windows.Forms.TextBox txtManagerAddress;
        private System.Windows.Forms.TextBox txtManagerPwd;
        private System.Windows.Forms.TextBox txtManagerUName;
        private System.Windows.Forms.TextBox txtManagerLName;
        private System.Windows.Forms.TextBox txtManagerMName;
        private System.Windows.Forms.TextBox txtManagerFName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboManager;
        private System.Windows.Forms.Label lblManagerIdValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxInventory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInventoryLowLevel;
        private System.Windows.Forms.TextBox txtInventoryQuantity;
        private System.Windows.Forms.TextBox txtInventoryCost;
        private System.Windows.Forms.TextBox txtInventoryName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
    }
}