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

namespace TestHR.Pages.T2Pages
{
    /// <summary>
    /// Логика взаимодействия для _9FurtherInformationPage.xaml
    /// </summary>
    public partial class _9FurtherInformationPage : Page
    {
        Core DB = new Core();
        public _9FurtherInformationPage()
        {
            InitializeComponent();
            //RichTextBox.ItemsSource = DB.EmployeeCard_page9.ToList();
        }
    }
}
