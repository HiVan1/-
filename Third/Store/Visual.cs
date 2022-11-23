using Shop.Product;
using Shop.Userss;
using Shop.PaymentSystem;
using Shop.Store;

namespace Shop.Store{
    public class Visual{
        private CreateUser createUser;
        private CreateProduct createProduct;
        private PaySystem paymentSystem;

        // private EmulatorDB DataBaseUser;
        // private EmulatorDBhistory DataBaseHispory;
        // private EmulatorDBproduct DataBaseProduct;
        

        public Visual(){
            createUser = new CreateUser();
            createProduct = new CreateProduct();
            paymentSystem = new PaySystem();
        }
        public void startShop(){
            System.Console.WriteLine("\n========== SING UP ==========");
            System.Console.WriteLine("Input your name: Ivan");
            System.Console.WriteLine("Input your email: kiohi200@gmail.com");
            System.Console.WriteLine("Input your password: 1234567890");
            createUser.createNewPremiumUser("Ivan", "kiohi2000@gmail.com", "1234567890");

            System.Console.WriteLine("\n========== SING IN ==========");
            System.Console.WriteLine("Input your email: kiohi2000@gmail.com");
            System.Console.WriteLine("Input your password: 1234567890");
            User usr;
            if ((usr = createUser.checkUser("kiohi2000@gmail.com", "1234567890")) != null){
                System.Console.WriteLine("Welocome");
                System.Console.WriteLine("\n========== REFILL ==========");
                System.Console.WriteLine("Input how much do you want to refill: 1579");
                paymentSystem.Refill(usr, 1579);

                System.Console.WriteLine("\n========== ADD PRODUCT ==========");
                
                createProduct.CreateProductX("name1", "#1234", 10f, "type1");
                createProduct.CreateProductX("name2", "0234", 17.32f, "type2");
                createProduct.CreateProductX("name3", "#1434", 1564.2f, "type3");
                createProduct.CreateProductX("name4", "#1634", 0.55f, "type4");

                createProduct.ShowProduct();

                System.Console.WriteLine("\n========== BUY ==========");
                System.Console.WriteLine("Input what are you wanna buy: name1");
                paymentSystem.Payment(usr, "name1");
                usr.UserInformation();
                createProduct.ShowProduct();

            }else{
                System.Console.WriteLine("Go away robber!!!");
            }

            
        }

    }
}