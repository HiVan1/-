using Shop.Userss;
/*
Класс для хранения пользователей
*/
namespace Shop.DB{
    public static class EmulatorDB{
        private static List<User> DataBase = new List<User>();

        public static void AddToDB(User user){
            DataBase.Add(user);
        }

        // Проверка при авторизации 
        public static User checkUser(string email, string password){
            foreach (var x in DataBase){
                if (x.Email.Equals(email) && x.Passwd == password){
                    return x;
                }
            }
            return null;
        }
    }
}