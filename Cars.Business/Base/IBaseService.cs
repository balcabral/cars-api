using System;
using System.Collections.Generic;

namespace Cars.Business.Base
{
	public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity FindById(long id);
        IEnumerable<TEntity> RetrieveAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(long id);
    }
}
