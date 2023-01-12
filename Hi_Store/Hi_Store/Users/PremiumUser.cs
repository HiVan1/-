using System;

namespace Hi_Store.Userss {
    public class PremiumUser : User {
        // Премиум пользователь отличается от обычного только наличием скидки. Для примера скидка = 5%, это число задается при инициализации пользователя
        public PremiumUser (string userName, string email, string password, float money, float discount, string status) : base(userName, email, password, money, discount, status) { }
        public override float UserBuy (float price) {
            float discountPrice = price - price / 100 * Discount;
            if ((Money - discountPrice) >= 0) {
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
