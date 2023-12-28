using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Entity_fv
{
    //One To Many
    //One To One
    //Many To Many
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;port=3306;user=root;password=root;database=ShopDb;";
            ServerVersion version = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, version);
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string? userName { get; set; }
        public string? Email { get; set; }
        public List<Adress> adresses { get; set; }
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }
    public class Adress
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public User User { get; set; } //navigation property
        public int UserId { get; set; }
    }
    public class Product
    {
        public int Id { get; set; } //Primary key

        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int categoryId { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DateAdded { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new ShopContext())
            {
                // var customer = new Customer(){
                //     IdentityNumber = "23123",
                //     FirstName="Ömercan",
                //     LastName="Kara",
                //     User = db.Users.FirstOrDefault(i => i.Id == 3)
                // };  
                // db.Customers.Add(customer);
                // db.SaveChanges();

                var user = new User()
                {
                    userName="Zeynep",
                    Email = "Ayşe@gmail.co",
                    Customer = new Customer()
                    {
                        FirstName = "Ayşe",
                        LastName = "Eda",
                        IdentityNumber="12312421"
                    }
                };
                db.Users.Add(user);
                db.SaveChanges();

                // var user = db.Users.FirstOrDefault(i => i.userName == "Ömercan");
                // if (user != null)
                // {
                //     user.adresses = new List<Adress>();
                //     user.adresses.AddRange(
                //         new List<Adress>(){
                //             new Adress(){FullName="Ömercan Kara",Title = "iş Adresi 1 ",Body = "Ankara"},
                //             new Adress(){FullName="Ömercan Kara",Title = "iş Adresi 2",Body = "Ankara"}
                //         }
                //     );
                //     db.SaveChanges();
                // }
            }
            // InsertUser();
            //InserAdresses();

        }
        static void InsertUser()
        {
            var users = new List<User>(){
                new User(){userName = "Ömercan",Email = "Omercankara34@gmail.com"},
                new User(){userName = "Eda",Email = "Eda@gmail.com"},
                new User(){userName = "Ada",Email = "Ada@gmail.com"},
                new User(){userName = "Zeynep",Email = "Zeynep@gmail.com"}
            };
            using (var db = new ShopContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }
        static void InserAdresses()
        {
            var adresses = new List<Adress>()
            {
                new Adress(){FullName="Ömercan Kara",Title = "Ev Adresi",Body = "İstanbul", UserId=1},
                new Adress(){FullName="Eda Kara",Title = "iş Adresi",Body = "Ankara",UserId=2},
                new Adress(){FullName="Ada Kara",Title = "iş Adresi",Body = "İzmir",UserId=3},
                new Adress(){FullName="Seda Kara",Title = "Ev Adresi",Body = "Bursa",UserId=4}
            };
            using (var db = new ShopContext())
            {
                db.Adresses.AddRange(adresses);
                db.SaveChanges();
            }
        }

    }
}