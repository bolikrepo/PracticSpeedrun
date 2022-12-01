using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class Cutting : UserControl
    {
        private Order Order { get; }
        private OrderItem CuttingItem { get; set; }
        private FabricStock StockItem { get; set; }
        private bool StockEnough { get; set; }

        private List<Size> CutLines { get; } = new List<Size>();

        public Cutting()
        {
            InitializeComponent();
            Order = Globals.Context.CurrentOrder;
            lbOrder.Text = "Заказ: " + (Order.Id == 0 ? "Новый" : "№ " + Order.Id.ToString());

            dataGridView1.DataSource = Order.OrderItem.OrderBy(oi => oi.Width).ToList();

            dataGridView1.EnsureData(
                Globals.DB.OrderItem.Where(or => or.IdOrder == Order.Id).OrderBy(or => or.Width),
                hidden: new[] { 1 }
            );
            dataGridView1.EnsureComboBox(2, Globals.DB.Product);
            dataGridView1.EnsureComboBox(3, Globals.DB.Fabric);
            dataGridView1.EnsureComboBox(4, Globals.DB.Furniture);
            dataGridView1.EnsureComboBox(5, Globals.DB.Fabric);

            dataGridView1.EnsureComboBox(7, Globals.DB.Unit);
            dataGridView1.EnsureComboBox(9, Globals.DB.Unit);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Globals.NavigateToRoleMenu();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (StockItem == null) return;
            try
            {
                double tubeW = (double)StockItem.Width,
                tubeH = (double)StockItem.Height;

                CutLines.Clear();

                List<double> w = new List<double>(),
                    h = new List<double>();

                w.Add(0);
                w.Add(0);
                h.Add(CuttingItem.Height);
                h.Add(CuttingItem.Height);

                for (var i = 0; i < CuttingItem.Amount; i++)
                {
                    for (var j = 0; j < 2; j++)
                    {
                        if (w[1] + CuttingItem.Width <= tubeW && CuttingItem.Height <= h[j])
                            w[1] += CuttingItem.Width;
                        else
                            h.Add(CuttingItem.Height);
                    }
                }

                for (int i = 0; i < w.Count - 1; i++)
                    CutLines.Add(new Size(Convert.ToInt32(w[i]), Convert.ToInt32(h[i])));

                picCutting.Refresh();
                MessageBox.Show($"Lines: {CutLines.Count}");
                //Globals.NavigateToRoleMenu();
            }
            catch { }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            CuttingItem = (dataGridView1.DataSource as List<OrderItem>)?[e.RowIndex];
            CutLines.Clear();

            var unitToConvert = Math.Max(CuttingItem.IdUnitHeight, CuttingItem.IdUnitWidth);

            CuttingItem.Width = CuttingItem.Width * Globals.DB.UnitConvert.Where(uc => uc.IdUnit1 == CuttingItem.IdUnitWidth && uc.IdUnit2 == unitToConvert).First().Ratio;
            CuttingItem.IdUnitWidth = unitToConvert;
            CuttingItem.Height = CuttingItem.Height * Globals.DB.UnitConvert.Where(uc => uc.IdUnit1 == CuttingItem.IdUnitHeight && uc.IdUnit2 == unitToConvert).First().Ratio;
            CuttingItem.Height = unitToConvert;

            tbProduct.Text = CuttingItem.Product.Name;
            tbFabric.Text = CuttingItem.Fabric.Name;
            tbProductArea.Text = $"{(CuttingItem.Width * CuttingItem.Height)} {CuttingItem.Unit.Name}^2";

            tbAmount.Text = CuttingItem.Amount.ToString();
            tbNeeded.Text = $"{(CuttingItem.Amount * CuttingItem.Width * CuttingItem.Height)} {CuttingItem.Unit.Name}^2";

            cbStock.FillData(
                Globals.DB.FabricStock.Where(fs => fs.IdFabric == CuttingItem.IdFabric)
            );
            cbStock.SelectedIndex = 0;

            try
            {
                picCutting.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, $"Polyfills/Fabric/{CuttingItem?.Fabric?.Id}.jpg"));
            }
            catch
            {
                picCutting.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, "System/no-image.jpg"));
            }
        }

        private void cbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StockItem = cbStock.SelectedItem as FabricStock;

                StockItem.Height = StockItem.Height * Globals.DB.UnitConvert.Where(uc => uc.IdUnit1 == StockItem.IdUnitHeight && uc.IdUnit2 == CuttingItem.IdUnitHeight).First().Ratio;
                StockItem.IdUnitHeight = CuttingItem.IdUnitHeight;
                StockItem.Width = StockItem.Width * Globals.DB.UnitConvert.Where(uc => uc.IdUnit1 == StockItem.IdUnitWidth && uc.IdUnit2 == CuttingItem.IdUnitWidth).First().Ratio;
                StockItem.IdUnitWidth = CuttingItem.IdUnitWidth;

                double fabricArea = Convert.ToDouble(StockItem.Width * StockItem.Height);
                tbFabricStock.Text = $"{fabricArea} {CuttingItem.Unit.Name}^2";
                tbFabricEnough.Text = Convert.ToInt32(Math.Floor(fabricArea / (CuttingItem.Width * CuttingItem.Height))).ToString();

                StockEnough = Convert.ToInt32(Math.Floor(fabricArea / (CuttingItem.Width * CuttingItem.Height))) > 1;
            }
            catch { }
        }

        private static Pen Pen = new Pen(Brushes.Red, 5);

        private void picCutting_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var size = picCutting.Size;

            foreach (var line in CutLines)
            {
                float pw = (float)(size.Width * (line.Width / CuttingItem.Width)),
                    ph = (float)(size.Height * (line.Height / CuttingItem.Height));

                g.DrawLine(
                    Pen,
                    0, ph,
                    size.Width, ph
                );

                g.DrawLine(
                    Pen,
                    pw, 0,
                    pw, size.Height
                );
            }
        }
    }
}
