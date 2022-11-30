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
        public Order Order { get; }

        public OrderEditMenu(Order order)
        {
            InitializeComponent();

            Globals.DB.OrderItem.Load();
            Globals.DB.Fabric.Load();
            Globals.DB.Furniture.Load();
            Globals.DB.Unit.Load();
            Globals.DB.Product.Load();
            Globals.DB.Order.Load();

            Order = order;
        }

        private void OrderEditMenu_Load(object sender, EventArgs e)
        {
            orderItemBindingSource.DataSource = Globals.DB.OrderItem.Local.ToList();
            fabricBindingSource.DataSource = Globals.DB.Fabric.Local.ToList();
            furnitureBindingSource.DataSource = Globals.DB.Furniture.Local.ToList();
            unitBindingSource.DataSource = Globals.DB.Unit.Local.ToList();
            productBindingSource.DataSource = Globals.DB.Product.Local.ToList();

            dataGridView1.DataSource = Globals.DB.OrderItem.Where(u => u.IdOrder == Order.Id).ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Globals.NavigateToRoleMenu();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.DB.SaveChanges();
            Globals.NavigateToRoleMenu();
        }
    }
}
