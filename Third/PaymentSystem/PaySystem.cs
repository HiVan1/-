using Shop.Userss;
using Shop.Product;
using Shop.DB;
/*
Платежная система
*/
namespace Shop.PaymentSystem{
    public class PaySystem{

        public void Payment(User user, string name){
            // Использование try catch для симуляции 'Transaction' (как в базах данных)
            try{
                var product = EmulatorDBproduct.SearchByName(name);
                user.UserBuy(product.Cost);
                EmulatorDBhistory.AddHistory(user, product); // Добавление покупки в историю
                EmulatorDBproduct.RemoveFromDB(product); // Удаление продукта с базы данных после покупки
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