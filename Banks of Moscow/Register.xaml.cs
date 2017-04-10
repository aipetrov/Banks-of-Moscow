using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Banks_of_Moscow
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        List<User> _users = new List<User>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string fio = TextBoxFIO.Text;
                string[] surnamenamepatronymic = fio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);



                //try
                //{
                string login = TextBoxLogin.Text;
                //}
                //catch { MessageBox.Show("Данные введены некорректно. Введите фамилию, имя и отчество через пробел.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
                string password = PasswordBox.Password;
                string passwordAgain = PasswordAgainBox.Password;

                if (password == passwordAgain)
                {
                    User newuser = new User(surnamenamepatronymic[0], surnamenamepatronymic[1], surnamenamepatronymic[2], login, password);
                    _users.Add(newuser);
                    MessageBox.Show("Регистрация прошла успешно.", "Готово", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    
                    using (StreamWriter sw = new StreamWriter("register.txt"))
                    {
                        sw.WriteLine(newuser.RegisterWriter(newuser));
                    }

                    RegisterWindow.Close();
                
                }                
                else
                {
                    MessageBox.Show("Введённые пароли не совадают.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch { MessageBox.Show("Данные введены некорректно.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }

            
        }
    }
}
