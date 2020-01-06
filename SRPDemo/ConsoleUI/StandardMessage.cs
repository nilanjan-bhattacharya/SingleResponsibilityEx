using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class StandardMessage
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my app!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a vaalid { fieldName } !");
        }
    }
}
