using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SewingApp.Pages
{
    public partial class Register : UserControl
    {
        public static Regex PasswordRegex = new Regex(@"(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^]).*[A-Za-z\d!@#$%^]{6,}", RegexOptions.None);

        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox4.Text, 
                passwd = textBox3.Text, 
                _passwd = textBox5.Text;


            if (
                string.IsNullOrEmpty(login)
                || string.IsNullOrEmpty(passwd)
                || string.IsNullOrEmpty(_passwd)
            )
            {
                MessageBox.Show("Одно из полей пустое!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Globals.DB.User.Where(u => u.Login == login).FirstOrDefault() != null)
            {
                MessageBox.Show("Данный логин уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (PasswordRegex.IsMatch(passwd))
            {
                MessageBox.Show(@"\
Ошибка заполнения данных. 
Пароль  должен  отвечать  следующим требованиям: 
•  Минимум 6 символов 
•  Минимум 1 прописная буква 
•  Минимум 1 цифра 
•  Минимум один символ из набора: ! @ # $ % ^.", 
                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (passwd != _passwd)
            {
                MessageBox.Show("Пароль и подтверждение не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Globals.DB.User.Add(new User
            {
                Login = login,
                Password = passwd,
                IdRole = 1
            });
            Globals.DB.SaveChanges();

            MessageBox.Show(
                "Регистрация прошла успешно! \nТеперь вы можете войти в систему используя свой логин и пароль.", 
                "Успешно!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            Globals.NavigateTo(new Pages.Auth());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals.NavigateTo(new Pages.Auth());
        }
    }
}
