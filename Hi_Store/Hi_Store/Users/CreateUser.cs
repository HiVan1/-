using Hi_Store.Hash;
using Hi_Store.StoreDataBase;
using System;
using System.Text.RegularExpressions;

namespace Hi_Store.Userss {
    public class CreateUser {        

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
        public void createNewUser (string name, string mail, string pass, string money, string status) {
            User user = null;
     
            if (userDB.isHere(mail)) {
                if (status.Equals("Premium")) {
                    user = new PremiumUser(name, mail, HashPassword.GetHashPassword(pass), float.Parse(money), 5, status);
                    /*Console.WriteLine("$ Создан Premium юзер");*/
                }
                else {
                    user = new DefultUser(name, mail, HashPassword.GetHashPassword(pass), float.Parse(money), 0, status);
                    /*Console.WriteLine("$ Создан Defult юзер");*/
                }
                userDB.AddUserToDB(user);
            }
            else {                                
                // Рекурсивный вызов этого метода для создания Юзера
                Console.Write("$ Пользователь с такой почтой уже существует. \nВведите другую почту: ");
                mail = Console.ReadLine();
                createNewUser(name, mail, pass, money, status);                 
            }
        }

        // Если пользователь уже есть в БД, то создается объект Юзер для дальнейшей работы с ним.
        private int TRY = 0;
        public User initialUser (string mail, string pass) {
            User user = null;
            
            if (!userDB.isHere(mail)) { // Проверка на наличие такого пользователя
                
                if (HashPassword.CheckHashPassword(HashPassword.GetHashPassword(pass), userDB.GetUserPassword(mail))) { // Проверка на правильноть ввода пароля                     
                    // Инициализация пользователя
                    if (userDB.GetUserStatus(mail).Equals("Premium   ")) { // Сравнивается именно строка "Premium   ", потому что в базе данных стоит ограничение на минимум 10 символов
                        user = new PremiumUser(userDB.GetUserName(mail), mail, HashPassword.GetHashPassword(pass), userDB.GetUserMoney(mail), userDB.GetUserDiscount(mail), "Premium");
                        /*Console.WriteLine("> Проинициализирован Premium юзер");*/
                    }
                    else {
                        user = new DefultUser(userDB.GetUserName(mail), mail, HashPassword.GetHashPassword(pass), userDB.GetUserMoney(mail), userDB.GetUserDiscount(mail), "Defult");
                        /*Console.WriteLine("> Проинициализирован Defult юзер");*/
                    }
                }
                else {
                    // Если пользователь не ввел правильный пароль с трёх попыток, метод вернет null
                    if (TRY < 3) {
                        Console.Write("$ Вы ввели не правильный пароль, попробуйте ещё раз: ");
                        pass = Console.ReadLine();
                        TRY++;
                        /*Console.WriteLine("TRY = " + TRY);*/
                        user = initialUser(mail, pass);
                    }
                }              
            }
            else 
                Console.WriteLine("$ Не удалось войти в аккаунт. Такого аккаунта нет 0_0");
            
            return user;
        }

        public void DeleteUser(User user) {
            userDB.DeleteUser(user);
        }

        #region DELETE
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
