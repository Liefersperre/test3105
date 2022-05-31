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
    /// Логика взаимодействия для VacancyPage.xaml
    /// </summary>
    public partial class VacancyPage : Page
    {
        public static String KeyConst ="";
        public VacancyPage()
        {
            InitializeComponent();
        }

        private void directButton_Click(object sender, RoutedEventArgs e)
        {
            KeyConst = "Дирекция";
            this.NavigationService.Navigate(new VacancyTablePage());
    }

        private void HumanResButton_Click(object sender, RoutedEventArgs e)
        {
            KeyConst = "Отдел кадров";
            this.NavigationService.Navigate(new VacancyTablePage());
        }

        private void DeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            KeyConst = "Отдел доставки";
            this.NavigationService.Navigate(new VacancyTablePage());
        }
    }
}
