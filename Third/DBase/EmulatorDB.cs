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
            foreach (var x in DataBase!){
                // System.Console.WriteLine("name = " + name);
                // System.Console.WriteLine("DB Name = " + x.UserName);
                // System.Console.WriteLine("password = " + password);
                // System.Console.WriteLine("DB Password = " + x.Passwd);
                if (x.UserName.Equals(name) && x.Passwd == password){
                    return true;
                }
            }
            return false;
        }
    }
}