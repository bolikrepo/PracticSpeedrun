using System;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class MenuDirector : UserControl
    {
        public MenuDirector()
        {
            InitializeComponent();
            tabPage1.SetPrimaryControl(new ProductList());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.Auth());
        }
    }
}
