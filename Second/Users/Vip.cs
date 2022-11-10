using Gaming.Games;

namespace Gaming.Users{
    public class Vip : User{
        public Vip(string userName) : base(userName){}

        private List<Game> localList = new List<Game>();
        private bool prov(List<Game> list){
            if(list.Count == 3){
                list.Clear();
                return true;
            }else{
                return false;
            }
        }

        public override void WinGame(Game game){
            Rating += game.Coins;
            history.Add(game);
        }

        // public override void WinGame(Game game){
        //     localList.Add(game);
        //     if (prov(localList)){
        //         Rating += game.Coins * 2;
        //         history.Add(game);
        //     }else{
        //         Rating += game.Coins;
        //         history.Add(game);  
        //     }
        // }

        public override void LoseGame(Game game){
            Rating -= (int)game.Coins / 2;
            history.Add(game);
        }

        public override string outputName(){
            return "Vip " +userName;
        }
    }
}