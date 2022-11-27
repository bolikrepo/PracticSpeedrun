using System;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class MenuManager : UserControl
    {
        public MenuManager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            tabPage1.SetPrimaryControl(new Pages.Orders());
            tabPage2.SetPrimaryControl(new Pages.ProductList());
        }
    }
}
