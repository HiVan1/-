using System.Data.SqlClient;
using System.Configuration;
using System;
using Hi_Store.Userss;

namespace Hi_Store.StoreDataBase {
    public class UserTable {
        private string connectionString = ConfigurationManager.ConnectionStrings["StoreDBAdd"].ConnectionString;
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        private SqlDataReader sqlDataReader = null;

        private string command = null;

        public UserTable () {
            this.sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open(); // Открываем соединение с базой данных
        }

        // Метод для проверки наличия такого пользователя. Проверка делается по уникальному Mail
        public bool isHere (string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select count(*) as count from Users where Mail_box='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                test = Convert.ToString(sqlDataReader["count"]);
                if (test != "0") {                   
                    return false;
                }
                
            }
            return true;
        }

        public void AddUserToDB (User user ) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            command = "insert into Users (First_name, Mail_box, Password, Money, Discount, Status) values ('" + user.UserName + "', '" + user.Email + "', '" + user.Passwd + "', '" + user.Money + "', '" + user.Discount + "', '" + user.Status + "')";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            /*Console.WriteLine($"> Пользователь добавлен");*/
        }

        

        // Метод который возвращает Имя пользователя
        public string GetUserName(string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select First_name from Users where Mail_box='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                test = Convert.ToString(sqlDataReader["First_name"]);
            }
            return test;
        }

        // Метод который возвращает Пароль пользователя
        public string GetUserPassword (string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select Password from Users where Mail_box='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                test = Convert.ToString(sqlDataReader["Password"]);
            }

            return test;
        }

        // Метод который возвращает Деньги пользователя
        public float GetUserMoney (string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select Money from Users where Mail_box='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                test = Convert.ToString(sqlDataReader["Money"]);
            }

            return (float)Convert.ToDouble(test);
        }

        // Метод который возвращает Скидку пользователя
        public float GetUserDiscount (string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select Discount from Users where Mail_box='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                test = Convert.ToString(sqlDataReader["Discount"]);
            }

            return (float)Convert.ToDouble(test);
        }

        // Метод который возвращает Статус пользователя
        public string GetUserStatus (string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select Status from Users where Mail_box='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                test = Convert.ToString(sqlDataReader["Status"]);
            }

            return test;
        }

        // Метод для изменения Денег пользователя (покупка)
        public void ChangeUserMoney(string mail, float sum) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            command = "update Users set  Money='" + Convert.ToString(sum) + "' where Mail_box='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            /*Console.WriteLine($"Update {sqlCommand.ExecuteNonQuery()} strings");*/
        }

        // Удаление пользователя
        public void DeleteUser (User user) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            command = "delete from Users where Mail_box = '" + user.Email + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);
            int x = sqlCommand.ExecuteNonQuery();            
        }


        public void ConnectionClose () {
            sqlConnection.Close();
        }
    }
}
