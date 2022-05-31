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
using System.Data.Entity.Core.Objects;

namespace TestHR.Pages.T2Pages
{
    /// <summary>
    /// Логика взаимодействия для _3JobTransfersPage.xaml
    /// </summary>
    public partial class _3JobTransfersPage : Page
    {
        Core DB = new Core();
        public _3JobTransfersPage()
        {
            InitializeComponent();
            EmployeeDataGrid.ItemsSource = DB.context.EmployeeCard_page3.Where(x => x.employee_code.Contains((VacancyPage.KeyConst))).ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var query =
            //from EmployeeCard_page3 in DB.EmployeeCard_page3
            //where EmployeeCard_page3.id == 1
            //orderby EmployeeCard_page3.date
            //select new { EmployeeCard_page3.date, EmployeeCard_page3.structural_division, EmployeeCard_page3.post, EmployeeCard_page3.salary, EmployeeCard_page3.cause};
            //EmployeeDataGrid.ItemsSource = query.ToList();
        }
    }
}
