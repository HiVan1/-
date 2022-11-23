using Shop.Userss;

namespace Shop.DB{
    public static class EmulatorDBhistoryRefill{
        private static IDictionary<User, float> DataBase = new Dictionary<User, float>();

        public static void AddHistory(User user, float sum){
            DataBase.Add(user, sum);
        }

        public static void ShowRefill(User user){
            System.Console.WriteLine("======= Refill History {0} =======", user.UserName);
            for (int i = 0; i < DataBase.Count; i++){
                if (DataBase.ElementAt(i).Key.UserName.Equals(user.UserName)){
                    System.Console.WriteLine("{0} --> {1}$", user.UserName, DataBase.ElementAt(i).Value);
                }
            }
        }
    }
}