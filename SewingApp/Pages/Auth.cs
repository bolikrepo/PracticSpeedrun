using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class Auth : UserControl
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text, passwd = textBox2.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(passwd))
            {
                MessageBox.Show("Одно из полей пустое!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = Globals.DB.User.Where(u => u.Login == textBox1.Text && u.Password == textBox2.Text).FirstOrDefault();
            
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Globals.Context.CurrentUser = user;

            switch (user.IdRole)
            {
                case 1:
                    MainForm.Instance.PrimaryControl = new Pages.CustomerViewMenu();
                    break;
                /*
                case 2:
                    NavigationService.Navigate(new PgManager());
                    break;
                case 3:
                    NavigationService.Navigate(new PgStockman());
                    break;
                case 4:
                    NavigationService.Navigate(new PgDirector());
                    break;*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PrimaryControl = new Pages.Register();
        }
    }
}
