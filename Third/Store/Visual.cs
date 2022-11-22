using Shop.Product;
using Shop.Userss;
using Shop.DB;
using Shop.Store;

namespace Shop.Store{
    public class Visual{
        private CreateUser createUser;
        private ProductA product;
        

        public Visual(){
            createUser = new CreateUser();
            product = new ProductA();
        }
        public void startShop(){
            System.Console.WriteLine("\n========== SING UP ==========");
            User usr = createUser.createNewPremiumUser("Ivan", "kiohi2000@gmail.com", "1234567890");

            System.Console.WriteLine("\n========== SING IN ==========");
            System.Console.WriteLine("Input your name: Ivan");
            System.Console.WriteLine("Input your password: 1234567890");
            if (createUser.checkUser("Iva", "1234567890")){
                System.Console.WriteLine("Welocome");
            }else{
                System.Console.WriteLine("Go away robber!!!");
            }

            System.Console.WriteLine("\n========== REFILL ==========");
            System.Console.WriteLine("Input how much do you want to refill: 1579");
            usr.UserRefill(1579);

            System.Console.WriteLine("\n========== BUY ==========");
            System.Console.WriteLine("Input how much are you ready to spend: 10");
            usr.UserBuy(10);
            usr.UserInformation();

            System.Console.WriteLine("\n========== ADD PRODUCT ==========");

            
        }

    }
}