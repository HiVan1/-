using Shop.Userss;
using Shop.Product;
/*
Класс для хранения истории покупок
*/
namespace Shop.DB{
    public static class EmulatorDBhistory{
        private static IDictionary<User, ProductA> DataBase = new Dictionary<User, ProductA>();

        public static void AddHistory(User user, ProductA product){
            DataBase.Add(user, product);
        }

        public static void ShowPurchase(User user){
            System.Console.WriteLine("======= Purchase History {0} =======", user.UserName);
            for (int i = 0; i < DataBase.Count; i++){
                if (DataBase.ElementAt(i).Key.UserName.Equals(user.UserName)){
                    System.Console.WriteLine("{0} bought {1} for {2}$", user.UserName, DataBase.ElementAt(i).Value.Name, DataBase.ElementAt(i).Value.Cost);
                }
            }
        }
    }
}