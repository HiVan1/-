using Gaming.Users;

namespace Gaming {
    public class Program {
        public static void Main () {
            InitialGame initialGame = new InitialGame();
            User first = new Defult("Ivan");
            User secong = new Defult("Goga");
            User third = new Defult("Typa");
            initialGame.createTrainignGame(first, secong).gameProcess();
            initialGame.createTrainignGame(third, secong).gameProcess();
            initialGame.createTrainignGame(first, third).gameProcess();
            initialGame.createFastGame(secong, third).gameProcess();
            initialGame.createFastGame(third, secong).gameProcess();
            initialGame.createFastGame(third, secong).gameProcess();
            initialGame.createCompetitionGame(third, secong).gameProcess();
            initialGame.createCompetitionGame(third, secong).gameProcess();
            initialGame.createCompetitionGame(third, secong).gameProcess();
            first.information();
            secong.information();
            third.information();
        }
    }
}