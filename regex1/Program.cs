﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace regex1
{
    class Program
    {
        static void Main(string[] args)
        {

            string greeting = "Welcome! Please create a password. The password must contain: \n At least one lowercase letter \n At least one uppercase letter \n A minimum of 7 characters \n A maximum of 12 characters \n An exclamation point:!";
            ; string valid = "Password valid and accepted";
            string error = "Error";

            Console.WriteLine(greeting);
            string v = Console.ReadLine();
            string userInput = v;

            bool usesUpper = true;
            bool usesLower = true;
            bool exclamationPoint = true;
            bool minChar = true;
            bool maxChar = true;

            if (usesUpper && usesLower && exclamationPoint && minChar && maxChar)
            {
                Console.WriteLine(valid);
            }
            else
                Console.WriteLine(error);



             

        }
    }
}