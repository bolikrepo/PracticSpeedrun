
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
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.PayButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateOrder.Location = new System.Drawing.Point(0, 6);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(204, 26);
            this.btnCreateOrder.TabIndex = 3;
            this.btnCreateOrder.Text = "Оформить заказ";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // dgOrders
            // 
            this.dgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayButton,
            this.EditButton});
            this.dgOrders.Location = new System.Drawing.Point(-4, 37);
            this.dgOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.Size = new System.Drawing.Size(804, 408);
            this.dgOrders.TabIndex = 2;
            this.dgOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrders_CellMouseClick);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.dgOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrdersList";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.OrdersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.DataGridViewButtonColumn PayButton;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
    }
}
