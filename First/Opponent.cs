using System.Collections.Generic;
namespace Game{
    class Opponent{
        IDictionary<string, int> opponentName;
        Random random = new Random();
        public Opponent(){
            opponentName = new Dictionary<string, int>();
            opponentName.Add("name1", 10);
            opponentName.Add("name2", 20);
            opponentName.Add("name3", 30);
            opponentName.Add("name4", 40);
            opponentName.Add("name5", 50);
        }

        public IDictionary<string, int> getOpponentList(){
            return opponentName;
        }

        

        // public int randomOpponent(){
        //     int res = random.Next(1, 6);
        //     string strNum = Convert.ToString(res) + "0";
        //     return Convert.ToInt32(strNum);
        // }

        public void printListOpponent(){
            int i = 1;
            foreach (KeyValuePair<string, int> kvp in opponentName){
                Console.WriteLine("{0} | {1} -> {2}", i++, kvp.Key, kvp.Value);
            }
        }
    }
}