using Shop.Userss;

namespace Shop.DB{
    public class EmulatorDB{
        private List<User> DataBase;

        public EmulatorDB(){
            DataBase = new List<User>();
        }

        public void AddToDB(User user){
            DataBase.Add(user);
        }

        public bool checkUser(string name, string password){
            foreach (var x in DataBase){
                if (x.UserName.Equals(name) && x.Passwd == password){
                    return true;
                }
            }
            return false;
        }
    }
}