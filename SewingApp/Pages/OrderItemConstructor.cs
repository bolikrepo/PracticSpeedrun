using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class OrderItemConstructor : UserControl
    {

        public static OpenFileDialog ImageFileDialog = new OpenFileDialog
        {
            Title = "Выберите изображение",
            Filter = "Изображение | *.jpg;*.jpeg;*.png" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg" +
              "Portable Network Graphic (*.png)|*.png"
        };

        public OrderItemConstructor()
        {
            InitializeComponent();
        }

        private void ProductConstructor_Load(object sender, EventArgs e)
        {
            cbProduct.FillData(Globals.DB.Product);
            cbWidthUnit.FillData(Globals.DB.Unit);
            cbHeightUnit.FillData(Globals.DB.Unit);

            cbFabric.FillData(Globals.DB.Fabric);
            cbFurniture.FillData(Globals.DB.Furniture);
            cbBorder.FillData(Globals.DB.Fabric);

        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                picProduct.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, $"Polyfills/Product/{(cbProduct.SelectedItem as Product)?.Id}.JPG"));
            }
            catch
            {
                picProduct.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, "System/no-image.jpg"));
            }
        }

        private void cbFabric_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                picFabric.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, $"Polyfills/Fabric/{(cbFabric.SelectedItem as Fabric)?.Id}.jpg"));
            }
            catch
            {
                picFabric.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, "System/no-image.jpg"));
            }
        }

        private void cbFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                picFurniture.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, $"Polyfills/Furniture/{(cbFurniture.SelectedItem as Furniture)?.Id}.jpg"));
            }
            catch
            {
                picFurniture.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, "System/no-image.jpg"));
            }
        }

        private void cbBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                picBorder.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, $"Polyfills/Fabric/{(cbBorder.SelectedItem as Fabric)?.Id}.jpg"));
            }
            catch
            {
                picBorder.BackgroundImage = Image.FromFile(Path.Combine(Globals.ImagesPath, "System/no-image.jpg"));
            }
        }

        private void btnFabricPath_Click(object sender, EventArgs e)
        {
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                picFabric.BackgroundImage = Image.FromFile(ImageFileDialog.FileName);
                inpFabricPath.Text = ImageFileDialog.FileName;
            }
        }

        private void btnFurniturePath_Click(object sender, EventArgs e)
        {
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                picFurniture.BackgroundImage = Image.FromFile(ImageFileDialog.FileName);
                inpFurniturePath.Text = ImageFileDialog.FileName;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.OrderEditMenu());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double productPrice = (
                Globals.DB.FabricStock.Where(
                    u => u.IdFabric == (string)cbFabric.SelectedValue)
                .FirstOrDefault().PurchasePrice.Value
                +
                Globals.DB.FurnitureStock.Where(
                    u => u.IdFurniture == (string)cbFurniture.SelectedValue
                ).FirstOrDefault().PurchasePrice.Value
                +
                Globals.DB.FabricStock.Where(
                    u => u.IdFabric == (string)cbBorder.SelectedValue
                ).FirstOrDefault().PurchasePrice.Value
            ) * Convert.ToDouble(inpAmount.Value);


            Globals.Context.CurrentOrder.OrderItem.Add(new OrderItem
            {
                IdProduct = (string)cbProduct.SelectedValue,
                IdFabric = (string)cbFabric.SelectedValue,
                IdFurniture = (string)cbFurniture.SelectedValue,
                IdBorder = (string)cbBorder.SelectedValue,
                RotationAngle = 0,
                Width = Convert.ToInt32(inpWidth.Value),
                Height = Convert.ToInt32(inpHeight.Value),
                IdUnitHeight = (int)cbHeightUnit.SelectedValue,
                IdUnitWidth = (int)cbWidthUnit.SelectedValue,
                Amount = Convert.ToInt32(inpAmount.Text),
                Price = productPrice
            });

            Globals.Context.CurrentOrder.Price += productPrice;

            Globals.DB.SaveChanges();

            Globals.NavigateTo(new Pages.OrderEditMenu());
        }
    }
}
