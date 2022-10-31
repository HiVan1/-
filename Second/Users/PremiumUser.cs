namespace Game{
    public class PremiumUser : Users{

        public PremiumUser(string userName){
            this.userName = userName;
        }

         public override void WinGame(int point){
            this.point += point * 2; 
        }
        public override void LoseGame(int point){
            this.point -= point;
        }

       
    }
}