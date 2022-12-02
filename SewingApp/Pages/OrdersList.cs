using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

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
            Refill();
        }

        public void Refill()
        {
            dgOrders.EnsureData(Globals.DB.Order);
            dgOrders.EnsureComboBox(1, Globals.DB.User);
            dgOrders.EnsureComboBox(3, Globals.DB.OrderState);
            dgOrders.EnsureComboBox(4, Globals.DB.User);
        }

        private void dgOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgOrders.Columns["PayButton"].Index)
            {
                if (dgOrders.DataSource is List<Order> dl)
                {
                    var order = dl[e.RowIndex];
                    if (
                        MessageBox.Show(
                            "Вы точно хотите оплатить заказ?", "Оплата заказа", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        ) == DialogResult.Yes
                    )
                    {
                        order.IdState = 6;
                        Globals.DB.SaveChanges();

                        Refill();
                    }
                }
            }
            else if (e.ColumnIndex == dgOrders.Columns["EditButton"].Index)
            {
                if (dgOrders.DataSource is List<Order> dl)
                {
                    Globals.Context.CurrentOrder = dl[e.RowIndex];
                    Globals.NavigateTo(new Pages.OrderEditMenu());
                }
            }
            else if (e.ColumnIndex == dgOrders.Columns["CutButton"].Index)
            {
                if (dgOrders.DataSource is List<Order> dl)
                {
                    Globals.Context.CurrentOrder = dl[e.RowIndex];
                    Globals.NavigateTo(new Pages.Cutting());
                }
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Globals.Context.CurrentOrder = new Order
            {
                User = Globals.Context.CurrentUser,
                Date = DateTime.Now,
                IdState = 1,
                Price = 0,
            };
            Globals.NavigateTo(new Pages.OrderEditMenu());
        }
    }
}
