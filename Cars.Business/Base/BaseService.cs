using System.Collections.Generic;
using System.Linq;
using Cars.Data;

namespace Cars.Business.Base
{
	public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<TEntity> entityRepository;

		public BaseService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.entityRepository = this.unitOfWork.GetRepository<TEntity>();
        }

        public virtual TEntity FindById(long id)
        {
            return entityRepository.FindById(id);
        }

        public virtual IEnumerable<TEntity> RetrieveAll()
        {
            return entityRepository.RetrieveAll();
        }

        public virtual void Create(TEntity entity)
        {
            entityRepository.Create(entity);
            this.unitOfWork.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            entityRepository.Update(entity);
            this.unitOfWork.SaveChanges();
        }

        public virtual void Delete(long id)
        {
            TEntity entity = entityRepository.FindById(id);
            entityRepository.Delete(entity);
            this.unitOfWork.SaveChanges();
        }
    }
}
