using System;
using System.Text.RegularExpressions;

namespace Hi_Store.Userss {
    public abstract class User {
        public Random random = new Random();
        private float money;
        public float Money {
            get { return money; }
            set { money = value; }
        }

        private string userName;
        public string UserName {
            get { return userName; }
            set {
                if (value.Length <= 1) {
                    System.Console.WriteLine("You entered an invalid name. We give you a random name: ");
                    userName = "Name: " + Convert.ToString(random.Next(100));
                }
                else {
                    userName = value;
                }
            }
        }

        private string email;
        public string Email {
            get { return email; }
            set { email = value; }
        }

        

        private string passwd;
        public string Passwd {
            get { return passwd; }
            set { passwd = value; }
        }
        private float discount;
        public float Discount {
            get { return discount; }
            set { discount = value; }
        }

        private string status;
        public string Status {
            get { return status; }
            set { status = value; }
        }

        public User (string userName, string email, string password, float money, float discount, string status) {
            UserName = userName;
            Email = email;
            Passwd = password;
            Money = money;
            Discount = discount;
            Status = status;
        }

        public void UserInformation () {
            System.Console.WriteLine();
            System.Console.WriteLine("Имя: " + UserName);
            System.Console.WriteLine("Почта: " + Email);
            System.Console.WriteLine("Пароль: " + Passwd);
            System.Console.WriteLine("Счёт: " + Money);                        
            System.Console.WriteLine("Скидка: " + Discount);
            System.Console.WriteLine("Текущий статус: " + Status);
        }

        public abstract float UserBuy (float price);

        public abstract void UserRefill (float sum);
    }
}

