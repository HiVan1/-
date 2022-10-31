namespace Game{
    public class Menu{
        public void GameEntry(){
            System.Console.WriteLine("|Add User| |Start Game| |History Game| |View Users|");
            string? userInput = Console.ReadLine();
            if (userInput is null){
                System.Console.WriteLine("You inputted uncorrect!");
                GameEntry();
            }else if(userInput.Equals("Add User")){
                string inputName = Console.ReadLine();
                Users user1 = new DefultUser(inputName);
                Users user2 = new PremiumUser(inputName);
                Users user3 = new VipUser(inputName);

            }else if(userInput.Equals("Start Game")){
                TrainingGame trainingGame = new TrainingGame();
                CompetitionGame competitionGame = new CompetitionGame();
                FastGame fastGame = new FastGame();
            
                System.Console.WriteLine("Train=========================");
                trainingGame.logicGame();
                System.Console.WriteLine("Competition=========================");
                competitionGame.logicGame();
                System.Console.WriteLine("Fast=========================");
                fastGame.logicGame();
            }

            
        }
    }
}