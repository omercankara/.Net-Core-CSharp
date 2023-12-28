using System;
using MySql.Data.MySqlClient;

namespace Database
{
    public interface IProductDal
    {
        List<Product> getAllProducts();
        Product GetProductById(int id);
        List<Product> Find(string name);
        void Create(Product p);
        void Update(Product p);
        void Delete(int productId);
    }

    public class MySqlProductDal : IProductDal
    {
        private MySqlConnection getMysqlConnection()
        {
            string connectionString = @"Server=localhost;port=3306;database=northwind;user=root;password=root;";
            return new MySqlConnection(connectionString);
        }

        public void Create(Product p)
        {
            
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> getAllProducts()
        {
            List<Product> Products = null;
            using (var connection = getMysqlConnection())
            {
                try
                {
                    connection.Open();
                    string mySql = "select * from products";
                    MySqlCommand command = new MySqlCommand(mySql, connection);
                    MySqlDataReader Reader = command.ExecuteReader();
                    Products = new List<Product>();
                    while (Reader.Read())
                    {
                        Products.Add(
                            new Product
                            {
                                ProductId = int.Parse(Reader["id"].ToString()),
                                Name = Reader["product_Name"].ToString(),
                                Price = double.Parse(Reader["list_price"]?.ToString())
                            }
                            );

                    }
                    Reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Products;
        }

        public Product GetProductById(int id)
        {
            Product Products = null;
            using (var connection = getMysqlConnection())
            {
                try
                {
                    connection.Open();
                    string mySql = "select * from products where id=@productid";
                    MySqlCommand command = new MySqlCommand(mySql, connection);
                    command.Parameters.Add("@productid", MySqlDbType.Int32).Value = id;
                    MySqlDataReader Reader = command.ExecuteReader();
                    Reader.Read();
                    if (Reader.HasRows)
                    {
                        Products = new Product()
                        {
                            ProductId = int.Parse(Reader["id"].ToString()),
                            Name = Reader["product_name"].ToString(),
                            Price = double.Parse(Reader["list_price"].ToString())
                        };
                    }
                    Reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Products;
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find(string productName)
        {
            List<Product> Products = null;
            using (var connection = getMysqlConnection())
            {
                try
                {
                    connection.Open();
                    string mySql = "select * from products where product_name LIKE @productName";
                    MySqlCommand command = new MySqlCommand(mySql, connection);
                    command.Parameters.Add("@productName", MySqlDbType.String).Value = "%" + productName + "%";
                    MySqlDataReader Reader = command.ExecuteReader();
                    Products = new List<Product>();
                    while (Reader.Read())
                    {
                        Products.Add(
                            new Product
                            {
                                ProductId = int.Parse(Reader["id"].ToString()),
                                Name = Reader["product_name"].ToString(),
                                Price = double.Parse(Reader["list_price"].ToString())
                            }
                        );
                    }

                    Reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return Products;
        }
    }
    public class ProductManager : IProductDal
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Create(Product p)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find(string productName)
        {
            return _productDal.Find(productName);
        }

        public List<Product> getAllProducts()
        {
            return _productDal.getAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productDal.GetProductById(id);
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var productDal = new ProductManager(new MySqlProductDal());
            var products = productDal.Find("Northwind");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name}");
            }
            // var Product = productDal.GetProductById(3);
            // Console.WriteLine($"{Product.Name}");
        }
    }

}
