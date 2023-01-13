using Gaming.Users;

namespace Gaming.Games{
    public class Fast : Game{

        public Fast(User Player1, User Player2) : base(Player1, Player2, TypeGame.Fast){}
       
        public override void gameProcess(){
            System.Console.WriteLine("{0} vs {1}", Player1.UserName, Player2.UserName);
            System.Console.WriteLine("Win: {0}", Player2.UserName);

            Player2.WinGame(this);
            Player1.LoseGame(this);
        }
    }
}