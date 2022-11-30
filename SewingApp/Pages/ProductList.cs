using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, System.EventArgs e)
        {
            dgProductList.EnsureData(Globals.DB.Product);

        }

        private void dgProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0) {
                try
                {
                    e.Value = Bitmap.FromFile(Path.Combine(Globals.ImagesPath, $"Polyfills/Product/{(dgProductList.DataSource as List<Product>)[e.RowIndex].Id}.JPG"));
                }
                catch
                {
                    e.Value = Bitmap.FromFile(Path.Combine(Globals.ImagesPath, "System/no-image.jpg"));
                }
                e.FormattingApplied = true;
            }
        }

        private void dgProductList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.ThrowException = false;
                e.Cancel = true;
            }
        }
    }
}
