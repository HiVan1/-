using System;

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
                if (value.Length <= 1) 
                    throw new ArgumentOutOfRangeException(nameof(value), "Имя пользователя не может иметь меньше 1 символа");                
                else 
                    userName = value;
                
            }
        }

        private string email;
        public string Email {
            get { return email; }
            set {
                if (value.Length <= 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Почта не может иметь меньше одного символа");
                else
                    email = value;
            }
        }

        

        private string passwd;
        public string Passwd {
            get { return passwd; }
            set {
                if (value.Length <= 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Пароль не может иметь меньше одного символа");
                else
                    passwd = value;
            }
        }
        private float discount;
        public float Discount {
            get { return discount; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Скидка не может быть меьнше нуля");
                else
                    discount = value;
            }
        }

        private string status;
        public string Status {
            get { return status; }
            set {
                if (value.Length <= 1)
                    throw new ArgumentOutOfRangeException(nameof(value), "Пароль не может иметь меньше одного символа");
                else
                    status = value;
            }
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
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("$    Имя: " + UserName);
            Console.WriteLine("$    Почта: " + Email);
            Console.WriteLine("$    Счёт: " + Money);                        
            Console.WriteLine("$    Скидка: " + Discount);
            Console.WriteLine("$    Текущий статус: " + Status);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
        }

        public abstract float UserBuy (float price);

        public abstract void UserRefill (float sum);
    }
}

