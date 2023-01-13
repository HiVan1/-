using Gaming.Games;

namespace Gaming.Users{
    public class Defult : User{
        public Defult(string userName) : base(userName){}

        public override void WinGame(Game game){
            Rating += game.Coins;
            history.Add(game);
        }

        public override void LoseGame(Game game){
            Rating -= game.Coins;
            history.Add(game);
        }

        public override string outputName(){
            return UserName;
        }
    }
}