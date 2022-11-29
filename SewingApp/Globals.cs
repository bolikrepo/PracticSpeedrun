﻿using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp
{
    public static class Globals
    {
        public static SewingDBEntities DB { get; } = new SewingDBEntities();

        public static void NavigateTo(UserControl value)
        {
            MainForm.Instance.PrimaryControl = value;
        }

        public static void NavigateToRoleMenu()
        {
            switch (Context.CurrentUser.IdRole)
            {
                case 1:
                    NavigateTo(new Pages.MenuCustomer());
                    break;
                case 2:
                    NavigateTo(new Pages.MenuManager());
                    break;
                case 3:
                    NavigateTo(new Pages.MenuStockman());
                    break;
                case 4:
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

        public static void EnsureData<T>(this DataGridView dataGrid, IQueryable<T> data)
            where T : class
        {
            data.Load();
            dataGrid.DataSource = data.ToList();

            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
        }

        public static void EnsureComboBox<T>(this DataGridView dataGrid, int index, DbSet<T> data)
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
                ValueMember = typeof(T).GetCustomAttributes(true).OfType<DefaultPropertyAttribute>().FirstOrDefault()?.Name,
                DisplayMember = typeof(T).GetCustomAttributes(true).OfType<DefaultBindingPropertyAttribute>().FirstOrDefault()?.Name,
                DataSource = data.Local.ToList()
            });
        }

    }
}
