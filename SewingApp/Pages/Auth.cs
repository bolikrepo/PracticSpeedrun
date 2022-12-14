using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class Auth : UserControl
    {
        public Auth()
        {
            InitializeComponent();
        }
        private void Auth_Load(object sender, EventArgs e)
        {
            MainForm.Instance.Text = "Cheto Tam Company - Авторизация";
        }

        private void ForceAuth()
        {
            string login = textBox1.Text, passwd = textBox2.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(passwd))
            {
                MessageBox.Show("Одно из полей пустое!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = Globals.DB.User.Where(u => u.Login == login && u.Password == passwd).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Globals.Context.CurrentUser = user;
            Globals.NavigateToRoleMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForceAuth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.Instance.PrimaryControl = new Pages.Register();
        }

        private void Auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ForceAuth();
            }
        }

    }
}
