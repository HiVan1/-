namespace Shop.Userss{
    public class CreateUser{
        public User createNewDefultUser(string userName){
            User user = new DefulrUser(userName);
            user.Email = "kiohi2000@gmail.com";
            user.Passwd = "1234567890";
            return user;
        }

        public User createNewPremiumUser(string userName){
            User user = new DefulrUser(userName);
            user.Email = "izuravlev@gmail.com";
            user.Passwd = "0987654321";
            user.Discount = 2;
            return user;
        }
    }
}