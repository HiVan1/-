using Gaming.Games;
using Gaming.Users;

namespace Gaming{
    public class InitialGame{
        public Game createTrainignGame(User Player1, User Player2){
            return new Trainign(Player1, Player2);
        }

        public Game createFastGame(User Player1, User Player2){
            return new Fast(Player1, Player2);
        }

        public Game createCompetitionGame(User Player1, User Player2){
            return new Competition(Player1, Player2);
        }
    }
}