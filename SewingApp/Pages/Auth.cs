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
            var user = Globals.DB.User.Where(u => u.Login == textBox1.Text && u.Password == textBox2.Text).FirstOrDefault();
            
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
            else
            {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex checkSpace = new Regex(@"\s", RegexOptions.None);
            Regex checkPassword = new Regex(@"(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^]).*[A-Za-z\d!@#$%^]{6,}", RegexOptions.None);

            if ((textBox4.Text != string.Empty) &&
                (textBox3.Text == textBox5.Text) &&
                (!checkSpace.IsMatch(textBox3.Text) &&
                checkPassword.IsMatch(textBox5.Text)))
            {
                if (Globals.DB.User.Where(u => u.Login == textBox3.Text).FirstOrDefault() == null)
                {
                    User user = new User();
                    user.Login = textBox4.Text;
                    user.Password = textBox3.Text;
                    user.IdRole = 1;
                    Globals.DB.User.Add(user);
                    Globals.DB.SaveChanges();

                    MessageBox.Show("Регистрация прошла успешно! Теперь вы можете войти в систему используя свой логин и пароль.");
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox5.Text = string.Empty;
                }
                else
                    MessageBox.Show("Данный логин уже занят.");
            }
            else
            {
                MessageBox.Show(@"Ошибка заполнения данных. 
Необходимо задать логин.
Пароль  должен  отвечать  следующим требованиям: 
•  Минимум 6 символов 
•  Минимум 1 прописная буква 
•  Минимум 1 цифра 
•  Минимум один символ из набора: ! @ # $ % ^.");
            }
        }
    }
}
