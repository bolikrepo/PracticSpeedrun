using System;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class OrdersList : UserControl
    {
        public OrdersList()
        {
            InitializeComponent();
        }

        private void OrdersList_Load(object sender, EventArgs e)
        {
            dgOrders.DataSource = Globals.DB.OrderItem.Local.ToList();
        }
    }
}
