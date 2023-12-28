using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using İnterface_repository.DataAccess.Abstract;
using İnterface_repository.entity;

namespace Interface_repository.DataAccess.Abstract
{
    //IRepository içindeki tüm niteliklere sahip olmakta
    public interface IProductRepository:IRepository<Product>
    {
        Product[] GetProductsByCategoryId(int id);
    }
}
