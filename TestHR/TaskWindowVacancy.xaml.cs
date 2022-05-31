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
using System.Windows.Shapes;
using TestHR.Pages;

namespace TestHR
{
    /// <summary>
    /// Логика взаимодействия для TaskWindowVacancy.xaml
    /// </summary>
    public partial class TaskWindowVacancy : Window
    {
        public TaskWindowVacancy()
        {
            InitializeComponent();
            FourthFrame.Navigate(new VacancyPage());
        }
    }
}
