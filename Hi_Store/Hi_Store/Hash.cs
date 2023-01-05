using System;
using System.Text;
using System.Security.Cryptography;


namespace Hi_Store.Hash {
    public static class HashPassword {
        public static bool CheckHashPassword (string passwordInput, string password) {
            /*Console.WriteLine("passwordInut: " + passwordInput);
            Console.WriteLine("password: " + password);*/
            if (passwordInput == password) {
                Console.WriteLine("Password is correct!");
                return true;
            }
            else {
                Console.WriteLine("Password is uncorrect 0_0");
                return false;
            }
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
