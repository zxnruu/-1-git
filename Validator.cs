using System;

namespace Lab1
{
    public class Validator
    {
        public bool Validate(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
    }
}


    // TODO: add more validation rules in future
    public bool ValidateEmail(string email)
    {
        return true; // TODO: implement email validation
    }
