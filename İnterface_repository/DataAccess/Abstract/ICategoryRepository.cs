using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using İnterface_repository.entity;

namespace İnterface_repository.DataAccess.Abstract
{
    //IRepository içindeki tüm niteliklere sahip olmakta
    public interface ICategoryRepository : IRepository<Category>
    {
        Category[] GetCategories();
    }
}