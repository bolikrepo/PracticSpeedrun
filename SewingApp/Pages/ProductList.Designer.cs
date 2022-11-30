
namespace SewingApp.Pages
{
    partial class ProductList
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
            this.dgProductList = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductList
            // 
            this.dgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image});
            this.dgProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductList.Location = new System.Drawing.Point(0, 0);
            this.dgProductList.Name = "dgProductList";
            this.dgProductList.Size = new System.Drawing.Size(800, 450);
            this.dgProductList.TabIndex = 0;
            this.dgProductList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProductList_CellFormatting);
            // 
            // image
            // 
            this.image.HeaderText = "Изображение";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgProductList);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductList;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}
