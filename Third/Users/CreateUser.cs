using Shop.DB;

namespace Shop.Userss{
    public class CreateUser{

        private EmulatorDB DataBaseUser;

        public CreateUser(EmulatorDB DataBase){
            DataBaseUser = DataBase; 
        }

        public User createNewDefultUser(string userName, string email, string password){
            User user = new DefulrUser(userName, email, password);
            DataBaseUser.AddToDB(user);
            return user;
        }

        public User createNewPremiumUser(string userName, string email, string password){
            User user = new PremiumUser(userName, email, password);
            user.Discount = 5;
            DataBaseUser.AddToDB(user);
            return user;
        }

        public bool checkUser(string name, string password){
            return DataBaseUser.checkUser(name, password);
        }
    }
}