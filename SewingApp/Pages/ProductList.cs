using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();

            Globals.DB.Product.Load();
        }

        private void ProductList_Load(object sender, System.EventArgs e)
        {
            dgProductList.DataSource = Globals.DB.Product.Local.ToList();
        }
    }
}
