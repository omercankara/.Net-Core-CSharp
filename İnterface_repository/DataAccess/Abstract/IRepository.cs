using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İnterface_repository.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        TEntity GetById(int id);

    }
}