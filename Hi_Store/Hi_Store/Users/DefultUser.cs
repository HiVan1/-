using System;

namespace Hi_Store.Userss {
    public class DefultUser : User {
        public DefultUser (string userName, string email, string password, float money, float discount, string status) : base(userName, email, password, money, discount, status) { }

        public override float UserBuy (float price) {  
            
            float discountPrice = price - price / 100 * Discount; // сумма скидки
            
            if ((Money - discountPrice) >= 0) { // провека на наличие нужной суммы у пользователя
                Money -= discountPrice;
            }
            else
                Console.WriteLine("$ Недостатотчно денег :(");

            return discountPrice; 
        }

        public override void UserRefill (float sum) {
            Money += sum;
        }
    }
}
