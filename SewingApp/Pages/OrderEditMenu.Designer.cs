namespace SewingApp.Pages
{
    partial class OrderEditMenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sewingDBDataSet = new SewingApp.SewingDBDataSet();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemTableAdapter = new SewingApp.SewingDBDataSetTableAdapters.OrderItemTableAdapter();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new SewingApp.SewingDBDataSetTableAdapters.ProductTableAdapter();
            this.fabricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricTableAdapter = new SewingApp.SewingDBDataSetTableAdapters.FabricTableAdapter();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureTableAdapter = new SewingApp.SewingDBDataSetTableAdapters.FurnitureTableAdapter();
            this.sewingDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitTableAdapter = new SewingApp.SewingDBDataSetTableAdapters.UnitTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idFabricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idFurnitureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idBorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnitWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotationAngleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewingDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idProductDataGridViewTextBoxColumn,
            this.idFabricDataGridViewTextBoxColumn,
            this.idFurnitureDataGridViewTextBoxColumn,
            this.idBorderDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.idUnitWidthDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.rotationAngleDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // sewingDBDataSet
            // 
            this.sewingDBDataSet.DataSetName = "SewingDBDataSet";
            this.sewingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "OrderItem";
            this.orderItemBindingSource.DataSource = this.sewingDBDataSet;
            // 
            // orderItemTableAdapter
            // 
            this.orderItemTableAdapter.ClearBeforeFill = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateOrder.Location = new System.Drawing.Point(16, 14);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(141, 28);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "Назад";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.BtnCreateOrder_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sewingDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // fabricBindingSource
            // 
            this.fabricBindingSource.DataMember = "Fabric";
            this.fabricBindingSource.DataSource = this.sewingDBDataSet;
            // 
            // fabricTableAdapter
            // 
            this.fabricTableAdapter.ClearBeforeFill = true;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "Furniture";
            this.furnitureBindingSource.DataSource = this.sewingDBDataSet;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // sewingDBDataSetBindingSource
            // 
            this.sewingDBDataSetBindingSource.DataSource = this.sewingDBDataSet;
            this.sewingDBDataSetBindingSource.Position = 0;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.sewingDBDataSet;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            this.idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            this.idProductDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.idProductDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idProductDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            this.idProductDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProductDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProductDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // idFabricDataGridViewTextBoxColumn
            // 
            this.idFabricDataGridViewTextBoxColumn.DataPropertyName = "IdFabric";
            this.idFabricDataGridViewTextBoxColumn.DataSource = this.fabricBindingSource;
            this.idFabricDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idFabricDataGridViewTextBoxColumn.HeaderText = "Фабрика";
            this.idFabricDataGridViewTextBoxColumn.Name = "idFabricDataGridViewTextBoxColumn";
            this.idFabricDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idFabricDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idFabricDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // idFurnitureDataGridViewTextBoxColumn
            // 
            this.idFurnitureDataGridViewTextBoxColumn.DataPropertyName = "IdFurniture";
            this.idFurnitureDataGridViewTextBoxColumn.DataSource = this.furnitureBindingSource;
            this.idFurnitureDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idFurnitureDataGridViewTextBoxColumn.HeaderText = "Фурнитура";
            this.idFurnitureDataGridViewTextBoxColumn.Name = "idFurnitureDataGridViewTextBoxColumn";
            this.idFurnitureDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idFurnitureDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idFurnitureDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // idBorderDataGridViewTextBoxColumn
            // 
            this.idBorderDataGridViewTextBoxColumn.DataPropertyName = "IdBorder";
            this.idBorderDataGridViewTextBoxColumn.HeaderText = "IdBorder";
            this.idBorderDataGridViewTextBoxColumn.Name = "idBorderDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // idUnitWidthDataGridViewTextBoxColumn
            // 
            this.idUnitWidthDataGridViewTextBoxColumn.DataPropertyName = "IdUnitWidth";
            this.idUnitWidthDataGridViewTextBoxColumn.DataSource = this.unitBindingSource;
            this.idUnitWidthDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idUnitWidthDataGridViewTextBoxColumn.HeaderText = "Ед. Изм.";
            this.idUnitWidthDataGridViewTextBoxColumn.Name = "idUnitWidthDataGridViewTextBoxColumn";
            this.idUnitWidthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUnitWidthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUnitWidthDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // rotationAngleDataGridViewTextBoxColumn
            // 
            this.rotationAngleDataGridViewTextBoxColumn.DataPropertyName = "RotationAngle";
            this.rotationAngleDataGridViewTextBoxColumn.HeaderText = "RotationAngle";
            this.rotationAngleDataGridViewTextBoxColumn.Name = "rotationAngleDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // OrderEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderEditMenu";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.OrderEditMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewingDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private SewingDBDataSet sewingDBDataSet;
        private SewingDBDataSetTableAdapters.OrderItemTableAdapter orderItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idFabricDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fabricBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idFurnitureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUnitWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotationAngleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCreateOrder;
        private SewingDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private SewingDBDataSetTableAdapters.FabricTableAdapter fabricTableAdapter;
        private SewingDBDataSetTableAdapters.FurnitureTableAdapter furnitureTableAdapter;
        private System.Windows.Forms.BindingSource sewingDBDataSetBindingSource;
        private SewingDBDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
    }
}
