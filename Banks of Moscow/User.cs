using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks_of_Moscow
{
    class User
    {
        private string _login;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _patronymic;

        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        public User(string name, string surname, string patronymic, string login, string password)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _login = login;
            _password = password;
        }

        public string RegisterWriter(User user)
        {
            return string.Format(user.Login + " " + user.Password);
        }

    }
}
