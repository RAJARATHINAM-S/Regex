using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Problem
{
    class UC4_PhoneNumber
    {
        public static string Regex_PhoneNumber = "^+([9][1]) ([0-9]{10,15})$";
        public UC4_PhoneNumber()
        {
            Console.WriteLine("ENTER THE MOBILE NUMBER");
        }
        public bool Validate_PhoneNumber(string number)
        {
            return Regex.IsMatch(number, Regex_PhoneNumber);
        }
    }
}
