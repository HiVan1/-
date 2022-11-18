using Shop.Product;
using Shop.Userss;

namespace Shop.Store{
    public class Visual{
        public void startShop(){
            CreateUser createUser = new CreateUser();

            System.Console.WriteLine("\nCreate your USER");
            var first = createUser.createNewDefultUser("DefName");
            var second = createUser.createNewPremiumUser("PremName");

            first.UserInformation();
            second.UserInformation();
        }
    }
}