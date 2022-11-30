using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;

namespace SewingApp.Pages
{
    public partial class OrderEditMenu : UserControl
    {
        public Order Order { get; }

        public OrderEditMenu(Order order)
        {
            InitializeComponent();
            Order = order;
        }

        private void OrderEditMenu_Load(object sender, EventArgs e)
        {
            Refill();
        }

        private void Refill()
        {
            dataGridView1.EnsureData(
                Globals.DB.OrderItem.Where(or => or.IdOrder == Order.Id),
                hidden: new[] { 1 },
                canEdit: true
            );
            dataGridView1.EnsureComboBox(2, Globals.DB.Product);
            dataGridView1.EnsureComboBox(3, Globals.DB.Fabric);
            dataGridView1.EnsureComboBox(4, Globals.DB.Furniture);

            dataGridView1.EnsureComboBox(7, Globals.DB.Unit);
            dataGridView1.EnsureComboBox(9, Globals.DB.Unit);
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

        private void button1_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as List<OrderItem>).Add(
                new OrderItem
                {
                    IdOrder = Order.Id,
                }
            );

            //Refill();
        }
    }
}
