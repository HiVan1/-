using Gaming.Users;

namespace Gaming.Games{
    public abstract class Game{
        public User Player1;
        public User Player2;

        private int coins;
        public virtual int Coins{
            get{return coins;}
            set{
                if (value <= 0){coins = 0;}
                else{coins = value;}
            }
        }

        public Game(User Player1, User Player2){
            this.Player1 = Player1;
            this.Player2 = Player2;
        }

        public abstract string Type();

        public abstract void gameProcess();
    }
}