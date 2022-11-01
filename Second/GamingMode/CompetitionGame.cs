using System.Collections;

namespace Game{
    public class CompetitionGame : AbstractGame{  

        private int coins = 50;     

        public override void gameProcess(Users user1, Users user2){
            System.Console.WriteLine("First start " + user1.userName);
            int u1 = partUser(user1);
            int u2 = partUser(user2);

            System.Console.WriteLine("u1 = {0}\nu2 = {1}\ncoins = {2}", u1, u2, coins);

            if (u1 > u2){
                System.Console.WriteLine("Win " + user1.userName);
                user1.WinGame(u1);
                user2.LoseGame(coins);
            }else if (u1 < u2){
                System.Console.WriteLine("Win " + user2.userName);
                user2.WinGame(u2);
                user1.LoseGame(coins);
            }else{
                System.Console.WriteLine("Draw!");
            }
        }

        private int partUser(Users user){
            int result = 1;
            bool stop = true;
            System.Console.WriteLine("Start " + user.userName + "\nGuess what number I guessed? -_-\n[1 - 10]");
            while (stop){
               
                int guessNumber = random.Next(1, 11);
                System.Console.WriteLine("Answer = " + guessNumber);
                System.Console.Write("x"+result+" Input your number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == guessNumber){
                    printWinLostMassage(true);
                    result++;
                }else{
                    printWinLostMassage(false);
                    stop = false;
                }
            }
            if (result == 1){
                return 0;
            }else{
                return coins * result;
            }
        }

        private int StartRandom(string name){
            return Int32.Parse(Convert.ToString(name[0]));
        }
        private int EndRandom(string name){
            return Int32.Parse(Convert.ToString(name[2]));
        }
    }
}