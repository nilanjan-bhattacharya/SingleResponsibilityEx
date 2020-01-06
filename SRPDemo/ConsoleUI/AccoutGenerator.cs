using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class AccoutGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"User name is {user.LastName.Substring(0,5) + user.FirstName.Substring(0,3)}");
        }
    }
}
