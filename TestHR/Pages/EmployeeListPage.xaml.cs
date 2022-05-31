using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TestHR.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        Core DB;
        public EmployeeListPage()
        {
           InitializeComponent();
           DB = new Core();
           EmployeeDataGrid.ItemsSource = DB.context.EmployeeCard.ToList();
        }
        private void DataGrid_Click(object sender, RoutedEventArgs e)
        {
            Button currentButton = sender as Button;
            EmployeeCard currentEmployee = currentButton.DataContext as EmployeeCard;
           
            var win = new TaskWindow1(DB, currentEmployee.employee_code);
            Properties.Settings.Default.currentEmployee = currentEmployee.employee_code;
            Properties.Settings.Default.Save();
            VacancyPage.KeyConst = currentEmployee.employee_code;

            //VacancyPage.KeyConst = Convert.ToString(DataContext);
            //TaskWindow1 taskWindow = new TaskWindow1();
            win.ShowDialog();
        }

        // private void EmployeeDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {EmployeeDataGrid.ItemsSource = context.EmployeeCard.ToList();}
    }
}
