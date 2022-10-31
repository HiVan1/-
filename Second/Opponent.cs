using System.Collections.Generic;
namespace Game{

    public class Opponent{

        public string Start{
            get{
                return Start;
            }

            set{
                Start = Convert.ToString(value[0]);
            }
        }

        public string End{
            get{
                return End;
            }

            set{
                End = Convert.ToString(value[2]);
            }
        }


        IDictionary<string, int> opponentName;
        Random random = new Random();
        public Opponent(){
            opponentName = new Dictionary<string, int>();
            opponentName.Add("1 - 10", 20);
            opponentName.Add("1 - 25", 30);
            opponentName.Add("1 - 50", 40);
            opponentName.Add("1 - 100", 50);
            opponentName.Add("1 - 500", 300);
        }

        public IDictionary<string, int> getOpponentList(){
            return opponentName;
        }

        

        public void printListOpponent(){
            int i = 1;
            foreach (KeyValuePair<string, int> kvp in opponentName){
                Console.WriteLine("{0} | {1} -> {2}", i++, kvp.Key, kvp.Value);
            }
        }
    }
}