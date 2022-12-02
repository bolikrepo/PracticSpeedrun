using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class MenuStockman : UserControl
    {
        public DirectoryInfo SupplyFilesDir = new DirectoryInfo(@"./Storage/SupplyFiles/");
        public static OpenFileDialog SupplyFilesDialog = new OpenFileDialog { 
            Title = "Выберите файл",
            Filter = "CSV (*.csv)|*.csv"
        };

        private List<FabricStock> TempStock = new List<FabricStock>();

        public MenuStockman()
        {
            InitializeComponent();

            if (!SupplyFilesDir.Exists)
                SupplyFilesDir.Create();
        }

        private void Stockman_Load(object sender, EventArgs e)
        {
            lbSupplyDocs.Items.AddRange(SupplyFilesDir.GetFiles("*.csv"));
            btnDocsApply.Visible = lbSupplyDocs.Items.Count > 0;

            RefillSupply();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.Auth());
        }

        private void btnUploadDocs_Click(object sender, EventArgs e)
        {
            if (SupplyFilesDialog.ShowDialog() == DialogResult.OK)
            {
                btnDocsApply.Visible = true;

                var info = new FileInfo(SupplyFilesDialog.FileName);

                info.CopyTo(Path.Combine(SupplyFilesDir.FullName, info.Name));
                lbSupplyDocs.Items.Add(info.Name);

                RefillSupply();
            }
        }

        private void RefillSupply()
        {
            foreach (var item in lbSupplyDocs.Items)
            {
                var info = (item as FileInfo);
                if (info.Exists)
                {
                    foreach (var line in File.ReadAllText(info.FullName).Split('\n'))
                    {
                        try
                        {
                            var fields = line.Split(';');
                            int IdUnitWidth_ = Convert.ToInt32(fields[2]);
                            int IdUnitHeight_ = Convert.ToInt32(fields[4]);
                            FabricStock supplyFileInfo = new FabricStock
                            {
                                IdFabric = fields[0],
                                Width = Convert.ToInt32(fields[1]),
                                IdUnitWidth = Convert.ToInt32(fields[2]),
                                Unit = Globals.DB.Unit.Where(u => u.Id == IdUnitWidth_).First(),
                                Height = Convert.ToInt32(fields[3]),
                                IdUnitHeight = Convert.ToInt32(fields[4]),
                                Unit1 = Globals.DB.Unit.Where(u => u.Id == IdUnitHeight_).First(),
                                PurchasePrice = Convert.ToDouble(fields[5])
                            };

                            TempStock.Add(supplyFileInfo);
                        }
                        catch { }
                    }
                }
            }

            dgSupply.DataSource = TempStock;
            dgFabric.EnsureData(Globals.DB.Fabric);
            dgFurniture.EnsureData(Globals.DB.Furniture);
        }

        private void btnApplyDocs_Click(object sender, EventArgs e)
        {
            foreach (var item in TempStock)
            {
                Globals.DB.FabricStock.Add(item);
            }
            try
            {
                Globals.DB.SaveChanges();
            } catch { }

            foreach (var item in lbSupplyDocs.Items)
            {
                var info = (item as FileInfo);
                if (info.Exists) info.Delete();
            }

            dgSupply.DataSource = null;
            lbSupplyDocs.Items.Clear();
            btnDocsApply.Visible = false;
        }

    }
}
