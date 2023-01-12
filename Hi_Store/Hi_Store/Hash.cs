using System;
using System.Text;
using System.Security.Cryptography;

namespace Hi_Store.Hash {
    public static class HashPassword {
        public static bool CheckHashPassword (string passwordInput, string password) {           
            if (passwordInput == password) {
                return true;
            }

            Console.WriteLine("$ Пароль введен не коректно!");
            return false;
        }

        public static string GetHashPassword (string password) {
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(password);

            //Compute hash based on source data
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string pass = ByteArrayToString(tmpHash);
            return pass;
        }

        private static string ByteArrayToString (byte[] arrInput) {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++) {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
