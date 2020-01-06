using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessage.DisplayValidationError("first name");
                return false;
            }
            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessage.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
