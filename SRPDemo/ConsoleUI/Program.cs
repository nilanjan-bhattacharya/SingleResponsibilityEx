using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessage.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessage.EndApplication();
                return;
            }

            AccoutGenerator.CreateAccount(user);

            StandardMessage.EndApplication();

        }
    }
}
