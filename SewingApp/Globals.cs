using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp
{
    public static class Globals
    {
        public static SewingDBEntities DB { get; } = new SewingDBEntities();
        public static string ImagesPath = "./Resources/Images/";

        public static void NavigateTo(UserControl value)
        {
            MainForm.Instance.PrimaryControl = value;
        }

        public static void NavigateToRoleMenu()
        {
            switch (Context.CurrentUser.IdRole)
            {
                case 1:
                    MainForm.Instance.Text = "Cheto Tam Company - Заказчик";
                    NavigateTo(new Pages.MenuCustomer());
                    break;
                case 2:
                    MainForm.Instance.Text = "Cheto Tam Company - Менеджер";
                    NavigateTo(new Pages.MenuManager());
                    break;
                case 3:
                    MainForm.Instance.Text = "Cheto Tam Company - Кладовщик";
                    NavigateTo(new Pages.MenuStockman());
                    break;
                case 4:
                    MainForm.Instance.Text = "Cheto Tam Company - Директор";
                    NavigateTo(new Pages.MenuDirector());
                    break;
            }
        }

        public static class Context
        {
            public static User CurrentUser { get; set; }
            public static Order CurrentOrder { get; set; }
        }
    }

    public static class Extensions
    {

        public static Control GetPrimaryControl(this Control control)
            => control.Controls.Cast<Control>().FirstOrDefault();
        public static void SetPrimaryControl(this Control control, Control value)
        {
            control.Controls.Clear();
            value.Dock = DockStyle.Fill;
            control.Controls.Add(value);
            value.Parent = control;
        }

        public static void EnsureData<T>(
            this DataGridView dataGrid, 
            IQueryable<T> data, 
            int[] hidden = null,
            bool canEdit = false
        )
            where T : class
        {
            if (data.Count() <= 0) data.Load();

            var basedCols = dataGrid.Columns.Cast<DataGridViewColumn>().Where(
                c => (
                    c is DataGridViewButtonColumn 
                    || c is DataGridViewImageColumn
                )
            ).ToList();
            dataGrid.Columns.Clear();
            dataGrid.DataSource = data.ToList();

            foreach (var col in basedCols)
            {
                dataGrid.Columns.Insert(dataGrid.Columns.Count, col);
                col.DisplayIndex = col.Index;
            }
            if (hidden != null)
            {
                foreach (var item in hidden)
                    dataGrid.Columns[item].Visible = false;
            }

            dataGrid.AllowUserToAddRows = canEdit;
            dataGrid.AllowUserToDeleteRows = canEdit;
            dataGrid.ReadOnly = !canEdit;
        }

        public static void EnsureComboBox<T>(
            this DataGridView dataGrid, 
            int index,
            IQueryable<T> data
        )
            where T : class
        {
            data.Load();

            var col = dataGrid.Columns[index];
            dataGrid.Columns.RemoveAt(index);

            dataGrid.Columns.Insert(index, new DataGridViewComboBoxColumn
            {
                Name = col.Name,
                HeaderText = col.HeaderText,
                DataPropertyName = col.DataPropertyName,
                ValueMember = typeof(T).GetAttribute<DefaultPropertyAttribute>()?.Name,
                DisplayMember = typeof(T).GetAttribute<DefaultBindingPropertyAttribute>()?.Name,
                DataSource = data.ToList()
            });
        }

        public static void FillData<T>(
            this ComboBox comboBox,
            IQueryable<T> data
        )
            where T : class
        {
            data.Load();
            
            comboBox.DataSource = data.ToList();
            try
            {
                comboBox.ValueMember = typeof(T).GetAttribute<DefaultPropertyAttribute>()?.Name;
                comboBox.DisplayMember = typeof(T).GetAttribute<DefaultBindingPropertyAttribute>()?.Name;
            }
            catch { }
        }


        public static T GetAttribute<T>(this Type it) => it.GetCustomAttributes(true).OfType<T>().FirstOrDefault();
    }
}
