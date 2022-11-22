using Shop.Userss;
using Shop.Product;
using Shop.DB;

namespace Shop.PaymentSystem{
    public class PaySystem{
        private EmulatorDBhistory history;
        private EmulatorDBproduct productDB;

        public PaySystem(EmulatorDBproduct product){
            history = new EmulatorDBhistory();
            productDB = product;
        }

        public void Payment(User user, ProductA product){
            history.AddHistory(user, product);
            user.UserBuy(product.Cost);
            productDB.RemoveFromDB(product);
        }
    }
}