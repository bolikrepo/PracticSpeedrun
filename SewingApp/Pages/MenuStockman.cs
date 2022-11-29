using System;
using System.IO;
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

        public MenuStockman()
        {
            InitializeComponent();

            if (!SupplyFilesDir.Exists)
                SupplyFilesDir.Create();
        }

        private void Stockman_Load(object sender, EventArgs e)
        {
            dgFabric.EnsureData(Globals.DB.Fabric);
            dgFurniture.EnsureData(Globals.DB.Furniture);

            dgSupply.EnsureData(Globals.DB.FabricStock);

            lbSupplyDocs.Items.AddRange(SupplyFilesDir.GetFiles("*.csv"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.Auth());
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (SupplyFilesDialog.ShowDialog() == DialogResult.OK)
            {
                btnApply.Enabled = true;
                lbSupplyDocs.Items.Add(SupplyFilesDialog.FileName);
            }
        }

        /*
        private void ParseCsvSupplyFile(string filePath)
        {

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                try
                {
                    DgSupplyFileContnet.Items.Clear();
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(";");
                    string[] fields = parser.ReadFields();
                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();
                        int IdUnitWidth_ = Convert.ToInt32(fields[2]);
                        int IdUnitHeight_ = Convert.ToInt32(fields[4]);
                        FabricStock supplyFileInfo = new FabricStock
                        {
                            IdFabric = fields[0],
                            Width = Convert.ToInt32(fields[1]),
                            IdUnitWidth = Convert.ToInt32(fields[2]),
                            Unit = Db.Conn.Unit.Where(u => u.Id == IdUnitWidth_).First(),
                            Height = Convert.ToInt32(fields[3]),
                            IdUnitHeight = Convert.ToInt32(fields[4]),
                            Unit1 = Db.Conn.Unit.Where(u => u.Id == IdUnitHeight_).First(),
                            PurchasePrice = Convert.ToDouble(fields[5])
                        };
                        DgSupplyFileContnet.Items.Add(supplyFileInfo);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла \n" + ex.ToString());
                }


            }
        }
        */
    }
}
