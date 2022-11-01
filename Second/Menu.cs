namespace Game{
    public class Menu{
        public Users? user1;
        public Users? user2;
        public Users? user3;

        public void GameEntry(){
            // System.Console.WriteLine("|Add User| |Start Game| |History Game| |View Users| |Close Game|");
            // string? userInput = Console.ReadLine();
            // if (userInput is null){
            //     System.Console.WriteLine("You inputted uncorrect!");
            //     GameEntry();
            // }else if(userInput.Equals("Add User")){
            //     System.Console.Write("Input first username: ");
            //     string? inputName1 = Console.ReadLine();
            //     // loading();
            //     System.Console.Write("\nInput second username: ");
            //     string? inputName2 = Console.ReadLine();
            //     // loading();
            //     System.Console.Write("\nInput third username: ");
            //     string? inputName3 = Console.ReadLine();
            //     // loading();
            //     user1 = new DefultUser(inputName1);
            //     user2 = new PremiumUser(inputName2);
            //     user3 = new VipUser(inputName3);

            // }else if(userInput.Equals("Start Game")){
            //     TrainingGame trainingGame = new TrainingGame();
            //     // CompetitionGame competitionGame = new CompetitionGame();
            //     // FastGame fastGame = new FastGame();
            
            //     System.Console.WriteLine("Train=========================");
            //     trainingGame.gameProcess(user1, null);
            //     // System.Console.WriteLine("Competition=========================");
            //     // competitionGame.logicGame();
            //     // System.Console.WriteLine("Fast=========================");
            //     // fastGame.logicGame();

            //     GameEntry();
            // }else if(userInput.Equals("Close Game")){
            //     return;
            // }

            // GameEntry();

            user1 = new DefultUser("IvanD");
            user2 = new PremiumUser("GogaP");
            user3 = new VipUser("Darina");

            AbstractGame trainingGame = new TrainingGame();
            trainingGame.gameProcess(user1, null);
            System.Console.WriteLine("Point {0} = {1}", user1.userName, user1.Point);

            AbstractGame competitionGame = new CompetitionGame();
            competitionGame.gameProcess(user1, user2);            
            System.Console.WriteLine("Point {0} = {1}", user1.userName, user1.Point);
            System.Console.WriteLine("Point {0} = {1}", user2.userName, user2.Point);
        }

        private void loading(){
            System.Console.Write("Loading");
            for (int i = 0; i < 3; i++){
                System.Console.Write(".");
                Thread.Sleep(500);
            }
        }
    }
}