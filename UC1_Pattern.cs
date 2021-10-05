using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_Problem
{
    class UC1_Pattern
    {
        public static string Regex_Pincode = "^[1-9][0-9]{5}$";
        public bool ValidatePinCode(string picode)
        {
            return Regex.IsMatch(picode, Regex_Pincode);
        }
        public UC1_Pattern()
        {
            Console.WriteLine("ENTER THE FIRST NAME");
        }
      
        public static string Regex_fname = "^[A-Z][a-zA-Z]{2,}$";
       
        public bool ValidateFname(string fname)
        {
            

            return Regex.IsMatch(fname, Regex_fname);
        }
    }
}
