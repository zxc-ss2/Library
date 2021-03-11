using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCheckLib
{
    public class StringCheck
    {

        public bool CheckEmail(string stringEmail)
        {
            string pattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";

            if (Regex.Match(stringEmail, pattern).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckFName(string stringName)
        {
            string pattern = @"[А-Я]{1}[а-я]$";

            if(Regex.Match(stringName, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckLName(string stringLName)
        {
            string pattern = @"[А-Я]{1}[а-я]$";

            if (Regex.Match(stringLName, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckPassword(string stringPassword)
        {
            string pattern = @"(?=^.{8,15}$)(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$%^&_-]).*";


            if (Regex.Match(stringPassword, pattern).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
