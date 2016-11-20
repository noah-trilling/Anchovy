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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ManagersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AnchovyContextDataSet = new Anchovy.Manager.Main.AnchovyContextDataSet();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtRedOnions = new System.Windows.Forms.TextBox();
            this.txtBlackOlives = new System.Windows.Forms.TextBox();
            this.txtGreenPeppers = new System.Windows.Forms.TextBox();
            this.txtPinepples = new System.Windows.Forms.TextBox();
            this.txtAnchovies = new System.Windows.Forms.TextBox();
            this.txtBacon = new System.Windows.Forms.TextBox();
            this.txtPepperoni = new System.Windows.Forms.TextBox();
            this.txtCheese = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblRedOnions = new System.Windows.Forms.Label();
            this.lblBlackOlives = new System.Windows.Forms.Label();
            this.lblGreenPeppers = new System.Windows.Forms.Label();
            this.lblPineapples = new System.Windows.Forms.Label();
            this.lblAnchovies = new System.Windows.Forms.Label();
            this.lblBacon = new System.Windows.Forms.Label();
            this.lblPepperoni = new System.Windows.Forms.Label();
            this.lblCheese = new System.Windows.Forms.Label();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.lblMonthlyAveragesValue = new System.Windows.Forms.Label();
            this.lbllblWeeklyAveragesValue = new System.Windows.Forms.Label();
            this.lblDailyAveragesValue = new System.Windows.Forms.Label();
            this.lblMonthlyAverages = new System.Windows.Forms.Label();
            this.lblWeeklyAverages = new System.Windows.Forms.Label();
            this.lblDailyAverages = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeeklySalesValue = new System.Windows.Forms.Label();
            this.lblDailySalesValue = new System.Windows.Forms.Label();
            this.lblMonthlySales = new System.Windows.Forms.Label();
            this.lblWeeklySales = new System.Windows.Forms.Label();
            this.lblDailySales = new System.Windows.Forms.Label();
            this.lblAverageSales = new System.Windows.Forms.Label();
            this.lblCurrentSales = new System.Windows.Forms.Label();
            this.tabPageCooks = new System.Windows.Forms.TabPage();
            this.lblAllTimeStatsGradeValue = new System.Windows.Forms.Label();
            this.lblAllTimeStatsAcceptedValue = new System.Windows.Forms.Label();
            this.lblAllTimeStatsOfferedValue = new System.Windows.Forms.Label();
            this.lblAllTimeStats = new System.Windows.Forms.Label();
            this.lblWeeklyStatsGradeValue = new System.Windows.Forms.Label();
            this.lblWeeklyStatsAcceptedValue = new System.Windows.Forms.Label();
            this.lblWeeklyStatsOfferedValue = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblOrdersAccepted = new System.Windows.Forms.Label();
            this.lblOrdersOffered = new System.Windows.Forms.Label();
            this.lblWeeklyStats = new System.Windows.Forms.Label();
            this.comboCooks = new System.Windows.Forms.ComboBox();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.comboReports = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnManLogout = new System.Windows.Forms.Button();
            this.ManagersTableAdapter = new Anchovy.Manager.Main.AnchovyContextDataSetTableAdapters.ManagersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnchovyContextDataSet)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            this.tabPageCooks.SuspendLayout();
            this.tabPageReports.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabPageReports);
            this.tabControl.Location = new System.Drawing.Point(12, 34);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1760, 804);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.btnSave);
            this.tabPageInventory.Controls.Add(this.btnEdit);
            this.tabPageInventory.Controls.Add(this.txtRedOnions);
            this.tabPageInventory.Controls.Add(this.txtBlackOlives);
            this.tabPageInventory.Controls.Add(this.txtGreenPeppers);
            this.tabPageInventory.Controls.Add(this.txtPinepples);
            this.tabPageInventory.Controls.Add(this.txtAnchovies);
            this.tabPageInventory.Controls.Add(this.txtBacon);
            this.tabPageInventory.Controls.Add(this.txtPepperoni);
            this.tabPageInventory.Controls.Add(this.txtCheese);
            this.tabPageInventory.Controls.Add(this.lblQuantity);
            this.tabPageInventory.Controls.Add(this.lblTopping);
            this.tabPageInventory.Controls.Add(this.lblRedOnions);
            this.tabPageInventory.Controls.Add(this.lblBlackOlives);
            this.tabPageInventory.Controls.Add(this.lblGreenPeppers);
            this.tabPageInventory.Controls.Add(this.lblPineapples);
            this.tabPageInventory.Controls.Add(this.lblAnchovies);
            this.tabPageInventory.Controls.Add(this.lblBacon);
            this.tabPageInventory.Controls.Add(this.lblPepperoni);
            this.tabPageInventory.Controls.Add(this.lblCheese);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 29);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(1752, 771);
            this.tabPageInventory.TabIndex = 0;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(996, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 63);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(996, 289);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 63);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtRedOnions
            // 
            this.txtRedOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedOnions.Location = new System.Drawing.Point(436, 688);
            this.txtRedOnions.Name = "txtRedOnions";
            this.txtRedOnions.ReadOnly = true;
            this.txtRedOnions.Size = new System.Drawing.Size(200, 44);
            this.txtRedOnions.TabIndex = 17;
            // 
            // txtBlackOlives
            // 
            this.txtBlackOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlackOlives.Location = new System.Drawing.Point(436, 610);
            this.txtBlackOlives.Name = "txtBlackOlives";
            this.txtBlackOlives.ReadOnly = true;
            this.txtBlackOlives.Size = new System.Drawing.Size(200, 44);
            this.txtBlackOlives.TabIndex = 16;
            // 
            // txtGreenPeppers
            // 
            this.txtGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreenPeppers.Location = new System.Drawing.Point(436, 526);
            this.txtGreenPeppers.Name = "txtGreenPeppers";
            this.txtGreenPeppers.ReadOnly = true;
            this.txtGreenPeppers.Size = new System.Drawing.Size(200, 44);
            this.txtGreenPeppers.TabIndex = 15;
            // 
            // txtPinepples
            // 
            this.txtPinepples.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinepples.Location = new System.Drawing.Point(436, 451);
            this.txtPinepples.Name = "txtPinepples";
            this.txtPinepples.ReadOnly = true;
            this.txtPinepples.Size = new System.Drawing.Size(200, 44);
            this.txtPinepples.TabIndex = 14;
            // 
            // txtAnchovies
            // 
            this.txtAnchovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnchovies.Location = new System.Drawing.Point(436, 358);
            this.txtAnchovies.Name = "txtAnchovies";
            this.txtAnchovies.ReadOnly = true;
            this.txtAnchovies.Size = new System.Drawing.Size(200, 44);
            this.txtAnchovies.TabIndex = 13;
            // 
            // txtBacon
            // 
            this.txtBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBacon.Location = new System.Drawing.Point(436, 282);
            this.txtBacon.Name = "txtBacon";
            this.txtBacon.ReadOnly = true;
            this.txtBacon.Size = new System.Drawing.Size(200, 44);
            this.txtBacon.TabIndex = 12;
            // 
            // txtPepperoni
            // 
            this.txtPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPepperoni.Location = new System.Drawing.Point(436, 197);
            this.txtPepperoni.Name = "txtPepperoni";
            this.txtPepperoni.ReadOnly = true;
            this.txtPepperoni.Size = new System.Drawing.Size(200, 44);
            this.txtPepperoni.TabIndex = 11;
            // 
            // txtCheese
            // 
            this.txtCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheese.Location = new System.Drawing.Point(436, 118);
            this.txtCheese.Name = "txtCheese";
            this.txtCheese.ReadOnly = true;
            this.txtCheese.Size = new System.Drawing.Size(200, 44);
            this.txtCheese.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(426, 29);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(210, 55);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(36, 29);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(230, 55);
            this.lblTopping.TabIndex = 8;
            this.lblTopping.Text = "Toppings";
            // 
            // lblRedOnions
            // 
            this.lblRedOnions.AutoSize = true;
            this.lblRedOnions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedOnions.Location = new System.Drawing.Point(39, 695);
            this.lblRedOnions.Name = "lblRedOnions";
            this.lblRedOnions.Size = new System.Drawing.Size(195, 37);
            this.lblRedOnions.TabIndex = 7;
            this.lblRedOnions.Text = "Red Onions";
            // 
            // lblBlackOlives
            // 
            this.lblBlackOlives.AutoSize = true;
            this.lblBlackOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackOlives.Location = new System.Drawing.Point(39, 617);
            this.lblBlackOlives.Name = "lblBlackOlives";
            this.lblBlackOlives.Size = new System.Drawing.Size(203, 37);
            this.lblBlackOlives.TabIndex = 6;
            this.lblBlackOlives.Text = "Black Olives";
            // 
            // lblGreenPeppers
            // 
            this.lblGreenPeppers.AutoSize = true;
            this.lblGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenPeppers.Location = new System.Drawing.Point(39, 533);
            this.lblGreenPeppers.Name = "lblGreenPeppers";
            this.lblGreenPeppers.Size = new System.Drawing.Size(245, 37);
            this.lblGreenPeppers.TabIndex = 5;
            this.lblGreenPeppers.Text = "Green Peppers";
            // 
            // lblPineapples
            // 
            this.lblPineapples.AutoSize = true;
            this.lblPineapples.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPineapples.Location = new System.Drawing.Point(39, 451);
            this.lblPineapples.Name = "lblPineapples";
            this.lblPineapples.Size = new System.Drawing.Size(184, 37);
            this.lblPineapples.TabIndex = 4;
            this.lblPineapples.Text = "Pineapples";
            // 
            // lblAnchovies
            // 
            this.lblAnchovies.AutoSize = true;
            this.lblAnchovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnchovies.Location = new System.Drawing.Point(39, 365);
            this.lblAnchovies.Name = "lblAnchovies";
            this.lblAnchovies.Size = new System.Drawing.Size(173, 37);
            this.lblAnchovies.TabIndex = 3;
            this.lblAnchovies.Text = "Anchovies";
            // 
            // lblBacon
            // 
            this.lblBacon.AutoSize = true;
            this.lblBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacon.Location = new System.Drawing.Point(39, 289);
            this.lblBacon.Name = "lblBacon";
            this.lblBacon.Size = new System.Drawing.Size(113, 37);
            this.lblBacon.TabIndex = 2;
            this.lblBacon.Text = "Bacon";
            // 
            // lblPepperoni
            // 
            this.lblPepperoni.AutoSize = true;
            this.lblPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPepperoni.Location = new System.Drawing.Point(39, 204);
            this.lblPepperoni.Name = "lblPepperoni";
            this.lblPepperoni.Size = new System.Drawing.Size(171, 37);
            this.lblPepperoni.TabIndex = 1;
            this.lblPepperoni.Text = "Pepperoni";
            // 
            // lblCheese
            // 
            this.lblCheese.AutoSize = true;
            this.lblCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheese.Location = new System.Drawing.Point(39, 125);
            this.lblCheese.Name = "lblCheese";
            this.lblCheese.Size = new System.Drawing.Size(131, 37);
            this.lblCheese.TabIndex = 0;
            this.lblCheese.Text = "Cheese";
            this.lblCheese.Click += new System.EventHandler(this.lblCheese_Click);
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.lblMonthlyAveragesValue);
            this.tabPageSales.Controls.Add(this.lbllblWeeklyAveragesValue);
            this.tabPageSales.Controls.Add(this.lblDailyAveragesValue);
            this.tabPageSales.Controls.Add(this.lblMonthlyAverages);
            this.tabPageSales.Controls.Add(this.lblWeeklyAverages);
            this.tabPageSales.Controls.Add(this.lblDailyAverages);
            this.tabPageSales.Controls.Add(this.label3);
            this.tabPageSales.Controls.Add(this.lblWeeklySalesValue);
            this.tabPageSales.Controls.Add(this.lblDailySalesValue);
            this.tabPageSales.Controls.Add(this.lblMonthlySales);
            this.tabPageSales.Controls.Add(this.lblWeeklySales);
            this.tabPageSales.Controls.Add(this.lblDailySales);
            this.tabPageSales.Controls.Add(this.lblAverageSales);
            this.tabPageSales.Controls.Add(this.lblCurrentSales);
            this.tabPageSales.Location = new System.Drawing.Point(4, 29);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(1752, 771);
            this.tabPageSales.TabIndex = 1;
            this.tabPageSales.Text = "Sales";
            this.tabPageSales.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "$15,458.52";
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
            this.tabPageCooks.Controls.Add(this.lblAllTimeStatsGradeValue);
            this.tabPageCooks.Controls.Add(this.lblAllTimeStatsAcceptedValue);
            this.tabPageCooks.Controls.Add(this.lblAllTimeStatsOfferedValue);
            this.tabPageCooks.Controls.Add(this.lblAllTimeStats);
            this.tabPageCooks.Controls.Add(this.lblWeeklyStatsGradeValue);
            this.tabPageCooks.Controls.Add(this.lblWeeklyStatsAcceptedValue);
            this.tabPageCooks.Controls.Add(this.lblWeeklyStatsOfferedValue);
            this.tabPageCooks.Controls.Add(this.lblGrade);
            this.tabPageCooks.Controls.Add(this.lblOrdersAccepted);
            this.tabPageCooks.Controls.Add(this.lblOrdersOffered);
            this.tabPageCooks.Controls.Add(this.lblWeeklyStats);
            this.tabPageCooks.Controls.Add(this.comboCooks);
            this.tabPageCooks.Location = new System.Drawing.Point(4, 29);
            this.tabPageCooks.Name = "tabPageCooks";
            this.tabPageCooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCooks.Size = new System.Drawing.Size(1752, 771);
            this.tabPageCooks.TabIndex = 2;
            this.tabPageCooks.Text = "Cooks";
            this.tabPageCooks.UseVisualStyleBackColor = true;
            // 
            // lblAllTimeStatsGradeValue
            // 
            this.lblAllTimeStatsGradeValue.AutoSize = true;
            this.lblAllTimeStatsGradeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeStatsGradeValue.Location = new System.Drawing.Point(894, 664);
            this.lblAllTimeStatsGradeValue.Name = "lblAllTimeStatsGradeValue";
            this.lblAllTimeStatsGradeValue.Size = new System.Drawing.Size(52, 37);
            this.lblAllTimeStatsGradeValue.TabIndex = 27;
            this.lblAllTimeStatsGradeValue.Text = "C-";
            // 
            // lblAllTimeStatsAcceptedValue
            // 
            this.lblAllTimeStatsAcceptedValue.AutoSize = true;
            this.lblAllTimeStatsAcceptedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeStatsAcceptedValue.Location = new System.Drawing.Point(894, 454);
            this.lblAllTimeStatsAcceptedValue.Name = "lblAllTimeStatsAcceptedValue";
            this.lblAllTimeStatsAcceptedValue.Size = new System.Drawing.Size(91, 37);
            this.lblAllTimeStatsAcceptedValue.TabIndex = 26;
            this.lblAllTimeStatsAcceptedValue.Text = "1465";
            // 
            // lblAllTimeStatsOfferedValue
            // 
            this.lblAllTimeStatsOfferedValue.AutoSize = true;
            this.lblAllTimeStatsOfferedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeStatsOfferedValue.Location = new System.Drawing.Point(894, 273);
            this.lblAllTimeStatsOfferedValue.Name = "lblAllTimeStatsOfferedValue";
            this.lblAllTimeStatsOfferedValue.Size = new System.Drawing.Size(93, 37);
            this.lblAllTimeStatsOfferedValue.TabIndex = 25;
            this.lblAllTimeStatsOfferedValue.Text = "2093";
            // 
            // lblAllTimeStats
            // 
            this.lblAllTimeStats.AutoSize = true;
            this.lblAllTimeStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTimeStats.Location = new System.Drawing.Point(819, 204);
            this.lblAllTimeStats.Name = "lblAllTimeStats";
            this.lblAllTimeStats.Size = new System.Drawing.Size(239, 37);
            this.lblAllTimeStats.TabIndex = 24;
            this.lblAllTimeStats.Text = "All Time Stats ";
            // 
            // lblWeeklyStatsGradeValue
            // 
            this.lblWeeklyStatsGradeValue.AutoSize = true;
            this.lblWeeklyStatsGradeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyStatsGradeValue.Location = new System.Drawing.Point(501, 664);
            this.lblWeeklyStatsGradeValue.Name = "lblWeeklyStatsGradeValue";
            this.lblWeeklyStatsGradeValue.Size = new System.Drawing.Size(40, 37);
            this.lblWeeklyStatsGradeValue.TabIndex = 23;
            this.lblWeeklyStatsGradeValue.Text = "A";
            // 
            // lblWeeklyStatsAcceptedValue
            // 
            this.lblWeeklyStatsAcceptedValue.AutoSize = true;
            this.lblWeeklyStatsAcceptedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyStatsAcceptedValue.Location = new System.Drawing.Point(501, 454);
            this.lblWeeklyStatsAcceptedValue.Name = "lblWeeklyStatsAcceptedValue";
            this.lblWeeklyStatsAcceptedValue.Size = new System.Drawing.Size(74, 37);
            this.lblWeeklyStatsAcceptedValue.TabIndex = 22;
            this.lblWeeklyStatsAcceptedValue.Text = "307";
            // 
            // lblWeeklyStatsOfferedValue
            // 
            this.lblWeeklyStatsOfferedValue.AutoSize = true;
            this.lblWeeklyStatsOfferedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyStatsOfferedValue.Location = new System.Drawing.Point(501, 273);
            this.lblWeeklyStatsOfferedValue.Name = "lblWeeklyStatsOfferedValue";
            this.lblWeeklyStatsOfferedValue.Size = new System.Drawing.Size(74, 37);
            this.lblWeeklyStatsOfferedValue.TabIndex = 21;
            this.lblWeeklyStatsOfferedValue.Text = "309";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(73, 664);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(111, 37);
            this.lblGrade.TabIndex = 20;
            this.lblGrade.Text = "Grade";
            // 
            // lblOrdersAccepted
            // 
            this.lblOrdersAccepted.AutoSize = true;
            this.lblOrdersAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersAccepted.Location = new System.Drawing.Point(73, 454);
            this.lblOrdersAccepted.Name = "lblOrdersAccepted";
            this.lblOrdersAccepted.Size = new System.Drawing.Size(272, 37);
            this.lblOrdersAccepted.TabIndex = 19;
            this.lblOrdersAccepted.Text = "Orders Accepted";
            // 
            // lblOrdersOffered
            // 
            this.lblOrdersOffered.AutoSize = true;
            this.lblOrdersOffered.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersOffered.Location = new System.Drawing.Point(73, 273);
            this.lblOrdersOffered.Name = "lblOrdersOffered";
            this.lblOrdersOffered.Size = new System.Drawing.Size(254, 37);
            this.lblOrdersOffered.TabIndex = 18;
            this.lblOrdersOffered.Text = "Orders Offered ";
            // 
            // lblWeeklyStats
            // 
            this.lblWeeklyStats.AutoSize = true;
            this.lblWeeklyStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyStats.Location = new System.Drawing.Point(445, 204);
            this.lblWeeklyStats.Name = "lblWeeklyStats";
            this.lblWeeklyStats.Size = new System.Drawing.Size(224, 37);
            this.lblWeeklyStats.TabIndex = 17;
            this.lblWeeklyStats.Text = "Weekly Stats ";
            // 
            // comboCooks
            // 
            this.comboCooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCooks.FormattingEnabled = true;
            this.comboCooks.Location = new System.Drawing.Point(40, 43);
            this.comboCooks.Name = "comboCooks";
            this.comboCooks.Size = new System.Drawing.Size(327, 45);
            this.comboCooks.TabIndex = 2;
            this.comboCooks.Text = "Choose Cook...";
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
            this.tabPageReports.Location = new System.Drawing.Point(4, 29);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(1752, 771);
            this.tabPageReports.TabIndex = 3;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(1234, 6);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(130, 40);
            this.btnRunReport.TabIndex = 6;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(869, 15);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(286, 26);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(460, 14);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(286, 26);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(786, 21);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(77, 20);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(370, 21);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 20);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // comboReports
            // 
            this.comboReports.FormattingEnabled = true;
            this.comboReports.Location = new System.Drawing.Point(20, 18);
            this.comboReports.Name = "comboReports";
            this.comboReports.Size = new System.Drawing.Size(327, 28);
            this.comboReports.TabIndex = 1;
            this.comboReports.Text = "Choose Report...";
            this.comboReports.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ManagersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Anchovy.Manager.Main.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1740, 633);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            this.Text = "ManagerMain";
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
        private System.Windows.Forms.Label lblCheese;
        private System.Windows.Forms.TextBox txtRedOnions;
        private System.Windows.Forms.TextBox txtBlackOlives;
        private System.Windows.Forms.TextBox txtGreenPeppers;
        private System.Windows.Forms.TextBox txtPinepples;
        private System.Windows.Forms.TextBox txtAnchovies;
        private System.Windows.Forms.TextBox txtBacon;
        private System.Windows.Forms.TextBox txtPepperoni;
        private System.Windows.Forms.TextBox txtCheese;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblRedOnions;
        private System.Windows.Forms.Label lblBlackOlives;
        private System.Windows.Forms.Label lblGreenPeppers;
        private System.Windows.Forms.Label lblPineapples;
        private System.Windows.Forms.Label lblAnchovies;
        private System.Windows.Forms.Label lblBacon;
        private System.Windows.Forms.Label lblPepperoni;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblMonthlyAveragesValue;
        private System.Windows.Forms.Label lbllblWeeklyAveragesValue;
        private System.Windows.Forms.Label lblDailyAveragesValue;
        private System.Windows.Forms.Label lblMonthlyAverages;
        private System.Windows.Forms.Label lblWeeklyAverages;
        private System.Windows.Forms.Label lblDailyAverages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeeklySalesValue;
        private System.Windows.Forms.Label lblDailySalesValue;
        private System.Windows.Forms.Label lblMonthlySales;
        private System.Windows.Forms.Label lblWeeklySales;
        private System.Windows.Forms.Label lblDailySales;
        private System.Windows.Forms.Label lblAverageSales;
        private System.Windows.Forms.Label lblCurrentSales;
        private System.Windows.Forms.Label lblAllTimeStatsGradeValue;
        private System.Windows.Forms.Label lblAllTimeStatsAcceptedValue;
        private System.Windows.Forms.Label lblAllTimeStatsOfferedValue;
        private System.Windows.Forms.Label lblAllTimeStats;
        private System.Windows.Forms.Label lblWeeklyStatsGradeValue;
        private System.Windows.Forms.Label lblWeeklyStatsAcceptedValue;
        private System.Windows.Forms.Label lblWeeklyStatsOfferedValue;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblOrdersAccepted;
        private System.Windows.Forms.Label lblOrdersOffered;
        private System.Windows.Forms.Label lblWeeklyStats;
        private System.Windows.Forms.ComboBox comboCooks;
    }
}