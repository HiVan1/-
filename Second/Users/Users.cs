namespace Game{
    public abstract class Users{

        public string? userName{get; set;}

        // public int Point{
        //     get{
        //         return Point;
        //     }
        //     set{
        //         if (value  <= 0){
        //             Point = 0;
        //         }
        //     }
        // }

        // public int Point {get; set;}

        private int point;

        public int Point{
            get{
                return point;
            }
            set{
                if (value  <= 0){
                    point = 0;
                }else{
                    point = value;
                }
            }
        }


        public abstract void WinGame(int point);
        
        public abstract void LoseGame(int point);
    }
}