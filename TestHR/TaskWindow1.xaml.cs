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
using TestHR.Pages.T2Pages;
using TestHR.Pages;
using TestHR.Model;

namespace TestHR
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow1.xaml
    /// </summary>
    public partial class TaskWindow1 : Window
    {
        Core dB = new Core();
        //
        public TaskWindow1(Core dB, string currentEmployee)
        {
            InitializeComponent();
            this.dB.context = dB.context;
            this.DataContext = currentEmployee;
            ThirdFrame.Navigate(new T2GSFormPage());
        }
    }
}
