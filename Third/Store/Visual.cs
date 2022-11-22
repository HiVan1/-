using Shop.Product;
using Shop.Userss;
using Shop.DB;
using Shop.Store;

namespace Shop.Store{
    public class Visual{
        private CreateUser createUser;
        private CreateProduct createProduct;

        private EmulatorDB DataBaseUser;
        private EmulatorDBhistory DataBaseHispory;
        private EmulatorDBproduct DataBaseProduct;
        

        public Visual(){
            
            createUser = new CreateUser();
            createProduct = new CreateProduct();
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
            
            var test = createProduct.CreateProductX("name1", "#1234", 13.2f, "type1");
            createProduct.CreateProductX("name2", "0234", 17.32f, "type2");
            createProduct.CreateProductX("name3", "#1434", 1564.2f, "type3");
            createProduct.CreateProductX("name4", "#1634", 0.55f, "type4");

            createProduct.ShowProduct();


            System.Console.WriteLine("\n========== {0} buy {1} ==========", usr.UserName, test.Cost);

        }

    }
}