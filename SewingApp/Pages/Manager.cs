using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class Manager : UserControl
    {
        public Manager()
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
