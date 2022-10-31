using System.Collections;

namespace Game{
    public class TrainingGame{

        public int CurrentRating = 50;
        public int GamesCount = 0;
        public int indexGame = 0;
        public Opponent opponent = new Opponent();
        public Random random = new Random();

        public void logicGame(){
            GamesCount++;

            string[] opponentSetting = chooseOpponent();
            int point = Int32.Parse(opponentSetting[1]);
            
            bool win = Convert.ToBoolean(gameProcess(Int32.Parse(opponentSetting[0].Split(" ")[0]), Int32.Parse(opponentSetting[0].Split(" ")[2])));

        }

        public string[] chooseOpponent(){
            string[] result = new string[2];
            opponent.printListOpponent();

            System.Console.Write("Choose an opponent: ");
            int indexOpponent = Convert.ToInt32(Console.ReadLine()); 
            result[0] = opponent.getOpponentList().ElementAt(indexOpponent-1).Key;
            result[1] = Convert.ToString(opponent.getOpponentList().ElementAt(indexOpponent-1).Value);

            return result;
        }

        public int gameProcess(int firstNumber, int lastnumber){
            System.Console.WriteLine("Guess what number I guessed? -_-\n[" + firstNumber + " - " + lastnumber + "]");
            int guessNumber = random.Next(firstNumber, lastnumber+1);
            for (int i = 0; i < 3; i++){
                System.Console.Write("Input your number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == guessNumber){
                    printWinLostMassage(true);
                    return 1;
                }
            }
            printWinLostMassage(false);
            return 0;
        }

        // private int StartRandom(string name){
        //     return Int32.Parse(Convert.ToString(name[0]));
        // }
        // private int EndRandom(string name){
        //     return Int32.Parse(Convert.ToString(name[2]));
        // }

        private void printWinLostMassage(bool t){
            string[] massageWin = {" - You are lucky!", " - It wasn't fair!!!", " - You are very strong!!"};
            string[] massageLost = {" - You are pathetic", " - You tried in vain", " - HA-HA-HA-HA!!  You lose......"};
            if (t){
                System.Console.WriteLine(massageWin[random.Next(0, 3)]);
            }else{
                System.Console.WriteLine(massageLost[random.Next(0, 3)]);
            }
        }
        
      

    }
}