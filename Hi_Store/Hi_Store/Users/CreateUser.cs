
using Hi_Store.Hash;
using Hi_Store.StoreDataBase;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Hi_Store.Userss {
    /*
     * Класс для работы с Юзером и с БД
     */
    public class CreateUser {

        private int TRY = 0;

        private UserTable userDB;
        
        public CreateUser () {
            userDB = new UserTable();
        }

        public void ConnectionClose () {
            userDB.ConnectionClose ();
        }

        public string RegexForEmail (string mail) {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            if (validateEmailRegex.IsMatch(mail)) {
                return mail;
            }
            else
                return "error";
        }

        public string RegexForPassword (string pass) {
            Regex validatePasslRegex = new Regex("^\\S{8,20}$");
            if (validatePasslRegex.IsMatch(pass)) {
                return pass;
            }
            else
                return "error";
        }


        // Метод для создания нового пользователя
        public void createNewUser (string name, string mail, string pass, string money) {
            User user = null;
            float x = (float)Convert.ToDouble(money);

            // Если пользователь пополнился больше чем 1000$ то срабатывает "Акция" и ему дается скидка (Премиум пользователь)
            if (userDB.isHere(mail)) {
                if (x > 1000) {
                    user = new PremiumUser(name, mail, HashPassword.GetHashPassword(pass), x, 5, "Premium");
                    /*Console.WriteLine("> Создан Premium юзер");*/
                }
                else {
                    user = new DefulrUser(name, mail, HashPassword.GetHashPassword(pass), x, 0, "Defult");
                    /*Console.WriteLine("> Создан Defult юзер");*/
                }
                userDB.AddUserToDB(user);
            }
            else {                                
                // Рекурсивный вызов этого метода для создания Юзера
                Console.Write("Пользователь с такой почтой уже существует. Введите другую почту: ");
                mail = Console.ReadLine();
                createNewUser(name, mail, pass, money);                 
            }
        }

        // Если пользователь уже есть в БД, то создается объект Юзер для дальнейшей работы с ним.
        public User initialUser (string mail, string pass) {
            User user = null;
            
            if (!userDB.isHere(mail)) { // Проверка на наличие такого пользователя
                
                if (HashPassword.CheckHashPassword(HashPassword.GetHashPassword(pass), userDB.GetUserPassword(mail))) { // Проверка на правильноть ввода пароля 

                    // Инициализация пользователя
                    if (userDB.GetUserStatus(mail) == "Premium") {
                        user = new PremiumUser(userDB.GetUserName(mail), mail, HashPassword.GetHashPassword(pass), userDB.GetUserMoney(mail), userDB.GetUserDiscount(mail), "Premium");
                        Console.WriteLine("> Проинициализирован Premium юзер");
                    }
                    else {
                        user = new DefulrUser(userDB.GetUserName(mail), mail, HashPassword.GetHashPassword(pass), userDB.GetUserMoney(mail), userDB.GetUserDiscount(mail), "Defult");
                        Console.WriteLine("> Проинициализирован Defult юзер");
                    }
                }
                else {
                    // Если пользователь не ввел правильный пароль с трёх попыток, метод вернет null
                    if (TRY < 3) {
                        Console.Write("Вы ввели не правильный пароль, попробуйте ещё раз: ");
                        pass = Console.ReadLine();
                        TRY++;
                        /*Console.WriteLine("TRY = " + TRY);*/
                        user = initialUser(mail, pass);
                    }
                }              
            }
            else {
                Console.WriteLine("Не удалось войти в аккаунт. Такого аккаунта нет");
            }

            return user;
        }

        #region other
        /*public void createNewDefultUser (string userName, string email, string password) {
            User user = new DefulrUser(userName, email, password);
            user.Discount = 0;
            *//*EmulatorDB.AddToDB(user);*//*
        }

        public void createNewPremiumUser (string userName, string email, string password) {
            User user = new PremiumUser(userName, email, password);
            user.Discount = 5;
            *//*EmulatorDB.AddToDB(user);*//*
        }*/



        /* public void CheckMail(string mail) {

         }

         public User checkUser (string email, string password) {
             *//*return EmulatorDB.checkUser(email, password);*//*
             return null;
         }*/
        #endregion 
    }
}
