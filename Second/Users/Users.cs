namespace Game{
    public abstract class Users{

        public string userName{
            get{
                return userName;
            }

            set{
                if (value.Length < 1 || value.Length > 10 || value is null){
                    userName = "Error_Name";
                }else{
                    userName = value;
                }
            }
        }
        public int point{
            get{
                return point;
            }

            set{
                if(value < 0){
                    point = 0;
                }
            }
        }


        public abstract void WinGame(int point);
        
        public abstract void LoseGame(int point);
    }
}