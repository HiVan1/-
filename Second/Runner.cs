using System.Collections;

namespace Game{
    class Runner{
        public static void Main(){
            TrainingGame trainingGame = new TrainingGame();
            CompetitionGame competitionGame = new CompetitionGame();
            FastGame fastGame = new FastGame();
            
            // System.Console.WriteLine("Train=========================");
            // trainingGame.logicGame();
            // System.Console.WriteLine("Competition=========================");
            // competitionGame.logicGame();
            // System.Console.WriteLine("Fast=========================");
            // fastGame.logicGame();

            // System.Console.Write("Loading");
            // for (int i = 0; i < 3; i++){
            //     System.Console.Write(".");
            //     Thread.Sleep(500);
            // }
        }
    }
}