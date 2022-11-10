using Gaming.Users;

namespace Gaming.Games{
    public class Trainign : Game{
        public Trainign(User Player1, User Player2) : base(Player1, Player2){}

        public override void gameProcess(){
            System.Console.WriteLine("{0} vs {1}", Player1.userName, Player2.userName);
            System.Console.WriteLine("Win: {0}", Player1.userName);
            
            Player1.WinGame(this);
            Player2.LoseGame(this); 
        }

        public override string Type(){
            return "Training";
        }
    }
}