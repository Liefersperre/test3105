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
using TestHR.Model;
using System.Security.Cryptography;


namespace TestHR.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        Core DB = new Core();
        public event Action ActionRegistration;
        public Registration() => InitializeComponent();
        void BtnRegistration_Click(object o, RoutedEventArgs e)
        {
            if (Username.Text == "" || Password.Password == "" ||
           TryPassword.Password == "" || Password.Password != TryPassword.Password)
                return;
            else {Username.BorderBrush = Brushes.Gray;}
           //var password = Convert.ToBase64String(new SHA256CryptoServiceProvider().
           //ComputeHash(Encoding.
           //ASCII.GetBytes(Password.Password)));

            DB.context.User.Add(new User
            {
                Username = Username.Text,
                Password = TryPassword.Password
            });
            DB.context.SaveChanges();
            MessageBox.Show("Данные добавлены");
            this.NavigationService.Navigate(new AuthorizationPage());
            ActionRegistration?.Invoke();
            Password.Password = (TryPassword.Password = "");
        }

        private void BtnMoveAutorization_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
