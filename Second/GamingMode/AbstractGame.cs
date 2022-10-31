namespace Game{
    public abstract class AbstractGame{
        public int CurrentRating = 50;
        public int GamesCount = 0;
        public int indexGame = 0;
        public Opponent opponent = new Opponent();
        public Random random = new Random();
        // ArrayList history;
        public abstract void logicGame();

        


    }
}