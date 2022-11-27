using System;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class CustomerViewMenu : UserControl
    {
        public CustomerViewMenu()
        {
            InitializeComponent();

            panel1.SetPrimaryControl(new OrdersList());
        }

        private void CustomerViewMenu_Load(object sender, EventArgs e)
        {

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

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
