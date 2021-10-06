using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
namespace Regex_Problem
{
    class UC3_Valid_EMail
    {
        public static string Regex_mail = "^[0-9a-zA-Z]+([.#_$+-][0-9a-zA-Z]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public UC3_Valid_EMail()
        {
            Console.WriteLine("Enter The EMail");

        }
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, Regex_mail);
        }
    }
}
