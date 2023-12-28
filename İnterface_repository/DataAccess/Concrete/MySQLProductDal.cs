using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface_repository.DataAccess.Abstract;
using İnterface_repository.entity;

namespace İnterface_repository.DataAccess.Concrete
{
    public class MySQLProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
           Console.WriteLine("MYSQL PRODUCT CREATE");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}