namespace Shop.Userss{
    public abstract class User{
        public Random random = new Random();
        private float money;
        public float Money{
            get {return money;}
            set{money = value;}
        }

        private string userName;
        public string UserName{
            get{return userName;}
            set{
                if (value.Length <= 1){
                    System.Console.WriteLine("You entered an invalid name. We give you a random name: ");
                    userName = "Name#" + Convert.ToString(random.NextInt64(1, 100));
                }else{
                    userName = value;
                }
            }
        }

        private string email;
        public string Email{
            get{return email;}
            set{
                email = value;
            }
        }

        private string passwd;
        public string Passwd{
            get{return passwd;}
            set{passwd = value;}
        }
        private float discount;
        public float Discount{
            get{return discount;}
            set{discount = value;}
        }

        public User(string userName, string email, string password){
            UserName = userName;
            Email = email;
            Passwd = password;
        }

        public void UserInformation(){
            System.Console.WriteLine();
            System.Console.WriteLine("Name: " + UserName);
            System.Console.WriteLine("Account: " + Money);
            System.Console.WriteLine("Email: " + Email);
            System.Console.WriteLine("Your password: " + Passwd);
            System.Console.WriteLine("Your discount: " + Discount);
        }

        public abstract void UserBuy(float price);

        public abstract void UserRefill(float sum);
    }
}