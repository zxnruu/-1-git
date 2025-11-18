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


