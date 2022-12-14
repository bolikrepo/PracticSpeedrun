
namespace SewingApp.Pages
{
    partial class MenuStockman
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgFabric = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgFurniture = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDocsApply = new System.Windows.Forms.Button();
            this.btnUploadDocs = new System.Windows.Forms.Button();
            this.dgSupply = new System.Windows.Forms.DataGridView();
            this.lbSupplyDocs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFabric)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFurniture)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupply)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgFabric);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Ткани";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgFabric
            // 
            this.dgFabric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFabric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFabric.Location = new System.Drawing.Point(0, 0);
            this.dgFabric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgFabric.Name = "dgFabric";
            this.dgFabric.Size = new System.Drawing.Size(792, 417);
            this.dgFabric.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgFurniture);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 417);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Фурнитура";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgFurniture
            // 
            this.dgFurniture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFurniture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFurniture.Location = new System.Drawing.Point(0, 0);
            this.dgFurniture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgFurniture.Name = "dgFurniture";
            this.dgFurniture.Size = new System.Drawing.Size(792, 417);
            this.dgFurniture.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Обработка поставок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDocsApply);
            this.splitContainer1.Panel1.Controls.Add(this.btnUploadDocs);
            this.splitContainer1.Panel1.Controls.Add(this.dgSupply);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbSupplyDocs);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(792, 417);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnDocsApply
            // 
            this.btnDocsApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDocsApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDocsApply.Location = new System.Drawing.Point(3, 387);
            this.btnDocsApply.Name = "btnDocsApply";
            this.btnDocsApply.Size = new System.Drawing.Size(223, 22);
            this.btnDocsApply.TabIndex = 2;
            this.btnDocsApply.Text = "Проверить документы";
            this.btnDocsApply.UseVisualStyleBackColor = true;
            this.btnDocsApply.Visible = false;
            this.btnDocsApply.Click += new System.EventHandler(this.btnApplyDocs_Click);
            // 
            // btnUploadDocs
            // 
            this.btnUploadDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUploadDocs.Location = new System.Drawing.Point(3, 0);
            this.btnUploadDocs.Name = "btnUploadDocs";
            this.btnUploadDocs.Size = new System.Drawing.Size(153, 26);
            this.btnUploadDocs.TabIndex = 1;
            this.btnUploadDocs.Text = "Загрузить файл";
            this.btnUploadDocs.UseVisualStyleBackColor = true;
            this.btnUploadDocs.Click += new System.EventHandler(this.btnUploadDocs_Click);
            // 
            // dgSupply
            // 
            this.dgSupply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupply.Location = new System.Drawing.Point(0, 34);
            this.dgSupply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSupply.Name = "dgSupply";
            this.dgSupply.Size = new System.Drawing.Size(383, 345);
            this.dgSupply.TabIndex = 0;
            // 
            // lbSupplyDocs
            // 
            this.lbSupplyDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSupplyDocs.FormattingEnabled = true;
            this.lbSupplyDocs.ItemHeight = 20;
            this.lbSupplyDocs.Location = new System.Drawing.Point(1, 25);
            this.lbSupplyDocs.Name = "lbSupplyDocs";
            this.lbSupplyDocs.Size = new System.Drawing.Size(392, 384);
            this.lbSupplyDocs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Документы принятые на учет";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(630, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MenuStockman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuStockman";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.Stockman_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFabric)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFurniture)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSupply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgFabric;
        private System.Windows.Forms.DataGridView dgFurniture;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgSupply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSupplyDocs;
        private System.Windows.Forms.Button btnUploadDocs;
        private System.Windows.Forms.Button btnDocsApply;
    }
}
