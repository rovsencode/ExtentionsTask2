using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
   static class Extentions
    {
        public static bool CheckGroupNo(this string str)
        {
            if (char.IsUpper(str[0]) && char.IsDigit(str[1]) && char.IsDigit(str[2]) && char.IsDigit(str[3]))
            {
                return true;
            }
            return false;
        }
           public  static bool  CheckFullname(this string str)
        {
            int IndexOfSpace = str.IndexOf(" ");

            if (char.IsUpper(str[0]) )
            {

            }



            return false;
        }
    }
}
