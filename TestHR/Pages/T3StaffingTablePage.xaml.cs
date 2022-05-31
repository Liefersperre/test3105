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
using TestHR.Controllers;
using Microsoft.Win32;
using System.IO;

namespace TestHR.Pages
{
    /// <summary>
    /// Логика взаимодействия для T3StaffingTablePage.xaml
    /// </summary>
    public partial class T3StaffingTablePage : Page
    {
        Core DB = new Core();
        string nameFile;
        List<Staffing_table> csvMass;
        public T3StaffingTablePage()
        {
            InitializeComponent();
            ShowTable();
            //EmployeeDataGrid.ItemsSource = DB.Staffing_table.ToList();
        }
        private void ShowTable()
        {
            StaffingTableController obj = new StaffingTableController();
            EmployeeDataGrid.ItemsSource = obj.GetStaff();

        }

        private void StaffingTableTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            EmployeeDataGrid.ItemsSource = DB.context.Staffing_table.Where(x => x.structural_division_name.Contains(StaffingTableTxt.Text)).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowTable();
        }

        private void CSVSaveButton_Click(object sender, RoutedEventArgs e)
        {
            csvMass = DB.context.Staffing_table.Where(x => x.structural_division_name.Contains(StaffingTableTxt.Text)).ToList();
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text files(*.csv)|*.csv";

            file.Title = "Сохранение файла csv";
            if (file.ShowDialog() == true)
            {

                nameFile = file.FileName;
            }
            using (StreamWriter wr = new StreamWriter(nameFile))
            {
                wr.WriteLine("structural_division_name ; structural_division_id ; post ; number_of_employees ; tariff_rate ; allowance ; total_per_month ; compilation_date");

            foreach (var item in csvMass)
            {
                wr.WriteLine($"{item.structural_division_name};{item.structural_division_id};{item.post};{item.number_of_employees};{item.tariff_rate};{item.allowance};{item.total_per_month};{item.compilation_date}");
            }
        }   
    }
    }
}
