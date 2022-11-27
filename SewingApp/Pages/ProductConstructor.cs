using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class ProductConstructor : UserControl
    {
        public string ImagesPath = "../Resources";

        public static OpenFileDialog ImageFileDialog = new OpenFileDialog
        {
            Title = "Выберите изображение",
            Filter = "Все поддерживаемые форматы|*.jpg;*.jpeg;*.png" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg" +
              "Portable Network Graphic (*.png)|*.png"
        };

        public ProductConstructor()
        {
            InitializeComponent();

            Globals.DB.Product.Load();
            Globals.DB.Unit.Load();
            Globals.DB.Fabric.Load();
            Globals.DB.Furniture.Load();
        }

        private void ProductConstructor_Load(object sender, EventArgs e)
        {
            cbProduct.DataSource = Globals.DB.Product.ToList();
            cbWidthUnit.DataSource = Globals.DB.Unit.ToList();
            cbHeightUnit.DataSource = Globals.DB.Unit.ToList();

            cbFabric.DataSource = Globals.DB.Fabric.ToList();
            cbFurniture.DataSource = Globals.DB.Furniture.ToList();
            cbBorder.DataSource = Globals.DB.Fabric.ToList();
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            picProduct.Image = Image.FromFile(Path.Combine(ImagesPath, "/Images/System/no-image.jpg"));
            //try
            //{
            //    //picProduct.Image = Image.FromFile(ImagesPath + @"Изделия/" + CbProduct.SelectedValue + ".jpg");
            //}
            //catch
            //{
            //}
        }

        private void cbFabric_SelectedIndexChanged(object sender, EventArgs e)
        {
            picFabric.Image = Image.FromFile(Path.Combine(ImagesPath, "/Images/System/no-image.jpg"));
        }

        private void cbBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBorder.Image = Image.FromFile(Path.Combine(ImagesPath, "/Images/System/no-image.jpg"));
        }

        private void cbFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {
            picFurniture.Image = Image.FromFile(Path.Combine(ImagesPath, "/Images/System/no-image.jpg"));
        }

        private void btnFabricPath_Click(object sender, EventArgs e)
        {
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                picFabric.Image = Image.FromFile(ImageFileDialog.FileName);
                inpFabricPath.Text = ImageFileDialog.FileName;
            }
        }

        private void btnFurniturePath_Click(object sender, EventArgs e)
        {
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                picFurniture.Image = Image.FromFile(ImageFileDialog.FileName);
                inpFurniturePath.Text = ImageFileDialog.FileName;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.OrdersList());
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
            Globals.DB.SaveChanges();

            Globals.NavigateTo(new Pages.OrdersList());
        }
    }
}
