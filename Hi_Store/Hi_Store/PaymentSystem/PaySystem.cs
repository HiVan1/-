using Hi_Store.Userss;
using System;
using Hi_Store.StoreDataBase;

namespace Hi_Store.PaymentSystem {
    public class PaySystem {

        private UserTable userDB;
        private ProductTable productDB;
        private HistoryRefillTable historyRefill;
        private History history;

        public PaySystem() {
            userDB = new UserTable();
            productDB= new ProductTable();
            historyRefill = new HistoryRefillTable();
            history = new History();
        }
        

        public void ConnectionClose () {
            userDB.ConnectionClose();
            productDB.ConnectionClose();
            historyRefill.ConnectionClose();
            history.ConnectionClose();
        }

        public void ShowHistoryRefill(User user) {
            historyRefill.SelectHistory(user.Email);
        }

        public void ShowHistory(User user) {
            history.SelectHistory(user.Email);
        }

        public void RefillUserAccount(User user, float sum) {
            float was = userDB.GetUserMoney(user.Email);
            userDB.ChangeUserMoney(user.Email, (sum + was));
            user.UserRefill(sum);
            historyRefill.AddRefillToDB(user.Email, Convert.ToString(sum));
        }

        public bool WithdrawalFromAccount (User user, string sku, float sum, int number) {            
            float was = user.Money;
            int amount = productDB.GetProductAmount(sku);
            string prodName = productDB.GetProductName(sku);
 
            if ((amount - number) >= 0) {
                if ((sum * number) <= was) {
                    productDB.ChangeProductAmount(sku, (amount - number));
                    userDB.ChangeUserMoney(user.Email, (was - user.UserBuy(sum * number)));
                    history.AddHistoryToDB(user.Email, prodName, Convert.ToString(sum * number), Convert.ToString(number));
                    return true;
                }
                else 
                    Console.WriteLine("$ У Вас не достаточно денег для покупки. Вам не хватает: " + (was - sum * number) + "$");                
            }
            else 
                Console.WriteLine("$ На складен не достаточно этого товара. На складе " + amount + "шт.");            

            return false;
        }

        public bool WithdrawalFromAccount (User user) {

            float have = user.Money;
            float PremiumCost = 1000f;
                             
            if (have >= PremiumCost) {
                userDB.ChangeUserMoney(user.Email, (have - user.UserBuy(PremiumCost)));
                history.AddHistoryToDB(user.Email, "Premium", Convert.ToString(PremiumCost), "1");
                return true;
            }

            Console.WriteLine("$ У Вас не достаточно денег для покупки. Вам не хватает: " + (have - PremiumCost) + "$");
            return false;            
        }
    }
}