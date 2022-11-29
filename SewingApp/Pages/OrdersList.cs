using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;

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

        private void dgOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgOrders.Columns["PayButton"].Index)
            {
                if (dgOrders.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    DialogResult dr = MessageBox.Show("Вы точно хотите оплатить заказ?",
                      "Оплата заказа", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {

                        int orderID = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells[0].Value);
                        Order order = Globals.DB.Order.Where(u => u.IdUser == 8 && u.Id == orderID).FirstOrDefault();
                        order.IdState = 6;

                        Globals.DB.SaveChanges();

                        dgOrders.DataSource = Globals.DB.Order.Where(u => u.IdUser == 8).ToList();
                    }
                }
            }
            else if (e.ColumnIndex == dgOrders.Columns["EditButton"].Index)
            {
                if (dgOrders.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    int orderID = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells[0].Value);
                    MainForm.Instance.PrimaryControl = new Pages.OrderEditMenu(orderID);
                }
            }
            else
            {
                if (orderBindingSource.DataSource is List<Order> dl)
                {
                    var tar = dl[e.RowIndex];
                    label1.Text = $"Заказ: {tar.Id}";
                    Globals.Context.CurrentOrder = tar;
                }
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            if (Globals.Context.CurrentOrder == null)
            {
                MessageBox.Show(
                    "Не выбран заказ!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }
            Globals.NavigateTo(new Pages.ProductConstructor());
        }

    }
}
