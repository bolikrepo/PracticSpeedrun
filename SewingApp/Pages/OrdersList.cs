using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace SewingApp.Pages
{
    public partial class OrdersList : UserControl
    {
        public OrdersList()
        {
            InitializeComponent();

            Globals.DB.OrderState.Load();
            Globals.DB.Order.Load();
        }

        private void OrdersList_Load(object sender, EventArgs e)
        {
            orderStateBindingSource.DataSource = Globals.DB.OrderState.Local.ToList();
            orderBindingSource.DataSource = Globals.DB.Order.Local.ToList();
        }
    }
}
