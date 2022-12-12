using Shop.DB;

namespace Shop.Userss{
    public class CreateUser{


        public CreateUser(){
        }

        public void createNewDefultUser(string userName, string email, string password){
            User user = new DefulrUser(userName, email, password);
            user.Discount = 0;
            EmulatorDB.AddToDB(user);
        }

        public void createNewPremiumUser(string userName, string email, string password){
            User user = new PremiumUser(userName, email, password);
            user.Discount = 5;
            EmulatorDB.AddToDB(user);
        }

        public User checkUser(string email, string password){
            return EmulatorDB.checkUser(email, password);
        }
    }
}