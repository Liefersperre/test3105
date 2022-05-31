using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHR.Model;

namespace TestHR.Controllers
{
    /// <summary>
    /// Взаимодействие с БД для таблицы Staffing_table
    /// </summary>
    class StaffingTableController
    {
        Core DB = new Core();
        public List<Staffing_table> GetStaff()
        {
            List<Staffing_table> arrStaff = DB.context.Staffing_table.ToList();
            return arrStaff;
        }
    }
}
