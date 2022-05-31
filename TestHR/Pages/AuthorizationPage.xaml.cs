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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestHR.Controllers;
using TestHR.Model;

namespace TestHR.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        Core DB = new Core();
        public AuthorizationPage()
        {
            InitializeComponent();
        }


        private void Autorization_Click(object sender, RoutedEventArgs e)
        {
            bool resultEnt = false;
            UserController objUser = new UserController();
            bool resultLogin = objUser.CheckLogin(UserLogin.Text);
            bool resultPass = objUser.CheckPassword(Password.Password);

            if (resultLogin != true && resultPass != true)
            {
                MessageBoxResult result = MessageBox.Show("Нет такого пользователя!", "", MessageBoxButton.OK);
                return;
            }
            if (resultLogin == false)
            {
                MessageBoxResult result = MessageBox.Show("Неверный логин", "", MessageBoxButton.OK);
                return;
            }
            if (resultPass == false)
            {
                MessageBoxResult result = MessageBox.Show("Неверный пароль", "", MessageBoxButton.OK);
                return;
            }
            if (resultLogin == true && resultPass == true)
            {
                resultEnt = true;
                this.NavigationService.Navigate(new SecondPage());
            }

            Properties.Settings.Default.Save();
        }

        private void BtnMoveRegistration_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Registration());
        }
    }
}
