using System;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class MenuStockman : UserControl
    {
        public MenuStockman()
        {
            InitializeComponent();
        }

        private void Stockman_Load(object sender, EventArgs e)
        {
            dgFabric.DataSource = Globals.DB.Fabric.Local;
            dgFurniture.DataSource = Globals.DB.Furniture.Local;
        }
    }
}
