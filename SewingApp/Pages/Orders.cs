using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

            switch (Globals.Context.CurrentUser.IdRole)
            {

                case 1: // Заказчик
                    dgOrders.EnsureData(Globals.DB.Order.Where(u => u.IdUser == Globals.Context.CurrentUser.Id));
                    break;
                case 2:  // Менеджер
                    btnCreateOrder.Enabled = false;
                    dgOrders.EnsureData(Globals.DB.Order.Where(
                        u => u.IdManager == null
                        || u.IdManager == Globals.Context.CurrentUser.Id
                    ));
                    break;
            }

            dgOrders.EnsureComboBox(1, Globals.DB.User);
            dgOrders.EnsureComboBox(3, Globals.DB.OrderState);
            dgOrders.EnsureComboBox(4, Globals.DB.User);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Globals.Context.CurrentOrder = new Order
            {
                IdUser = Globals.Context.CurrentUser.Id
            };

            Globals.NavigateTo(new Pages.OrdersList());
        }
    }
}
