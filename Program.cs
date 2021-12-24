using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement2
{
    internal class  Program
    {

        static Boolean validatePassword(String password)
        {
            //Logic
            int validConditions = 0;
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 0) return false;
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                }
            }
            if (validConditions == 1) return false;
            if (validConditions == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever    
                if (password.IndexOfAny(special) == -1) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password to be validated:");
            string password = Console.ReadLine();
            if(validatePassword(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }
        }
    }
}
