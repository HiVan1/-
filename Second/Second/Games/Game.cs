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

        public TypeGame type { get; }

        public enum TypeGame {
            Competition,
            Fast,
            Training
        }

        public Game(User Player1, User Player2, TypeGame type){
            this.Player1 = Player1;
            this.Player2 = Player2;
            this.type = type;
        }

        public abstract void gameProcess();
    }
}