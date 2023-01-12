using System.Data.SqlClient;
using System.Configuration;
using System;

namespace Hi_Store.StoreDataBase {
    public  class ProductTable {

        private string connectionString = ConfigurationManager.ConnectionStrings["StoreDBAdd"].ConnectionString;
        private SqlConnection sqlConnection = null;
        private SqlCommand sqlCommand = null;
        private SqlDataReader sqlDataReader = null;

        private string command = null;

        public ProductTable () {
            this.sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            /*Console.WriteLine("Connection Open P !");*/
        }

        public bool isHere (string sku) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select count(*) as count from Product where SKU='" + sku + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                test = Convert.ToString(sqlDataReader["count"]);
                if (test != "0") {
                    /*Console.WriteLine("$ Товар с таким артиклем уже существует");*/
                    return false;
                }
            }

            Console.WriteLine("$ Такого товара не существет");
            return true;
        }

        public void ShowProducts () {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select * from Product";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка

            Console.WriteLine(new string('=', 100));
            while (sqlDataReader.Read()) {
                Console.WriteLine($"$ Название продукта: {sqlDataReader["Name"]}");
                Console.WriteLine($"$ Артикуль: {sqlDataReader["SKU"]}");
                Console.WriteLine($"$ Колличество товара на складе: {sqlDataReader["Amount"]}");
                Console.WriteLine($"$ Стоимость: {sqlDataReader["Cost"]}");

                Console.WriteLine(new string('=', 100));
            }
        }


        public void ShowProducts (string sku) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select * from Product where SKU='" + sku + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            while (sqlDataReader.Read()) {
                Console.WriteLine($"$ Название продукта: {sqlDataReader["Name"]}");
                Console.WriteLine($"$ Артикуль: {sqlDataReader["SKU"]}");
                Console.WriteLine($"$ Колличество товара на складе: {sqlDataReader["Amount"]}");
                Console.WriteLine($"$ Стоимость: {sqlDataReader["Cost"]}");

                Console.WriteLine("*+*+*+*+*+*+ Информация о товаре *+*+*+*+*+*+");
                Console.WriteLine($"{sqlDataReader["About"]}");
            }
        }

        #region DELETE

        /*public void AddProductToDB (ProductA product) {
            *//*if (isHere(user.Email)) {
                command = "insert into Users (First_name, Mail_box, Password, Money, Discount, Status) values ('" + user.UserName + "', '" + user.Email + "', '" + user.Passwd + "', '" + user.Money + "', '"+ user.Discount +"', '"+ user.Status +"')";
                sqlCommand = new SqlCommand(command, sqlConnection);
                Console.WriteLine($"> Add {sqlCommand.ExecuteNonQuery()} strings. Пользователь добавлен");
            }
            else {
                Console.WriteLine("> Пользователь с такой почтой уже существует, введите другую почту");
            }*/

        /*Close Data Reader*//*
        if (sqlDataReader != null)
            sqlDataReader.Close();

        command = "insert into Product (Name, SKU, Type, Cost, Amount, About) values ('" + product.Name + "', '" + product.SKU + "', '" + product.Type + "', '" + product.Cost + "', '" + product.Amount + "', '" + product.About + "')";
        sqlCommand = new SqlCommand(command, sqlConnection);
        sqlCommand.ExecuteNonQuery();
        *//*Console.WriteLine($"> Add {sqlCommand.ExecuteNonQuery()} strings. Товар добавлен");*//*

    }*/
        #endregion

        public string GetProductName (string sku) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select Name from Product where SKU='" + sku + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            string test = string.Empty;

            while (sqlDataReader.Read()) {
                /*test = Convert.ToString(sqlDataReader["Name"]) +"("+ Convert.ToString(sqlDataReader["SKU"]) + ")";*/
                test = Convert.ToString(sqlDataReader["Name"]);
            }
            return test;
        }
            
       
        public float GetProductCost (string sku) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select Cost from Product where SKU='" + sku + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            float test = 0;
            while (sqlDataReader.Read()) {
                test = (float)Convert.ToDouble(sqlDataReader["Cost"]);
            }
            return test;
        }

        public int GetProductAmount (string sku) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            var command = "select Amount from Product where SKU='" + sku + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader(); // В бд делается выборка
            int test = 0;
            while (sqlDataReader.Read()) {
                test = Convert.ToInt32(sqlDataReader["Amount"]);
            }
            return test;
        }

        public void ChangeProductAmount (string sku, float x) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            command = "update Product set Amount='" + Convert.ToString(x) + "' where SKU='" + sku + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();           
        }

        public void DeleteProduct (string mail) {
            /*Close Data Reader*/
            if (sqlDataReader != null) sqlDataReader.Close();

            command = "delete from Users where Mail_box = '" + mail + "'";
            sqlCommand = new SqlCommand(command, sqlConnection);
            int x = sqlCommand.ExecuteNonQuery();
        }

        public void ConnectionClose () {
            sqlConnection.Close();
        }
    }
}
