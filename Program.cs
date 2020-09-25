using System;
using System.Text.RegularExpressions;

namespace passsword_validation
{
    class Program
    {
        static void Main(string[] args) {
        }

        private static bool ValidatePassword(string password, out string Message)
        {
            var input = password;
            Message = string.Empty;
            Console.Write("please enter a password");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{7,12}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!]");

            if (!hasLowerChar.IsMatch(input))
            {
                Message = "error";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                Message = "error";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                Message = "error";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                Message = "error";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                Message = "error";
                return false;
            }
            else
            {
                Message = "Password valid and accepted";
                return true;

            }
        }
    }
}