
namespace _04._Password_Validator
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isLengthValid = IsPasswordLengthInRange(password);
            bool containsOnlyLettersAndDigits = hasOnlyLettersAndDigits(password);
            bool hasTwoDigits = IsPasswordContainsAtLeastTwoDigits(password);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!containsOnlyLettersAndDigits) 
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid && containsOnlyLettersAndDigits && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordLengthInRange(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool hasOnlyLettersAndDigits(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }
        static bool IsPasswordContainsAtLeastTwoDigits(string password)
        {
            int digitsCount = 0;

            foreach (char ch in password) 
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2; 
        }
    }
}
