using System.Linq;
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
            dgProductList.DataSource = Globals.DB.Product.Local.ToList();
        }
    }
}
