using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            // Ask for user information
            var output = new Person();

            Console.WriteLine("Enter first name: ");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
