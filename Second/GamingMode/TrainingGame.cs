using System.Collections;

namespace Game{
    public class TrainingGame : AbstractGame{

        private int coins = 0;

        public override void gameProcess(Users user1, Users? user2){
            System.Console.WriteLine("Guess what number I guessed? -_-\n[1 - 10]");
            int guessNumber = random.Next(1, 11);
            System.Console.WriteLine("Answer: " + guessNumber);
            for (int i = 0; i < 3; i++){
                System.Console.Write(user1.userName + " Input your number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == guessNumber){
                    printWinLostMassage(true);
                    user1.WinGame(coins);
                    return;
                }
            }
            printWinLostMassage(false);
            user1.LoseGame(coins);
        }
    }
}