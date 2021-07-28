using System;
using System.Data;
using System.Data.SQLite;
using ProductsControl.Models;

namespace ProductsControl.Configs
{
    public class DatabaseConfig
    {
        private static SQLiteConnection sQLiteConnection;

        private static SQLiteConnection DbConnection()
        {
            sQLiteConnection = new SQLiteConnection("Data Source=D:/source/learn/c#/ProductsControl/ProductsControl/Database/Database.sqlite; Version=3");
            sQLiteConnection.Open();
            return sQLiteConnection;
        }

        public static void CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(@"D:/source/learn/c#/ProductsControl/ProductsControl/Database/Database.sqlite");
            }
            catch
            {
                throw;
            }
        }

        public static void CreateProductsTable()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS products(id int PRIMARY KEY AUTOINCREMENT NOT NULL, name varchar(200), inventory int(10), price decimal)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetProducts()
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM products";
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetProduct(int productId)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM product WHERE id =" + productId;
                    dataAdapter = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AddProduct(Product product)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO products(id, name, inventory, price) values (@id, @name, @inventory, @price)";
                    cmd.Parameters.AddWithValue("@id", product.id);
                    cmd.Parameters.AddWithValue("@name", product.name);
                    cmd.Parameters.AddWithValue("@inventory", product.inventory);
                    cmd.Parameters.AddWithValue("@price", product.price);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateProduct(Product product)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE products SET name=@name, inventory=@inventoy, price=@price WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", product.id);
                    cmd.Parameters.AddWithValue("@name", product.name);
                    cmd.Parameters.AddWithValue("@inventory", product.inventory);
                    cmd.Parameters.AddWithValue("@price", product.price);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int productId)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM products WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
