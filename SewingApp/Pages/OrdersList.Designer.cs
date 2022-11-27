
namespace SewingApp.Pages
{
    partial class OrdersList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sewingDBDataSet = new SewingApp.SewingDBDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new SewingApp.SewingDBDataSetTableAdapters.OrderTableAdapter();
            this.orderStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderStateTableAdapter = new SewingApp.SewingDBDataSetTableAdapters.OrderStateTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateOrder.Location = new System.Drawing.Point(0, 4);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(163, 28);
            this.btnCreateOrder.TabIndex = 3;
            this.btnCreateOrder.Text = "Оформить заказ";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // dgOrders
            // 
            this.dgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrders.AutoGenerateColumns = false;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idStateDataGridViewTextBoxColumn,
            this.idManagerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.PayButton,
            this.EditButton});
            this.dgOrders.DataSource = this.orderBindingSource;
            this.dgOrders.Location = new System.Drawing.Point(0, 38);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(800, 409);
            this.dgOrders.TabIndex = 2;
            this.dgOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrders_CellMouseClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(650, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateProduct.Location = new System.Drawing.Point(169, 4);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(163, 28);
            this.btnCreateProduct.TabIndex = 5;
            this.btnCreateProduct.Text = "Новое изделие";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(338, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заказ:";
            // 
            // sewingDBDataSet
            // 
            this.sewingDBDataSet.DataSetName = "SewingDBDataSet";
            this.sewingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.sewingDBDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderStateBindingSource
            // 
            this.orderStateBindingSource.DataMember = "OrderState";
            this.orderStateBindingSource.DataSource = this.sewingDBDataSet;
            // 
            // orderStateTableAdapter
            // 
            this.orderStateTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // idStateDataGridViewTextBoxColumn
            // 
            this.idStateDataGridViewTextBoxColumn.DataPropertyName = "IdState";
            this.idStateDataGridViewTextBoxColumn.DataSource = this.orderStateBindingSource;
            this.idStateDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.idStateDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.idStateDataGridViewTextBoxColumn.Name = "idStateDataGridViewTextBoxColumn";
            this.idStateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idStateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idStateDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // idManagerDataGridViewTextBoxColumn
            // 
            this.idManagerDataGridViewTextBoxColumn.DataPropertyName = "IdManager";
            this.idManagerDataGridViewTextBoxColumn.HeaderText = "Менеджер";
            this.idManagerDataGridViewTextBoxColumn.Name = "idManagerDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // PayButton
            // 
            this.PayButton.HeaderText = "Оплатить";
            this.PayButton.Name = "PayButton";
            this.PayButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PayButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PayButton.UseColumnTextForButtonValue = true;
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "Редактировать";
            this.EditButton.Name = "EditButton";
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // OrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.dgOrders);
            this.Name = "OrdersList";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.OrdersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sewingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource orderStateBindingSource;
        private SewingDBDataSet sewingDBDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private SewingDBDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private SewingDBDataSetTableAdapters.OrderStateTableAdapter orderStateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn PayButton;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
    }
}
