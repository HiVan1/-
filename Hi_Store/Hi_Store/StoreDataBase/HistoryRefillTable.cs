using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;
using Hi_Store.Userss;

namespace Hi_Store.StoreDataBase {
    public class HistoryRefillTable {
        private string connectionString = ConfigurationManager.ConnectionStrings["StoreDBAdd"].ConnectionString;
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        private SqlDataReader sqlDataReader = null;

        private string command = null;

        public HistoryRefillTable () {
            this.sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open(); // Открываем соединение с базой данных
            /*Console.WriteLine("Connection Open HR!");*/
        }

        public void AddRefillToDB (string userMail, string refill) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            command = "insert into History_Refill (User_Mail, Refill, Date) values ('" + userMail + "', '" + refill + "', '" + DateTime.Now + "')";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("$ Платеж добавлен в истоию");
        }

        public void SelectHistory(string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select * from History_Refill where User_mail='" + mail +"'";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка. Возвращается двумерный массив 

            Console.WriteLine("-=-=-=-=-=-= История пополнений -=-=-=-=-=-=");
            Console.WriteLine("Дата         Сумма");
            while (sqlDataReader.Read()) {
                Console.WriteLine($"{sqlDataReader["Date"]}  {sqlDataReader["Refill"]}");
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }    
        
        public void ConnectionClose () {
            sqlConnection.Close();
        }
    }
}
