using Hi_Store.Userss;
using Hi_Store.Product;
using System;
using Hi_Store.StoreDataBase;
using System.Data.SqlClient;
/*
Платежная система
*/
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
            historyRefill.AddRefillToDB(user.Email, Convert.ToString(sum));
        }

        public bool WithdrawalFromAccount (User user, string sku, float sum, int number) {
            /*float was = userDB.GetUserMoney(user.Email);*/
            float was = user.Money;
            int amount = productDB.GetProductAmount(sku);
            string prodName = productDB.GetProductName(sku);

           /* Console.WriteLine("\nTEST amount - number => {0} - {1} = {2} ({3})", amount, number, (amount - number), ((amount - number) >= 0));
            Console.WriteLine("TEST sum <= was => {0} <= {1} ({2})", sum, was, (sum <= was));
            Console.WriteLine("TEST RES = {0}\n", ((amount - number) >= 0 && sum <= was));*/

            if ((amount - number) >= 0) {
                if (sum <= was) {
                    productDB.ChangeProductAmount(sku, (amount - number));
                    userDB.ChangeUserMoney(user.Email, (was - user.UserBuy(sum)));
                    history.AddHistoryToDB(user.Email, prodName, Convert.ToString(sum), Convert.ToString(number));
                    return true;
                }
                else 
                    Console.WriteLine("У Вас не достаточно денег для покупки. Вам не хватает: " + (was - sum) + "$");
                
            }
            else 
                Console.WriteLine("На складен не достаточно этого товара. На складе " + amount + "шт.");
            

            return false;
        }
    }
}