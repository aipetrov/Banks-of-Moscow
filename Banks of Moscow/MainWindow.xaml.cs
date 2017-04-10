using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Banks_of_Moscow
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonsignin_Click(object sender, RoutedEventArgs e)
        {
            List<string> Signin = new List<string>();
            using (StreamReader sr = new StreamReader("register.txt"))
            {
                Signin.Add(sr.ReadLine());
            }

            int k=0;

            for (int i = 0; i < Signin.Count; i++)
            {
                string[] loginpassword = Signin[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (loginpassword[0]==textBoxlogin.Text && loginpassword[1]==passwordBox.Password)
                {
                     k = 1;
                    Profile _profile = new Profile();                   
                    SignInWindow.Close();
                    _profile.ShowDialog();
                }

            }

            if (k == 0)
            {
                MessageBox.Show("Пользователя с таким логином и паролем не существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void buttonregister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
