using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Regex_Problem
{
    class UC2_LastName
    {
        public static string Regex_Lname = "^[A-Z][a-zA-Z]{2,}$";
        public UC2_LastName()
        {
            Console.WriteLine("ENTER THE LAST NAME");
        }
        public bool ValidateFname(string Lname)
        {


            return Regex.IsMatch(Lname, Regex_Lname);
        }
    }
}
