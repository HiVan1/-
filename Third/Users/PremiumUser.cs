namespace Shop.Userss{
    public class PremiumUser : User{
        // Премиум пользователь отличается от обычного только наличием скидки. Для примера скидка = 5%, это число задается при инициализации пользователя
        public PremiumUser(string userName, string email, string password) : base(userName, email, password){ }

        public override void UserBuy(float price){
            float discountPrice = price - price / 100 * Discount;
            if ((Money - discountPrice) >= 0){
                Money -= discountPrice;
            }else{
                System.Console.WriteLine("You don't have enough money to buy");
            }
        }

        public override void UserRefill(float sum){
            Money += sum;
        }
    }
}