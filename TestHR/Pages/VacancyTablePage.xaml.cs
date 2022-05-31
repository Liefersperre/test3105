using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TestHR.Pages;

namespace TestHR.Pages
{
    /// <summary>
    /// Логика взаимодействия для VacancyTablePage.xaml
    /// </summary>
    public partial class VacancyTablePage : Page
    {
        public VacancyTablePage()
        {
            InitializeComponent();
            HumanResDBEntities DB = new HumanResDBEntities();
            EmployeeDataGrid.ItemsSource = DB.Job_vacancy.Where(x => x.structural_division_name.Contains(VacancyPage.KeyConst)).ToList();
            

            //var _itemSourceList = new CollectionViewSource() { Source = DB };
            //_itemSourceList.Filter += new FilterEventHandler(TableFilter);
            //ICollectionView Itemlist = _itemSourceList.View;
            //EmployeeDataGrid.ItemsSource = DB.Job_vacancy.ToList();
        }
        //private void TableFilter(object sender, FilterEventArgs e)
        //{
        //    var obj = e.Item as Model.Job_vacancy;
        //    if (obj != null)
        //    {
        //        if (obj.post.Contains("Секретарь"))
        //            e.Accepted = true;
        //        else
        //            e.Accepted = false;
        //    }
        //}
    }
    
}
