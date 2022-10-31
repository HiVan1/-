namespace Game{
    public class VipUser : Users{

        public VipUser(string userName){
            this.userName = userName;
        }

         public override void WinGame(int point){
            this.point += point; 
        }
        public override void LoseGame(int point){
            this.point -= (int)point/2;
        }

       
    }
}