using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SewingApp.Pages
{
    public partial class CustomerViewMenu : UserControl
    {
        public CustomerViewMenu()
        {
            InitializeComponent();

            Globals.DB.OrderState.Load();

            orderStateBindingSource.DataSource = Globals.DB.OrderState.Local.ToBindingList();

        }

        private void CustomerViewMenu_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Globals.DB.Order.Where(u => u.IdUser == 8).ToList();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
            {
                e.ThrowException = false;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["PaymentButton"].Index)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    DialogResult dr = MessageBox.Show("Вы точно хотите оплатить заказ?",
                      "Оплата заказа", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes) { 

                        int orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        Order order = Globals.DB.Order.Where(u => u.IdUser == 8 && u.Id == orderID).FirstOrDefault();
                        order.IdState = 6;

                        Globals.DB.SaveChanges();

                        dataGridView1.DataSource = Globals.DB.Order.Where(u => u.IdUser == 8).ToList();
                    }
                }
            }
        }
    }
}
