using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    dgOrders.DataSource = Globals.DB.Order.Where(u => u.IdUser == Globals.Context.CurrentUser.Id).ToList();
                    break;
                case 2:  // Менеджер
                    btnCreateOrder.Enabled = false;
                    dgOrders.DataSource = Globals.DB.Order.Where(
                        u => u.IdManager == null 
                        || u.IdManager == Globals.Context.CurrentUser.Id
                    ).ToList();
                    break;
            }

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
