using System;
using Interface_repository.DataAccess.Abstract;
using İnterface_repository.DataAccess.Concrete;
using İnterface_repository.entity;


namespace Name
{
    class ProductManager : IProductRepository
    {
        IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Create(Product entity)
        {
            _repository.Create(entity);
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
    class Program
    {
        static void Main(string[] args)
        {
            var productDal = new ProductManager(new MySQLProductDal());
            productDal.Create(new Product());
        }
    }
}