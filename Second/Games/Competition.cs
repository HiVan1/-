using Gaming.Users;

namespace Gaming.Games{
    public class Competition : Game{
        public Competition(User Player1, User Player2) : base(Player1, Player2){}

       
        public override void gameProcess(){
            Coins = 50;
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
            System.Console.WriteLine("{0} vs {1}", Player1.userName, Player2.userName);
            System.Console.WriteLine("Win: {0}", Player1.userName);
            Coins *= randomNumber;
            System.Console.WriteLine("Point = {0} Randim = {1}", Coins, randomNumber);
            
            Player1.WinGame(this);
            Player2.LoseGame(this); 
        }

        public override string Type(){
            return "Competition";
        }
    }
}