using System.Data.SqlClient;
using System.Configuration;
using System;

namespace Hi_Store.StoreDataBase {
    public class History {
        private string connectionString = ConfigurationManager.ConnectionStrings["StoreDBAdd"].ConnectionString;
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        private SqlDataReader sqlDataReader = null;

        private string command = null;

        public History () {
            this.sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open(); // Открываем соединение с базой данных
            /*Console.WriteLine("Connection Open HR!");*/
        }

        public void AddHistoryToDB (string userMail, string productName, string cost, string amount) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            command = "insert into History (User_name, Product_name, Cost, Amount, Date) values ('" + userMail + "', '" + productName + "', '" + cost + "', '"+ amount + "', '"+DateTime.Now+"')";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("$ Покупка добавлена в историю");
        }

        public void SelectHistory (string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select * from History where User_name='" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка. Возвращается двумерный массив 

            Console.WriteLine("-=-=-=-=-=-= История покупок -=-=-=-=-=-=");
            while (sqlDataReader.Read()) {
                Console.WriteLine($"Название продукта: {sqlDataReader["Product_name"]}");
                Console.WriteLine($"Стоимость продукта: {sqlDataReader["Cost"]}");
                Console.WriteLine($"Куплено (шт.): {sqlDataReader["Amount"]}");
                Console.WriteLine($"Дата покупки: {sqlDataReader["Date"]}");
                Console.WriteLine(new string('=',100));
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }

        public void ConnectionClose () {
            sqlConnection.Close();
        }
    }
}
