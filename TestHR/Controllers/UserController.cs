using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHR.Model;

namespace TestHR.Controllers
{
    /// <summary>
    /// Взаимодействие с БД для таблицы User
    /// </summary>
    class UserController
    {
        Core DB = new Core();
        public User usersName;
        public User usersPass;

        /// <summary>
        /// Авторизация пользователя в приложении
        /// </summary>
        /// <param name="usersName">
        /// Входная строка содержащая логин пользователя
        /// </param>
        public bool CheckLogin(string login)
        {
            usersName = DB.context.User.Where(x => x.Username == login).FirstOrDefault();
            if (usersName == null)
            {return false;}
            else return true;
        }

        /// <param name="usersPass">
        /// Входная строка содержащая пароль пользователя
        /// </param>
        public bool CheckPassword(string password)
        {
            usersPass = DB.context.User.Where(x => x.Password == password).FirstOrDefault();
            if (usersPass == null)
            {return false;}
            else return true;
        }
    }
}
