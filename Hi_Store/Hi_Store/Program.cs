using Hi_Store.Store;
using Hi_Store.Hash;
using System.Text.RegularExpressions;
using System;

namespace Hi_Store {
    internal class Program {
        static void Main (string[] args) {
            Visual visual = new Visual();
            visual.startShop();   // Запускаем магазин




        }

        public static void test (string pass) {
            string test1 = Console.ReadLine ();
            int count = 0;
            if (test1 == pass) {
                Console.WriteLine("ok");
            }
            else {
                count++;
                if (count < 3) {
                    test(pass);
                }
            }
        }
    }
}
