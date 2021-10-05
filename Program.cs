using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC1_Pattern test = new UC1_Pattern();
            //  UC2_LastName test = new UC2_LastName();
            // Console.WriteLine(test.ValidatePinCode("345678"));
            //  UC3_Valid_EMail test = new UC3_Valid_EMail();
            // UC4_PhoneNumber test = new UC4_PhoneNumber();
            UC5_Password test = new UC5_Password();

            // bool result = test.ValidateFname( Console.ReadLine());
            //  bool result = test.Validate_Email (Console.ReadLine());
            // bool result = test.Validate_PhoneNumber(Console.ReadLine());
            bool result = test.Validate_Password(Console.ReadLine());
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
