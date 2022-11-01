namespace Game{
    public class DefultUser : Users{

        public DefultUser(string userName){
            this.userName = userName;
        }
        
        public override void WinGame(int point){
            this.Point += point;
        }

        public override void LoseGame(int point){
            this.Point -= point;
        }
    }
}