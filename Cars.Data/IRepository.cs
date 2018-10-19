using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Cars.Data
{
	public interface IRepository<TEntity> where TEntity : class
    {
		IEnumerable<TEntity> RetrieveAll();
        TEntity FindById(long id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities); 
    }
}
