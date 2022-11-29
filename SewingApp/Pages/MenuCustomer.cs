using System;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class MenuCustomer : UserControl
    {
        public MenuCustomer()
        {
            InitializeComponent();

            tabPage1.SetPrimaryControl(new OrdersList());
        }

        private void CustomerViewMenu_Load(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.Auth());
        }
    }
}
