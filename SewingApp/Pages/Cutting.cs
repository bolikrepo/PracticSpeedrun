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
    public partial class Cutting : UserControl
    {
        public Cutting()
        {
            InitializeComponent();

            Globals.DB.OrderItem.Load();
            Globals.DB.Fabric.Load();
            Globals.DB.Furniture.Load();
            Globals.DB.Unit.Load();
            Globals.DB.Product.Load();
            Globals.DB.Order.Load();

            orderItemBindingSource.DataSource = Globals.DB.OrderItem.Local.ToList();
            fabricBindingSource.DataSource = Globals.DB.Fabric.Local.ToList();
            furnitureBindingSource.DataSource = Globals.DB.Furniture.Local.ToList();
            unitBindingSource.DataSource = Globals.DB.Unit.Local.ToList();
            productBindingSource.DataSource = Globals.DB.Product.Local.ToList();

            dataGridView1.DataSource = Globals.DB.OrderItem.Where(u => u.IdOrder == Globals.Context.CurrentUser.Id).ToList();
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cutting_Load(object sender, EventArgs e)
        {

        }

        private void Cutting_Load_1(object sender, EventArgs e)
        {

        }
    }
}
