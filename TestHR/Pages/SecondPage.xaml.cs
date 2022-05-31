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

namespace TestHR.Pages
{
    /// <summary>
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void Schedule_Button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindow taskWindow = new TaskWindow();
            taskWindow.ShowDialog();
        }

        private void Staff_Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeeListPage());
        }

        private void Vacancy_Button_Click(object sender, RoutedEventArgs e)
        {
            TaskWindowVacancy taskWindow = new TaskWindowVacancy();
            taskWindow.ShowDialog();
        }
    }
}
