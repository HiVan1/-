using Shop.Userss;
using Shop.Product;
using Shop.DB;

namespace Shop.PaymentSystem{
    public class PaySystem{

        public void Payment(User user, string name){
            try{
                var product = EmulatorDBproduct.SearchByName(name);
                user.UserBuy(product.Cost);
                EmulatorDBhistory.AddHistory(user, product);
                EmulatorDBproduct.RemoveFromDB(product);
            }catch (Exception e){
                System.Console.WriteLine("@!!!!! Not found product !!!!!@");
            }
            
        }

        public void Refill(User user, float sum){
            user.UserRefill(sum);
            EmulatorDBhistoryRefill.AddHistory(user, sum);
        }
    }
}