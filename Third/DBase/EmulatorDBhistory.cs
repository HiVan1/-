using Shop.PaymentSystem;
using Shop.Userss;
using Shop.Product;

namespace Shop.DB{
    public class EmulatorDBhistory{
        private IDictionary<User, ProductA> DataBase;

        public EmulatorDBhistory(){
            DataBase = new Dictionary<User, ProductA>();
        }

        public void AddHistory(User user, ProductA product){
            DataBase.Add(user, product);
        }

        public void ShowPurchase(User user){
            System.Console.WriteLine("======= Purchase History {0} =======", user.UserName);
            for (int i = 0; i < DataBase.Count; i++){
                if (DataBase.ElementAt(i).Key.UserName.Equals(user.UserName)){
                    System.Console.WriteLine("{0} bought {1} for {2}$", user.UserName, DataBase.ElementAt(i).Value.Name, DataBase.ElementAt(i).Value.Cost);
                }
            }
        }
    }
}