using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HumanResLibrary
{
        
    public class ProfessionCodeCheckClass
    {
        Regex regex;
        Match match;

        /// <summary>
        /// Проверка правильности заполнения профессии рабочих
        /// от 1000 до 1807
        /// </summary>
        public bool ProfessionCodeCheck(string ProfessionCodeString)
        {
            regex = new Regex(@"(^(|1[0-8]0[0-7])$)(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])");
            match = regex.Match(ProfessionCodeString);
            if (match.Success)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверка правильности заполнения кода должности служащих
        /// от 20000 по 21390
        /// </summary>
        public bool EmployeesPositionCodeCheck(string ProfessionCodeString)
        {
            regex = new Regex(@"(^(|2[0-1][0-3]0[0-9]0)$)(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])");
            match = regex.Match(ProfessionCodeString);
            if (match.Success)
                return true;
            else
                return false;
        }
    }   

}
