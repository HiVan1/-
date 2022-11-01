namespace Game{
    public class PremiumUser : Users{

        public PremiumUser(string userName){
            this.userName = userName;
        }

         public override void WinGame(int Point){
            this.Point += Point * 2; 
        }
        public override void LoseGame(int Point){
            this.Point -= Point;
        }

       
    }
}