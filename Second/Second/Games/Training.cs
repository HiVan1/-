using Gaming.Users;

namespace Gaming.Games{
    public class Trainign : Game{
        public Trainign(User Player1, User Player2) : base(Player1, Player2, TypeGame.Training){}

        public override void gameProcess(){
            System.Console.WriteLine("{0} vs {1}", Player1.UserName, Player2.UserName);
            System.Console.WriteLine("Win: {0}", Player1.UserName);
            
            Player1.WinGame(this);
            Player2.LoseGame(this); 
        }
    }
}