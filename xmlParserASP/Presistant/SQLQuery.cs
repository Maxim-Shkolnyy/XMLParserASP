﻿//using MySql.Data.MySqlClient;

//namespace xmlParserASP.Presistant;

//internal class SQLQuery
//{
//    public static void ConnectToDB()
//    {
//        string connectionString = "";
//        //string Connect = "Database=gamma;Data Source=localhost;User Id=root;Password=root";

//        using (MySqlConnection connection = new MySqlConnection(connectionString))
//        {
//            connection.Open(); 

//            string createTableQuery = @"CREATE TABLE Attributes (
//                                        attribute_id INT PRIMARY KEY,
//                                        attribute_name VARCHAR(50),
//                                        attribute_value VARCHAR(50)
//                                    )";

//            //select p.product_id, pd.name from oc_product as p inner join oc_product_description as pd on (p.product_id = pd.product_id) where pd.language_id = 1 order by product_id limit 5;", myConnection);

//            using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
//            {
//                createTableCommand.ExecuteNonQuery();
//            }

//            Console.WriteLine("Таблица Attributes успешно создана.");
//        }

//    }
//}