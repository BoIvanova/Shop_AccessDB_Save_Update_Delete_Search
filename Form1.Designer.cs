﻿using System.Windows.Forms;

namespace Shop_AccessDB_Save_Update_Delete_Search
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.panelForTransitionToTable = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGoToSales = new System.Windows.Forms.Button();
            this.btnGoToClients = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panelForTxtBox = new System.Windows.Forms.Panel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.textBoxPieces = new System.Windows.Forms.TextBox();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.labelPieces = new System.Windows.Forms.Label();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelSKU = new System.Windows.Forms.Label();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.dateTimePickerProducts = new System.Windows.Forms.DateTimePicker();
            this.btnPrintProduct = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExpDateMoreThan3M = new System.Windows.Forms.Button();
            this.btnExpIn24Hours = new System.Windows.Forms.Button();
            this.btnShowExpired = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnInsertProduct = new System.Windows.Forms.Button();
            this.panelForFormLabel = new System.Windows.Forms.Panel();
            this.labelProducts = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogProducts = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelForTransitionToTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelForTxtBox.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelForFormLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelForTransitionToTable);
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Controls.Add(this.panelForTxtBox);
            this.panel1.Controls.Add(this.panelForButtons);
            this.panel1.Controls.Add(this.panelForFormLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 758);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.textBoxSearchProduct);
            this.panel2.Controls.Add(this.btnSearchProduct);
            this.panel2.Location = new System.Drawing.Point(17, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 66);
            this.panel2.TabIndex = 5;
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Location = new System.Drawing.Point(5, 23);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(420, 27);
            this.textBoxSearchProduct.TabIndex = 8;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.AutoSize = true;
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Location = new System.Drawing.Point(443, 11);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(100, 47);
            this.btnSearchProduct.TabIndex = 7;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // panelForTransitionToTable
            // 
            this.panelForTransitionToTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelForTransitionToTable.Controls.Add(this.btnExit);
            this.panelForTransitionToTable.Controls.Add(this.btnGoToSales);
            this.panelForTransitionToTable.Controls.Add(this.btnGoToClients);
            this.panelForTransitionToTable.Location = new System.Drawing.Point(579, 591);
            this.panelForTransitionToTable.Name = "panelForTransitionToTable";
            this.panelForTransitionToTable.Size = new System.Drawing.Size(747, 67);
            this.panelForTransitionToTable.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(490, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGoToSales
            // 
            this.btnGoToSales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToSales.Location = new System.Drawing.Point(236, 11);
            this.btnGoToSales.Name = "btnGoToSales";
            this.btnGoToSales.Size = new System.Drawing.Size(248, 47);
            this.btnGoToSales.TabIndex = 1;
            this.btnGoToSales.Text = "Go To Sales";
            this.btnGoToSales.UseVisualStyleBackColor = false;
            this.btnGoToSales.Click += new System.EventHandler(this.btnGoToSales_Click);
            // 
            // btnGoToClients
            // 
            this.btnGoToClients.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToClients.Location = new System.Drawing.Point(26, 12);
            this.btnGoToClients.Name = "btnGoToClients";
            this.btnGoToClients.Size = new System.Drawing.Size(194, 46);
            this.btnGoToClients.TabIndex = 0;
            this.btnGoToClients.Text = "Go To Clients";
            this.btnGoToClients.UseVisualStyleBackColor = false;
            this.btnGoToClients.Click += new System.EventHandler(this.btnGoToClients_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.Location = new System.Drawing.Point(435, 257);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(891, 271);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // panelForTxtBox
            // 
            this.panelForTxtBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelForTxtBox.Controls.Add(this.labelProductName);
            this.panelForTxtBox.Controls.Add(this.textBoxProductName);
            this.panelForTxtBox.Controls.Add(this.btnClearData);
            this.panelForTxtBox.Controls.Add(this.textBoxPieces);
            this.panelForTxtBox.Controls.Add(this.textBoxExpDate);
            this.panelForTxtBox.Controls.Add(this.textBoxPrice);
            this.panelForTxtBox.Controls.Add(this.textBoxDescription);
            this.panelForTxtBox.Controls.Add(this.textBoxModell);
            this.panelForTxtBox.Controls.Add(this.textBoxSKU);
            this.panelForTxtBox.Controls.Add(this.labelPieces);
            this.panelForTxtBox.Controls.Add(this.labelExpDate);
            this.panelForTxtBox.Controls.Add(this.labelPrice);
            this.panelForTxtBox.Controls.Add(this.labelDescription);
            this.panelForTxtBox.Controls.Add(this.labelModell);
            this.panelForTxtBox.Controls.Add(this.labelSKU);
            this.panelForTxtBox.Location = new System.Drawing.Point(17, 73);
            this.panelForTxtBox.Name = "panelForTxtBox";
            this.panelForTxtBox.Size = new System.Drawing.Size(386, 512);
            this.panelForTxtBox.TabIndex = 2;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(9, 99);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(136, 25);
            this.labelProductName.TabIndex = 14;
            this.labelProductName.Text = "Product Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(8, 128);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(360, 27);
            this.textBoxProductName.TabIndex = 13;
            // 
            // btnClearData
            // 
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearData.Location = new System.Drawing.Point(235, 10);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(133, 32);
            this.btnClearData.TabIndex = 12;
            this.btnClearData.Text = "Clear Fields";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // textBoxPieces
            // 
            this.textBoxPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPieces.Location = new System.Drawing.Point(11, 460);
            this.textBoxPieces.Name = "textBoxPieces";
            this.textBoxPieces.Size = new System.Drawing.Size(357, 30);
            this.textBoxPieces.TabIndex = 11;
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpDate.Location = new System.Drawing.Point(11, 399);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.Size = new System.Drawing.Size(357, 30);
            this.textBoxExpDate.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(11, 323);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(357, 30);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(11, 262);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(357, 30);
            this.textBoxDescription.TabIndex = 8;
            // 
            // textBoxModell
            // 
            this.textBoxModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModell.Location = new System.Drawing.Point(11, 188);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.Size = new System.Drawing.Size(357, 30);
            this.textBoxModell.TabIndex = 7;
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSKU.Location = new System.Drawing.Point(11, 64);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(357, 30);
            this.textBoxSKU.TabIndex = 6;
            this.textBoxSKU.TextChanged += new System.EventHandler(this.textBoxSKU_TextChanged);
            // 
            // labelPieces
            // 
            this.labelPieces.AutoSize = true;
            this.labelPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPieces.Location = new System.Drawing.Point(6, 430);
            this.labelPieces.Name = "labelPieces";
            this.labelPieces.Size = new System.Drawing.Size(77, 25);
            this.labelPieces.TabIndex = 5;
            this.labelPieces.Text = "Pieces:";
            this.labelPieces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpDate.Location = new System.Drawing.Point(6, 369);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(98, 25);
            this.labelExpDate.TabIndex = 4;
            this.labelExpDate.Text = "Exp.Date:";
            this.labelExpDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelExpDate.Click += new System.EventHandler(this.labelExpDate_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(7, 293);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 25);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(6, 232);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(115, 25);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description:";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModell
            // 
            this.labelModell.AutoSize = true;
            this.labelModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModell.Location = new System.Drawing.Point(7, 158);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(76, 25);
            this.labelModell.TabIndex = 1;
            this.labelModell.Text = "Modell:";
            this.labelModell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSKU
            // 
            this.labelSKU.AutoSize = true;
            this.labelSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSKU.Location = new System.Drawing.Point(3, 29);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(60, 25);
            this.labelSKU.TabIndex = 0;
            this.labelSKU.Text = "SKU:";
            this.labelSKU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelForButtons
            // 
            this.panelForButtons.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelForButtons.Controls.Add(this.dateTimePickerProducts);
            this.panelForButtons.Controls.Add(this.btnPrintProduct);
            this.panelForButtons.Controls.Add(this.btnView);
            this.panelForButtons.Controls.Add(this.btnExpDateMoreThan3M);
            this.panelForButtons.Controls.Add(this.btnExpIn24Hours);
            this.panelForButtons.Controls.Add(this.btnShowExpired);
            this.panelForButtons.Controls.Add(this.btnDeleteProduct);
            this.panelForButtons.Controls.Add(this.btnUpdateProduct);
            this.panelForButtons.Controls.Add(this.btnInsertProduct);
            this.panelForButtons.Location = new System.Drawing.Point(435, 9);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(891, 231);
            this.panelForButtons.TabIndex = 1;
            // 
            // dateTimePickerProducts
            // 
            this.dateTimePickerProducts.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePickerProducts.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePickerProducts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerProducts.Location = new System.Drawing.Point(671, 24);
            this.dateTimePickerProducts.Name = "dateTimePickerProducts";
            this.dateTimePickerProducts.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerProducts.TabIndex = 8;
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintProduct.Location = new System.Drawing.Point(277, 161);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(247, 40);
            this.btnPrintProduct.TabIndex = 7;
            this.btnPrintProduct.Text = "Print";
            this.btnPrintProduct.UseVisualStyleBackColor = true;
            this.btnPrintProduct.Click += new System.EventHandler(this.btnPrintProduct_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(28, 161);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(194, 40);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Refresh";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExpDateMoreThan3M
            // 
            this.btnExpDateMoreThan3M.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpDateMoreThan3M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpDateMoreThan3M.Location = new System.Drawing.Point(277, 110);
            this.btnExpDateMoreThan3M.Name = "btnExpDateMoreThan3M";
            this.btnExpDateMoreThan3M.Size = new System.Drawing.Size(247, 40);
            this.btnExpDateMoreThan3M.TabIndex = 5;
            this.btnExpDateMoreThan3M.Text = "Exp.Date  > 3 M";
            this.btnExpDateMoreThan3M.UseVisualStyleBackColor = false;
            this.btnExpDateMoreThan3M.Click += new System.EventHandler(this.btnExpDateMoreThan3M_Click);
            // 
            // btnExpIn24Hours
            // 
            this.btnExpIn24Hours.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExpIn24Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpIn24Hours.Location = new System.Drawing.Point(277, 16);
            this.btnExpIn24Hours.Name = "btnExpIn24Hours";
            this.btnExpIn24Hours.Size = new System.Drawing.Size(247, 42);
            this.btnExpIn24Hours.TabIndex = 4;
            this.btnExpIn24Hours.Text = "Expire in 24 hours";
            this.btnExpIn24Hours.UseVisualStyleBackColor = false;
            this.btnExpIn24Hours.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnShowExpired
            // 
            this.btnShowExpired.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowExpired.Location = new System.Drawing.Point(277, 64);
            this.btnShowExpired.Name = "btnShowExpired";
            this.btnShowExpired.Size = new System.Drawing.Size(247, 40);
            this.btnShowExpired.TabIndex = 3;
            this.btnShowExpired.Text = "Show expired products";
            this.btnShowExpired.UseVisualStyleBackColor = false;
            this.btnShowExpired.Click += new System.EventHandler(this.btnShowExpired_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(28, 110);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(194, 40);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(28, 64);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(194, 40);
            this.btnUpdateProduct.TabIndex = 1;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnInsertProduct
            // 
            this.btnInsertProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertProduct.Location = new System.Drawing.Point(28, 16);
            this.btnInsertProduct.Name = "btnInsertProduct";
            this.btnInsertProduct.Size = new System.Drawing.Size(194, 42);
            this.btnInsertProduct.TabIndex = 0;
            this.btnInsertProduct.Text = "Insert Product";
            this.btnInsertProduct.UseVisualStyleBackColor = false;
            this.btnInsertProduct.Click += new System.EventHandler(this.btnInsertProduct_Click);
            // 
            // panelForFormLabel
            // 
            this.panelForFormLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelForFormLabel.Controls.Add(this.labelProducts);
            this.panelForFormLabel.Location = new System.Drawing.Point(17, 9);
            this.panelForFormLabel.Name = "panelForFormLabel";
            this.panelForFormLabel.Size = new System.Drawing.Size(386, 56);
            this.panelForFormLabel.TabIndex = 0;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProducts.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProducts.Location = new System.Drawing.Point(20, 16);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProducts.Size = new System.Drawing.Size(114, 28);
            this.labelProducts.TabIndex = 0;
            this.labelProducts.Text = "Products";
            this.labelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printPreviewDialogProducts
            // 
            this.printPreviewDialogProducts.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProducts.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogProducts.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogProducts.Document = this.printDocument1;
            this.printPreviewDialogProducts.Enabled = true;
            this.printPreviewDialogProducts.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogProducts.Icon")));
            this.printPreviewDialogProducts.Name = "printPreviewDialog1";
            this.printPreviewDialogProducts.Visible = false;
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1399, 762);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelForTransitionToTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelForTxtBox.ResumeLayout(false);
            this.panelForTxtBox.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelForFormLabel.ResumeLayout(false);
            this.panelForFormLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelForTransitionToTable;
        private DataGridView dgvProducts;
        private Panel panelForTxtBox;
        private Label labelPieces;
        private Label labelExpDate;
        private Label labelPrice;
        private Label labelDescription;
        private Label labelModell;
        private Label labelSKU;
        private Panel panelForButtons;
        private Button btnExpDateMoreThan3M;
        private Button btnExpIn24Hours;
        private Button btnShowExpired;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnInsertProduct;
        private Panel panelForFormLabel;
        private Label labelProducts;
        private Button btnGoToSales;
        private Button btnGoToClients;
        private TextBox textBoxPieces;
        private TextBox textBoxExpDate;
        private TextBox textBoxPrice;
        private TextBox textBoxDescription;
        private TextBox textBoxModell;
        private TextBox textBoxSKU;
        private Button btnExit;
        private Button btnView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialogProducts;
        private Button btnSearchProduct;
        private Panel panel2;
        private TextBox textBoxSearchProduct;
        private Button btnPrintProduct;
        private Button btnClearData;
        private DateTimePicker dateTimePickerProducts;
        private Label labelProductName;
        private TextBox textBoxProductName;
    }
}

