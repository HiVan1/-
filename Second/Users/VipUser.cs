namespace Game{
    public class VipUser : Users{

        public VipUser(string userName){
            this.userName = userName;
        }

         public override void WinGame(int Point){
            this.Point += Point; 
        }
        public override void LoseGame(int Point){
            this.Point -= (int)Point/2;
        }

       
    }
}