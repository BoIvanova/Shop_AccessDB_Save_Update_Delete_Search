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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelForTextBoxes = new System.Windows.Forms.Panel();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.panelLabelProducts = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSKU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.txtbSKU = new System.Windows.Forms.TextBox();
            this.txtbModell = new System.Windows.Forms.TextBox();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbExp_Date = new System.Windows.Forms.TextBox();
            this.txtbPieces = new System.Windows.Forms.TextBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExpiredProduct = new System.Windows.Forms.Button();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelPieces = new System.Windows.Forms.Label();
            this.btnExpiredIn24Hours = new System.Windows.Forms.Button();
            this.btnExpDateMoreThan3m = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnGoToClients = new System.Windows.Forms.Button();
            this.btnGoToSales = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelForTextBoxes.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.panelLabelProducts.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelLabelProducts);
            this.panel1.Controls.Add(this.panelForButtons);
            this.panel1.Controls.Add(this.panelForTextBoxes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 919);
            this.panel1.TabIndex = 0;
            // 
            // panelForTextBoxes
            // 
            this.panelForTextBoxes.BackColor = System.Drawing.SystemColors.Control;
            this.panelForTextBoxes.Controls.Add(this.dataGridViewProducts);
            this.panelForTextBoxes.Controls.Add(this.txtbPieces);
            this.panelForTextBoxes.Controls.Add(this.txtbExp_Date);
            this.panelForTextBoxes.Controls.Add(this.txtbPrice);
            this.panelForTextBoxes.Controls.Add(this.txtbDescription);
            this.panelForTextBoxes.Controls.Add(this.txtbModell);
            this.panelForTextBoxes.Controls.Add(this.txtbSKU);
            this.panelForTextBoxes.Controls.Add(this.labelPieces);
            this.panelForTextBoxes.Controls.Add(this.labelExpDate);
            this.panelForTextBoxes.Controls.Add(this.labelPrice);
            this.panelForTextBoxes.Controls.Add(this.labelDescription);
            this.panelForTextBoxes.Controls.Add(this.labelModell);
            this.panelForTextBoxes.Controls.Add(this.labelSKU);
            this.panelForTextBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForTextBoxes.Location = new System.Drawing.Point(3, 115);
            this.panelForTextBoxes.Name = "panelForTextBoxes";
            this.panelForTextBoxes.Size = new System.Drawing.Size(797, 778);
            this.panelForTextBoxes.TabIndex = 1;
            this.panelForTextBoxes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelForButtons
            // 
            this.panelForButtons.BackColor = System.Drawing.SystemColors.Control;
            this.panelForButtons.Controls.Add(this.btnGoToSales);
            this.panelForButtons.Controls.Add(this.btnGoToClients);
            this.panelForButtons.Controls.Add(this.btnExpDateMoreThan3m);
            this.panelForButtons.Controls.Add(this.textBox8);
            this.panelForButtons.Controls.Add(this.btnExpiredIn24Hours);
            this.panelForButtons.Controls.Add(this.btnExpiredProduct);
            this.panelForButtons.Controls.Add(this.btnDeleteProduct);
            this.panelForButtons.Controls.Add(this.btnUpdateProduct);
            this.panelForButtons.Controls.Add(this.btnAddProduct);
            this.panelForButtons.Controls.Add(this.lblSearchProduct);
            this.panelForButtons.Location = new System.Drawing.Point(824, 278);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(426, 615);
            this.panelForButtons.TabIndex = 2;
            // 
            // panelLabelProducts
            // 
            this.panelLabelProducts.BackColor = System.Drawing.SystemColors.Control;
            this.panelLabelProducts.Controls.Add(this.labelProducts);
            this.panelLabelProducts.Controls.Add(this.label2);
            this.panelLabelProducts.Location = new System.Drawing.Point(3, 16);
            this.panelLabelProducts.Name = "panelLabelProducts";
            this.panelLabelProducts.Size = new System.Drawing.Size(1247, 82);
            this.panelLabelProducts.TabIndex = 2;
            this.panelLabelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(824, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 138);
            this.panel5.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(15, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(397, 42);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 111);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelSKU
            // 
            this.labelSKU.AutoSize = true;
            this.labelSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSKU.Location = new System.Drawing.Point(18, 10);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(110, 49);
            this.labelSKU.TabIndex = 0;
            this.labelSKU.Text = "SKU";
            this.labelSKU.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 65);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(502, 11);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(209, 54);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "Products";
            this.labelProducts.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbSKU
            // 
            this.txtbSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSKU.Location = new System.Drawing.Point(176, 10);
            this.txtbSKU.Multiline = true;
            this.txtbSKU.Name = "txtbSKU";
            this.txtbSKU.Size = new System.Drawing.Size(604, 42);
            this.txtbSKU.TabIndex = 0;
            this.txtbSKU.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbModell
            // 
            this.txtbModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbModell.Location = new System.Drawing.Point(176, 67);
            this.txtbModell.Multiline = true;
            this.txtbModell.Name = "txtbModell";
            this.txtbModell.Size = new System.Drawing.Size(604, 42);
            this.txtbModell.TabIndex = 0;
            this.txtbModell.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbDescription
            // 
            this.txtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescription.Location = new System.Drawing.Point(176, 124);
            this.txtbDescription.Multiline = true;
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(604, 42);
            this.txtbDescription.TabIndex = 0;
            this.txtbDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbPrice
            // 
            this.txtbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrice.Location = new System.Drawing.Point(176, 183);
            this.txtbPrice.Multiline = true;
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(604, 42);
            this.txtbPrice.TabIndex = 0;
            this.txtbPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbExp_Date
            // 
            this.txtbExp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbExp_Date.Location = new System.Drawing.Point(176, 243);
            this.txtbExp_Date.Multiline = true;
            this.txtbExp_Date.Name = "txtbExp_Date";
            this.txtbExp_Date.Size = new System.Drawing.Size(604, 42);
            this.txtbExp_Date.TabIndex = 0;
            this.txtbExp_Date.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbPieces
            // 
            this.txtbPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPieces.Location = new System.Drawing.Point(176, 312);
            this.txtbPieces.Multiline = true;
            this.txtbPieces.Name = "txtbPieces";
            this.txtbPieces.Size = new System.Drawing.Size(604, 42);
            this.txtbPieces.TabIndex = 0;
            this.txtbPieces.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(15, 51);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(397, 43);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(15, 100);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(397, 41);
            this.btnDeleteProduct.TabIndex = 0;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExpiredProduct
            // 
            this.btnExpiredProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiredProduct.Location = new System.Drawing.Point(15, 147);
            this.btnExpiredProduct.Name = "btnExpiredProduct";
            this.btnExpiredProduct.Size = new System.Drawing.Size(397, 44);
            this.btnExpiredProduct.TabIndex = 0;
            this.btnExpiredProduct.Text = "Show expired";
            this.btnExpiredProduct.UseVisualStyleBackColor = true;
            this.btnExpiredProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelModell
            // 
            this.labelModell.AutoSize = true;
            this.labelModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModell.Location = new System.Drawing.Point(18, 70);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(148, 49);
            this.labelModell.TabIndex = 0;
            this.labelModell.Text = "Modell";
            this.labelModell.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(18, 127);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(189, 49);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Descript.";
            this.labelDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(18, 183);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(119, 49);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpDate.Location = new System.Drawing.Point(18, 243);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(196, 49);
            this.labelExpDate.TabIndex = 0;
            this.labelExpDate.Text = "Exp.Date";
            this.labelExpDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPieces
            // 
            this.labelPieces.AutoSize = true;
            this.labelPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPieces.Location = new System.Drawing.Point(18, 312);
            this.labelPieces.Name = "labelPieces";
            this.labelPieces.Size = new System.Drawing.Size(104, 49);
            this.labelPieces.TabIndex = 0;
            this.labelPieces.Text = "Pcs.";
            this.labelPieces.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExpiredIn24Hours
            // 
            this.btnExpiredIn24Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpiredIn24Hours.Location = new System.Drawing.Point(15, 197);
            this.btnExpiredIn24Hours.Name = "btnExpiredIn24Hours";
            this.btnExpiredIn24Hours.Size = new System.Drawing.Size(397, 41);
            this.btnExpiredIn24Hours.TabIndex = 0;
            this.btnExpiredIn24Hours.Text = "Expired in 24 hours";
            this.btnExpiredIn24Hours.UseVisualStyleBackColor = true;
            this.btnExpiredIn24Hours.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExpDateMoreThan3m
            // 
            this.btnExpDateMoreThan3m.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpDateMoreThan3m.Location = new System.Drawing.Point(15, 244);
            this.btnExpDateMoreThan3m.Name = "btnExpDateMoreThan3m";
            this.btnExpDateMoreThan3m.Size = new System.Drawing.Size(397, 45);
            this.btnExpDateMoreThan3m.TabIndex = 0;
            this.btnExpDateMoreThan3m.Text = "Exp. Date > 3 Months";
            this.btnExpDateMoreThan3m.UseVisualStyleBackColor = true;
            this.btnExpDateMoreThan3m.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(21, 394);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(775, 372);
            this.dataGridViewProducts.TabIndex = 1;
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.BackColor = System.Drawing.SystemColors.Control;
            this.lblSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(15, 319);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(140, 40);
            this.lblSearchProduct.TabIndex = 0;
            this.lblSearchProduct.Text = "Search:";
            this.lblSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSearchProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(15, 362);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(406, 41);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGoToClients
            // 
            this.btnGoToClients.Location = new System.Drawing.Point(21, 521);
            this.btnGoToClients.Name = "btnGoToClients";
            this.btnGoToClients.Size = new System.Drawing.Size(153, 52);
            this.btnGoToClients.TabIndex = 1;
            this.btnGoToClients.Text = "Go To Clients";
            this.btnGoToClients.UseVisualStyleBackColor = true;
            this.btnGoToClients.Click += new System.EventHandler(this.btnGoToClients_Click);
            // 
            // btnGoToSales
            // 
            this.btnGoToSales.Location = new System.Drawing.Point(240, 521);
            this.btnGoToSales.Name = "btnGoToSales";
            this.btnGoToSales.Size = new System.Drawing.Size(172, 52);
            this.btnGoToSales.TabIndex = 1;
            this.btnGoToSales.Text = "Go To Sales";
            this.btnGoToSales.UseVisualStyleBackColor = true;
            this.btnGoToSales.Click += new System.EventHandler(this.btnGoToSales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 941);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelForTextBoxes.ResumeLayout(false);
            this.panelForTextBoxes.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
            this.panelForButtons.PerformLayout();
            this.panelLabelProducts.ResumeLayout(false);
            this.panelLabelProducts.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelForTextBoxes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLabelProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelForButtons;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button btnExpiredProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox txtbPieces;
        private System.Windows.Forms.TextBox txtbExp_Date;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.TextBox txtbModell;
        private System.Windows.Forms.TextBox txtbSKU;
        private System.Windows.Forms.Label labelPieces;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.Button btnExpDateMoreThan3m;
        private System.Windows.Forms.Button btnExpiredIn24Hours;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnGoToSales;
        private System.Windows.Forms.Button btnGoToClients;
    }
}

