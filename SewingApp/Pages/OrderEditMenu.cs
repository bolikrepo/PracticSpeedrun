using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SewingApp.Pages
{
    public partial class OrderEditMenu : UserControl
    {
        private int orderID = -1;

        public OrderEditMenu(int orderID)
        {
            InitializeComponent();

            Globals.DB.OrderItem.Load();
            Globals.DB.Fabric.Load();
            Globals.DB.Furniture.Load();
            Globals.DB.Unit.Load();
            Globals.DB.Product.Load();
            Globals.DB.Order.Load();

            this.orderID = orderID;
        }

        private void OrderEditMenu_Load(object sender, EventArgs e)
        {
            orderItemBindingSource.DataSource = Globals.DB.OrderItem.Local.ToList();
            fabricBindingSource.DataSource = Globals.DB.Fabric.Local.ToList();
            furnitureBindingSource.DataSource = Globals.DB.Furniture.Local.ToList();
            unitBindingSource.DataSource = Globals.DB.Unit.Local.ToList();
            productBindingSource.DataSource = Globals.DB.Product.Local.ToList();

            dataGridView1.DataSource = Globals.DB.OrderItem.Where(u => u.IdOrder == this.orderID).ToList();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            Globals.NavigateToRoleMenu();
        }
    }
}
