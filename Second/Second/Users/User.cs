using Gaming.Games;

namespace Gaming.Users{
    public abstract class User{

        protected List<Game> history = new List<Game>();
        private int ID = 2057;

        public string UserName { get; protected set; }
        

        private int rating;
        public int Rating{
            get{return rating;}
            set{
                if (value <= 0){ rating = 0;}
                else{rating = value;}
            }
        }
        public User(string userName){
            this.UserName = userName;
        }

        public void information(){
            System.Console.WriteLine("{0,-10} {1,-20} {2,-20} {3, -15} {4, -10}\n", "ID", "Winner - Point", "Looser - Point", "Type", "Rating");
            foreach(Game g in history){
                System.Console.WriteLine("{0,-10} {1,-20} {2,-20} {3, -15} {4, -10}\n", ID++, g.Player1.outputName() +" "+ g.Player1.Rating, g.Player2.outputName() +" "+ g.Player2.Rating, g.type, g.Coins);
            }
        }

        public abstract void WinGame(Game game);

        public abstract void LoseGame(Game game);

        public abstract string outputName();
    }
}