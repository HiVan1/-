using Gaming.Games;

namespace Gaming.Users{
    public class Vip : User{
        public Vip(string userName) : base(userName){}
       

        public override void WinGame(Game game){
            Rating += game.Coins;
            history.Add(game);
        }

        
        public override void LoseGame(Game game){
            Rating -= (int)game.Coins / 2;
            history.Add(game);
        }

        public override string outputName(){
            return "Vip " +UserName;
        }
    }
}