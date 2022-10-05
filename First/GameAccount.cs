using System;
using System.Collections;
namespace Game{
    class GameAccount{
        public string UserName;
        public int CurrentRating = 50;
        public int GamesCount;
        public int indexGame = 0;
        Opponent opponent;
        Random random;
        ArrayList history;
        
        public GameAccount(string UserName){
            this.UserName = UserName;
            System.Console.WriteLine("Hello, " + UserName);
            opponent = new Opponent();
            random = new Random();
            // {"INDEX", "OPPONENT", "WIN/LOST", "POINT", "POINT AFTER"}
            history = new ArrayList();
            MenuGame();
        }

        public void WinGame(string name, int rat){
            System.Console.WriteLine("You defeated " + name);
            System.Console.WriteLine("You earned "+ rat +" points, now you have "+ (CurrentRating + rat) +" points");
        }

        public void LoseGame(string name, int rat){
            System.Console.WriteLine("You lost to " + name);
            System.Console.WriteLine("You lost "+ rat +" points, now you have "+ (CurrentRating - rat) +" points");
        }

        public void MenuGame(){
            bool stop = true;
            while (stop){
                System.Console.WriteLine("Menu: listOpponent, startGame, historyGame, myRating, exit");
                string inputNemu = Console.ReadLine();
                if (inputNemu == "listOpponent"){
                    opponent.printListOpponent();
                }else if (inputNemu == "startGame"){
                   playGame();
                }else if (inputNemu == "historyGame"){
                   printHistory();
                }else if (inputNemu == "myRating"){
                    System.Console.WriteLine("You rating: " + CurrentRating);
                }else if (inputNemu == "exit"){
                    stop = false;
                }else{
                    System.Console.WriteLine("Error input, pleae try again");
                }
            }
            
        }

        public void playGame(){
            GamesCount++;
            opponent.printListOpponent();
            System.Console.Write("Choose an opponent: ");
            int indexOpponent = Convert.ToInt32(Console.ReadLine()); 
            bool win = Convert.ToBoolean(random.Next(0, 2));
            printWinLostMassage(win);
            if (win){
                history.Add(GamesCount);
                string name = opponent.getOpponentList().ElementAt(indexOpponent-1).Key;
                history.Add(name);
                history.Add("Win");
                int point = opponent.getOpponentList().ElementAt(indexOpponent-1).Value;
                history.Add(point);
                WinGame(name, point);
                CurrentRating += point;
            }else{
                history.Add(GamesCount);
                string name = opponent.getOpponentList().ElementAt(indexOpponent-1).Key;
                history.Add(name);
                history.Add("Lost");
                int point = opponent.getOpponentList().ElementAt(indexOpponent-1).Value;
                history.Add(point);
                LoseGame(name, point);
                CurrentRating -= point;
            }
        }

        public void printHistory(){
            // System.Console.Write("|     ");
            // for (int i = 0; i < 5; i++){
            //     System.Console.Write("%5d" + history[i]);
            // }
            System.Console.WriteLine();
            int j = 3;
            for (int i = 0; i < history.Count; i++){
                System.Console.Write(history[i] + "   ");
                // System.Console.WriteLine(i + " " + j);
                if (i == j){
                    j+=4;
                    // System.Console.WriteLine(i + " " + j);
                    System.Console.WriteLine();
                }
            } 
            System.Console.WriteLine();
        }

        public void printWinLostMassage(bool t){
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