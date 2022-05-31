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
using TestHR.Pages;
using TestHR.Model;
using Microsoft.Win32;
using System.IO;

namespace TestHR.Pages.T2Pages
{
    /// <summary>
    /// Логика взаимодействия для DismissalPage.xaml
    /// </summary>
    public partial class DismissalPage : Page
    {
        Core DB = new Core();
        string nameFile;
        List<EmployeeCard_page10> csvMass;
        public DismissalPage()
        {
            InitializeComponent();
        }

        private void CSVSaveButton_Click(object sender, RoutedEventArgs e)
        {
            csvMass = DB.context.EmployeeCard_page10.ToList();
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text files(*.csv)|*.csv";

            file.Title = "Сохранение файла csv";
            if (file.ShowDialog() == true)
            {

                nameFile = file.FileName;
            }
            using (StreamWriter wr = new StreamWriter(nameFile))
            {

                wr.WriteLine("ID работника ; Причина увольнения ; Дата составления ; № приказа");

                foreach (var item in csvMass)
                {
                    wr.WriteLine($"{item.employee_code};{item.termination_reason};{item.dismissal_date};{item.order_number}");
                }
            }
        }
    }
}
