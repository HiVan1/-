using System.Collections;

namespace Game{
    class Runner{
        public static void Main(){
            TrainingGame trainingGame = new TrainingGame();
            CompetitionGame competitionGame = new CompetitionGame();
            // trainingGame.logicGame();
            competitionGame.logicGame();
        }
    }
}