namespace Shop.Userss{
    public class DefulrUser : User{
        public DefulrUser(string userName) : base(userName){ }

        public override void UserBuy(float price){
            if ((Money - price) >= 0){
                Money -= price;
            }else{
                System.Console.WriteLine("You don't have enough money to buy");
            }
        }

        public override void UserRefill(float sum){
            Money -= sum - sum/100*Discount;
        }
    }
}