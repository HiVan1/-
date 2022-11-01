namespace Game{
    public abstract class AbstractGame{
        public Opponent opponent = new Opponent();
        public Random random = new Random();

        // public void logicGame(){

        //     string[] opponentSetting = chooseOpponent();
        //     point = Int32.Parse(opponentSetting[1]);
            
        //     // bool win = Convert.ToBoolean(gameProcess(Int32.Parse(opponentSetting[0].Split(" ")[0]), Int32.Parse(opponentSetting[0].Split(" ")[2])));
        //     System.Console.WriteLine("CurrentRating = " + CurrentRating);

        // }

        public abstract void gameProcess(Users user1, Users? user2);
        

         public string[] chooseOpponent(){
            string[] result = new string[2];
            opponent.printListOpponent();

            System.Console.Write("Choose an opponent: ");
            int indexOpponent = Convert.ToInt32(Console.ReadLine()); 
            result[0] = opponent.getOpponentList().ElementAt(indexOpponent-1).Key;
            result[1] = Convert.ToString(opponent.getOpponentList().ElementAt(indexOpponent-1).Value);

            return result;
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