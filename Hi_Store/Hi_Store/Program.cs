using Hi_Store.Store;
using Hi_Store.Hash;
using System.Text.RegularExpressions;
using System;

namespace Hi_Store {
    internal class Program {
        static void Main (string[] args) {
            Visual visual = new Visual();
            visual.startShop();   // Запускаем магазин

            string input = Console.ReadLine();
            string input1 = "123456789";
            string input2 = "123sdfg%^!@(^";
            Console.WriteLine(RegexForPassword(input));
            Console.WriteLine(RegexForPassword(input1));
            Console.WriteLine(RegexForPassword(input2));

            /* string inputPass = "02062003";
             string inputPass1 = "02062003";

             System.Console.WriteLine(HashPassword.GetHashPassword(inputPass));
             System.Console.WriteLine(HashPassword.CheckHashPassword(HashPassword.GetHashPassword(inputPass1), HashPassword.GetHashPassword(inputPass)));*/
        }

        public static string RegexForPassword (string pass) {
            Regex validateEmailRegex = new Regex("^\\S{8,20}$");
            if (validateEmailRegex.IsMatch(pass)) {
                return pass;
            }
            else
                return "error";
        }
    }
}
