namespace ООО_Flowers
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.btnAuthriz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flawersDataSet1 = new ООО_Flowers.flawersDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_TableAdapter = new ООО_Flowers.flawersDataSet1TableAdapters.Product_TableAdapter();
            this.productArticleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оProductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.едизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flawersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAuthriz
            // 
            this.btnAuthriz.BackColor = System.Drawing.Color.Green;
            this.btnAuthriz.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthriz.ForeColor = System.Drawing.Color.Black;
            this.btnAuthriz.Location = new System.Drawing.Point(669, 391);
            this.btnAuthriz.Name = "btnAuthriz";
            this.btnAuthriz.Size = new System.Drawing.Size(119, 47);
            this.btnAuthriz.TabIndex = 0;
            this.btnAuthriz.Text = "Авторизация";
            this.btnAuthriz.UseVisualStyleBackColor = false;
            this.btnAuthriz.Click += new System.EventHandler(this.btnAuthriz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productArticleNumberDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.оProductDescriptionDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productPhotoDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.productDiscountAmountDataGridViewTextBoxColumn,
            this.productQuantityInStockDataGridViewTextBoxColumn,
            this.едизмеренияDataGridViewTextBoxColumn,
            this.productStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // flawersDataSet1
            // 
            this.flawersDataSet1.DataSetName = "flawersDataSet1";
            this.flawersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product$";
            this.productBindingSource.DataSource = this.flawersDataSet1;
            // 
            // product_TableAdapter
            // 
            this.product_TableAdapter.ClearBeforeFill = true;
            // 
            // productArticleNumberDataGridViewTextBoxColumn
            // 
            this.productArticleNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.HeaderText = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.Name = "productArticleNumberDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // оProductDescriptionDataGridViewTextBoxColumn
            // 
            this.оProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ОProductDescription";
            this.оProductDescriptionDataGridViewTextBoxColumn.HeaderText = "ОProductDescription";
            this.оProductDescriptionDataGridViewTextBoxColumn.Name = "оProductDescriptionDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productPhotoDataGridViewTextBoxColumn
            // 
            this.productPhotoDataGridViewTextBoxColumn.DataPropertyName = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.HeaderText = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.Name = "productPhotoDataGridViewTextBoxColumn";
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            // 
            // productDiscountAmountDataGridViewTextBoxColumn
            // 
            this.productDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.HeaderText = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.Name = "productDiscountAmountDataGridViewTextBoxColumn";
            // 
            // productQuantityInStockDataGridViewTextBoxColumn
            // 
            this.productQuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.HeaderText = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.Name = "productQuantityInStockDataGridViewTextBoxColumn";
            // 
            // едизмеренияDataGridViewTextBoxColumn
            // 
            this.едизмеренияDataGridViewTextBoxColumn.DataPropertyName = "ед_измерения";
            this.едизмеренияDataGridViewTextBoxColumn.HeaderText = "ед_измерения";
            this.едизмеренияDataGridViewTextBoxColumn.Name = "едизмеренияDataGridViewTextBoxColumn";
            // 
            // productStatusDataGridViewTextBoxColumn
            // 
            this.productStatusDataGridViewTextBoxColumn.DataPropertyName = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.HeaderText = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.Name = "productStatusDataGridViewTextBoxColumn";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAuthriz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flawersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthriz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private flawersDataSet1 flawersDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private flawersDataSet1TableAdapters.Product_TableAdapter product_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productArticleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оProductDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPhotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn едизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusDataGridViewTextBoxColumn;
    }
}