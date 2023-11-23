using System;

namespace Shop_AccessDB_Save_Update_Delete_Search
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDrawChart = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.panelForTransitionToTable = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoToSales = new System.Windows.Forms.Button();
            this.btnGoToProducts = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.panelForTxtBox = new System.Windows.Forms.Panel();
            this.dtpPaymentdate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.labelClientID = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.checkBoxReturned = new System.Windows.Forms.CheckBox();
            this.checkBoxPayed = new System.Windows.Forms.CheckBox();
            this.labelProduct_Number = new System.Windows.Forms.Label();
            this.textBoxProductNumber = new System.Windows.Forms.TextBox();
            this.btnClearDataForm3 = new System.Windows.Forms.Button();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelSalesOrderID = new System.Windows.Forms.Label();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.buttonMostOrderd = new System.Windows.Forms.Button();
            this.buttonReturned = new System.Windows.Forms.Button();
            this.buttonUnpayed = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClientsShopedlastWeek = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.panelForFormLabel = new System.Windows.Forms.Panel();
            this.labelSales = new System.Windows.Forms.Label();
            this.buttonPayed = new System.Windows.Forms.Button();
            this.buttonUnreturned = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelForTransitionToTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panelForTxtBox.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelForFormLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelForTransitionToTable);
            this.panel1.Controls.Add(this.dgvSales);
            this.panel1.Controls.Add(this.panelForTxtBox);
            this.panel1.Controls.Add(this.panelForButtons);
            this.panel1.Controls.Add(this.panelForFormLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2021, 1114);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.buttonDrawChart);
            this.panel3.Controls.Add(this.dtpStart);
            this.panel3.Controls.Add(this.dtpEnd);
            this.panel3.Controls.Add(this.labelEnd);
            this.panel3.Controls.Add(this.labelStart);
            this.panel3.Location = new System.Drawing.Point(971, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 529);
            this.panel3.TabIndex = 18;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(18, 101);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.CustomProperties = "LabelStyle=Top, DrawingStyle=Cylinder";
            series5.Legend = "Legend1";
            series5.Name = "Sales ";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(574, 371);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonDrawChart
            // 
            this.buttonDrawChart.Location = new System.Drawing.Point(414, 484);
            this.buttonDrawChart.Name = "buttonDrawChart";
            this.buttonDrawChart.Size = new System.Drawing.Size(191, 42);
            this.buttonDrawChart.TabIndex = 17;
            this.buttonDrawChart.Text = "Draw Pie Chart";
            this.buttonDrawChart.UseVisualStyleBackColor = true;
            this.buttonDrawChart.Click += new System.EventHandler(this.buttonDrawChart_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(39, 47);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(140, 30);
            this.dtpStart.TabIndex = 13;
            this.dtpStart.Value = new System.DateTime(2023, 11, 22, 8, 55, 3, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpEnd.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(437, 49);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(138, 30);
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.Value = new System.DateTime(2023, 11, 22, 8, 56, 31, 0);
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.BackColor = System.Drawing.Color.AliceBlue;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(432, 12);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(85, 25);
            this.labelEnd.TabIndex = 15;
            this.labelEnd.Text = "To date:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.AliceBlue;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(34, 12);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(106, 25);
            this.labelStart.TabIndex = 14;
            this.labelStart.Text = "From date:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.textBoxSearchClient);
            this.panel2.Controls.Add(this.btnSearchClient);
            this.panel2.Location = new System.Drawing.Point(17, 812);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 66);
            this.panel2.TabIndex = 5;
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(5, 23);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(432, 30);
            this.textBoxSearchClient.TabIndex = 8;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.AutoSize = true;
            this.btnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(443, 11);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(100, 47);
            this.btnSearchClient.TabIndex = 7;
            this.btnSearchClient.Text = "Search";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // panelForTransitionToTable
            // 
            this.panelForTransitionToTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelForTransitionToTable.Controls.Add(this.btnExit);
            this.panelForTransitionToTable.Controls.Add(this.btnGoToSales);
            this.panelForTransitionToTable.Controls.Add(this.btnGoToProducts);
            this.panelForTransitionToTable.Location = new System.Drawing.Point(602, 812);
            this.panelForTransitionToTable.Name = "panelForTransitionToTable";
            this.panelForTransitionToTable.Size = new System.Drawing.Size(925, 67);
            this.panelForTransitionToTable.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(662, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnGoToSales
            // 
            this.btnGoToSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToSales.Location = new System.Drawing.Point(369, 11);
            this.btnGoToSales.Name = "btnGoToSales";
            this.btnGoToSales.Size = new System.Drawing.Size(248, 47);
            this.btnGoToSales.TabIndex = 1;
            this.btnGoToSales.Text = "Go To Sales";
            this.btnGoToSales.UseVisualStyleBackColor = false;
            // 
            // btnGoToProducts
            // 
            this.btnGoToProducts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToProducts.Location = new System.Drawing.Point(72, 11);
            this.btnGoToProducts.Name = "btnGoToProducts";
            this.btnGoToProducts.Size = new System.Drawing.Size(194, 46);
            this.btnGoToProducts.TabIndex = 0;
            this.btnGoToProducts.Text = "Go To Products";
            this.btnGoToProducts.UseVisualStyleBackColor = false;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowDrop = true;
            this.dgvSales.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSales.Location = new System.Drawing.Point(17, 575);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(1562, 231);
            this.dgvSales.TabIndex = 3;
            this.dgvSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellClick);
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
            // 
            // panelForTxtBox
            // 
            this.panelForTxtBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelForTxtBox.Controls.Add(this.dtpPaymentdate);
            this.panelForTxtBox.Controls.Add(this.dtpOrderDate);
            this.panelForTxtBox.Controls.Add(this.labelClientID);
            this.panelForTxtBox.Controls.Add(this.textBoxClientID);
            this.panelForTxtBox.Controls.Add(this.checkBoxReturned);
            this.panelForTxtBox.Controls.Add(this.checkBoxPayed);
            this.panelForTxtBox.Controls.Add(this.labelProduct_Number);
            this.panelForTxtBox.Controls.Add(this.textBoxProductNumber);
            this.panelForTxtBox.Controls.Add(this.btnClearDataForm3);
            this.panelForTxtBox.Controls.Add(this.textBoxOrderID);
            this.panelForTxtBox.Controls.Add(this.labelPaymentDate);
            this.panelForTxtBox.Controls.Add(this.labelOrderDate);
            this.panelForTxtBox.Controls.Add(this.labelSalesOrderID);
            this.panelForTxtBox.Location = new System.Drawing.Point(17, 73);
            this.panelForTxtBox.Name = "panelForTxtBox";
            this.panelForTxtBox.Size = new System.Drawing.Size(386, 433);
            this.panelForTxtBox.TabIndex = 2;
            // 
            // dtpPaymentdate
            // 
            this.dtpPaymentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentdate.Location = new System.Drawing.Point(10, 329);
            this.dtpPaymentdate.Name = "dtpPaymentdate";
            this.dtpPaymentdate.Size = new System.Drawing.Size(244, 30);
            this.dtpPaymentdate.TabIndex = 20;
            this.dtpPaymentdate.Value = new System.DateTime(2023, 11, 10, 0, 0, 0, 0);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(9, 255);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpOrderDate.Size = new System.Drawing.Size(245, 30);
            this.dtpOrderDate.TabIndex = 19;
            this.dtpOrderDate.Value = new System.DateTime(2023, 11, 10, 0, 0, 0, 0);
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(7, 97);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(92, 25);
            this.labelClientID.TabIndex = 18;
            this.labelClientID.Text = "Client ID:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(3, 125);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(358, 30);
            this.textBoxClientID.TabIndex = 17;
            // 
            // checkBoxReturned
            // 
            this.checkBoxReturned.AutoSize = true;
            this.checkBoxReturned.Location = new System.Drawing.Point(267, 377);
            this.checkBoxReturned.Name = "checkBoxReturned";
            this.checkBoxReturned.Size = new System.Drawing.Size(113, 29);
            this.checkBoxReturned.TabIndex = 16;
            this.checkBoxReturned.Text = "Returned";
            this.checkBoxReturned.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxReturned.UseVisualStyleBackColor = true;
            // 
            // checkBoxPayed
            // 
            this.checkBoxPayed.AutoSize = true;
            this.checkBoxPayed.Location = new System.Drawing.Point(10, 377);
            this.checkBoxPayed.Name = "checkBoxPayed";
            this.checkBoxPayed.Size = new System.Drawing.Size(90, 29);
            this.checkBoxPayed.TabIndex = 15;
            this.checkBoxPayed.Text = "Payed";
            this.checkBoxPayed.UseVisualStyleBackColor = true;
            this.checkBoxPayed.CheckedChanged += new System.EventHandler(this.checkBoxPayed_CheckedChanged);
            // 
            // labelProduct_Number
            // 
            this.labelProduct_Number.AutoSize = true;
            this.labelProduct_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct_Number.Location = new System.Drawing.Point(7, 168);
            this.labelProduct_Number.Name = "labelProduct_Number";
            this.labelProduct_Number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProduct_Number.Size = new System.Drawing.Size(159, 25);
            this.labelProduct_Number.TabIndex = 14;
            this.labelProduct_Number.Text = "Product Number:";
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Location = new System.Drawing.Point(3, 196);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(363, 30);
            this.textBoxProductNumber.TabIndex = 13;
            // 
            // btnClearDataForm3
            // 
            this.btnClearDataForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDataForm3.Location = new System.Drawing.Point(247, 12);
            this.btnClearDataForm3.Name = "btnClearDataForm3";
            this.btnClearDataForm3.Size = new System.Drawing.Size(133, 32);
            this.btnClearDataForm3.TabIndex = 12;
            this.btnClearDataForm3.Text = "Clear Fields";
            this.btnClearDataForm3.UseVisualStyleBackColor = true;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderID.Location = new System.Drawing.Point(3, 47);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(354, 30);
            this.textBoxOrderID.TabIndex = 6;
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentDate.Location = new System.Drawing.Point(4, 301);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(141, 25);
            this.labelPaymentDate.TabIndex = 2;
            this.labelPaymentDate.Text = "Payment Date:";
            this.labelPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDate.Location = new System.Drawing.Point(5, 227);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(114, 25);
            this.labelOrderDate.TabIndex = 1;
            this.labelOrderDate.Text = "Order Date:";
            this.labelOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSalesOrderID
            // 
            this.labelSalesOrderID.AutoSize = true;
            this.labelSalesOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesOrderID.Location = new System.Drawing.Point(8, 16);
            this.labelSalesOrderID.Name = "labelSalesOrderID";
            this.labelSalesOrderID.Size = new System.Drawing.Size(92, 25);
            this.labelSalesOrderID.TabIndex = 0;
            this.labelSalesOrderID.Text = "Order ID:";
            this.labelSalesOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelForButtons
            // 
            this.panelForButtons.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelForButtons.Controls.Add(this.buttonUnreturned);
            this.panelForButtons.Controls.Add(this.buttonPayed);
            this.panelForButtons.Controls.Add(this.buttonMostOrderd);
            this.panelForButtons.Controls.Add(this.buttonReturned);
            this.panelForButtons.Controls.Add(this.buttonUnpayed);
            this.panelForButtons.Controls.Add(this.btnRefresh);
            this.panelForButtons.Controls.Add(this.btnClientsShopedlastWeek);
            this.panelForButtons.Controls.Add(this.btnDeleteOrder);
            this.panelForButtons.Controls.Add(this.btnUpdateOrder);
            this.panelForButtons.Controls.Add(this.btnInsertOrder);
            this.panelForButtons.Location = new System.Drawing.Point(434, 73);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(503, 354);
            this.panelForButtons.TabIndex = 1;
            // 
            // buttonMostOrderd
            // 
            this.buttonMostOrderd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostOrderd.Location = new System.Drawing.Point(195, 292);
            this.buttonMostOrderd.Name = "buttonMostOrderd";
            this.buttonMostOrderd.Size = new System.Drawing.Size(291, 40);
            this.buttonMostOrderd.TabIndex = 11;
            this.buttonMostOrderd.Text = "Most ordered";
            this.buttonMostOrderd.UseVisualStyleBackColor = true;
            this.buttonMostOrderd.Click += new System.EventHandler(this.buttonMostOrderd_Click);
            // 
            // buttonReturned
            // 
            this.buttonReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturned.Location = new System.Drawing.Point(195, 196);
            this.buttonReturned.Name = "buttonReturned";
            this.buttonReturned.Size = new System.Drawing.Size(117, 67);
            this.buttonReturned.TabIndex = 10;
            this.buttonReturned.Text = "Show Returned";
            this.buttonReturned.UseVisualStyleBackColor = true;
            this.buttonReturned.Click += new System.EventHandler(this.buttonReturned_Click);
            // 
            // buttonUnpayed
            // 
            this.buttonUnpayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnpayed.Location = new System.Drawing.Point(195, 104);
            this.buttonUnpayed.Name = "buttonUnpayed";
            this.buttonUnpayed.Size = new System.Drawing.Size(117, 72);
            this.buttonUnpayed.TabIndex = 9;
            this.buttonUnpayed.Text = "Show unpayed";
            this.buttonUnpayed.UseVisualStyleBackColor = true;
            this.buttonUnpayed.Click += new System.EventHandler(this.buttonUnpayed_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(26, 292);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 40);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClientsShopedlastWeek
            // 
            this.btnClientsShopedlastWeek.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientsShopedlastWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsShopedlastWeek.Location = new System.Drawing.Point(195, 29);
            this.btnClientsShopedlastWeek.Name = "btnClientsShopedlastWeek";
            this.btnClientsShopedlastWeek.Size = new System.Drawing.Size(292, 42);
            this.btnClientsShopedlastWeek.TabIndex = 4;
            this.btnClientsShopedlastWeek.Text = "Shoped  in last week";
            this.btnClientsShopedlastWeek.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(28, 196);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(139, 40);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.Location = new System.Drawing.Point(28, 114);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(135, 40);
            this.btnUpdateOrder.TabIndex = 1;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertOrder.Location = new System.Drawing.Point(26, 29);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(137, 42);
            this.btnInsertOrder.TabIndex = 0;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.UseVisualStyleBackColor = false;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // panelForFormLabel
            // 
            this.panelForFormLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelForFormLabel.Controls.Add(this.labelSales);
            this.panelForFormLabel.Location = new System.Drawing.Point(17, 9);
            this.panelForFormLabel.Name = "panelForFormLabel";
            this.panelForFormLabel.Size = new System.Drawing.Size(920, 56);
            this.panelForFormLabel.TabIndex = 0;
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSales.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSales.Location = new System.Drawing.Point(31, 16);
            this.labelSales.Name = "labelSales";
            this.labelSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSales.Size = new System.Drawing.Size(73, 28);
            this.labelSales.TabIndex = 0;
            this.labelSales.Text = "Sales";
            this.labelSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPayed
            // 
            this.buttonPayed.Location = new System.Drawing.Point(370, 104);
            this.buttonPayed.Name = "buttonPayed";
            this.buttonPayed.Size = new System.Drawing.Size(117, 72);
            this.buttonPayed.TabIndex = 12;
            this.buttonPayed.Text = "Show payed";
            this.buttonPayed.UseVisualStyleBackColor = true;
            this.buttonPayed.Click += new System.EventHandler(this.buttonPayed_Click);
            // 
            // buttonUnreturned
            // 
            this.buttonUnreturned.Location = new System.Drawing.Point(370, 196);
            this.buttonUnreturned.Name = "buttonUnreturned";
            this.buttonUnreturned.Size = new System.Drawing.Size(117, 68);
            this.buttonUnreturned.TabIndex = 13;
            this.buttonUnreturned.Text = "Show Unreturned";
            this.buttonUnreturned.UseVisualStyleBackColor = true;
            this.buttonUnreturned.Click += new System.EventHandler(this.buttonUnreturned_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 899);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelForTransitionToTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panelForTxtBox.ResumeLayout(false);
            this.panelForTxtBox.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelForFormLabel.ResumeLayout(false);
            this.panelForFormLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Panel panelForTransitionToTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGoToSales;
        private System.Windows.Forms.Button btnGoToProducts;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel panelForTxtBox;
        private System.Windows.Forms.Label labelProduct_Number;
        private System.Windows.Forms.TextBox textBoxProductNumber;
        private System.Windows.Forms.Button btnClearDataForm3;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label labelPaymentDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelSalesOrderID;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClientsShopedlastWeek;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.Panel panelForFormLabel;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Button buttonMostOrderd;
        private System.Windows.Forms.Button buttonReturned;
        private System.Windows.Forms.Button buttonUnpayed;
        private System.Windows.Forms.CheckBox checkBoxReturned;
        private System.Windows.Forms.CheckBox checkBoxPayed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button buttonDrawChart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.DateTimePicker dtpPaymentdate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button buttonUnreturned;
        private System.Windows.Forms.Button buttonPayed;
    }
}