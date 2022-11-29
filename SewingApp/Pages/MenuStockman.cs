﻿using System;
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
            dgFabric.EnsureData(Globals.DB.Fabric);
            dgFurniture.EnsureData(Globals.DB.Furniture);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.Auth());
        }
    }
}
