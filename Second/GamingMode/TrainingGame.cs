using System.Collections;

namespace Game{
    public class TrainingGame{

        public int CurrentRating = 50;
        public int GamesCount;
        public int indexGame = 0;
        Opponent opponent = new Opponent();
        Random random = new Random();
        History history = new History();

        public void logicGame(){
            GamesCount++;
            opponent.printListOpponent();

            System.Console.Write("Choose an opponent: ");
            int indexOpponent = Convert.ToInt32(Console.ReadLine()); 
            string nameOpponent = opponent.getOpponentList().ElementAt(indexOpponent-1).Key;
            int point = opponent.getOpponentList().ElementAt(indexOpponent-1).Value;
        
            bool win = gameProcess(Int32.Parse(Convert.ToString(nameOpponent[0])), Int32.Parse(Convert.ToString(nameOpponent[2])));

            history.history.Add(GamesCount);
            history.history.Add(nameOpponent);
            history.history.Add(point);
            history.history.Add("Training");
            if (win){
                history.history.Add("Win!");
            }else{
                history.history.Add("Lost");
            }
        }

        public bool gameProcess(int firstNumber, int lastnumber){
            System.Console.WriteLine("Guess what number I guessed? -_-\n[" + firstNumber + " - " + lastnumber + "]");
            int guessNumber = random.Next(firstNumber, lastnumber+1);
            for (int i = 0; i < 3; i++){
                System.Console.Write("Input your number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == guessNumber){
                    printWinLostMassage(true);
                    return true;
                }
            }
            printWinLostMassage(false);
            return false;
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