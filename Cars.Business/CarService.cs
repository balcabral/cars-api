using System;
using Cars.Business.Base;
using Cars.Data;
using Cars.Model;

namespace Cars.Business
{
	public class CarService : BaseService<Car>, ICarService
    {
		private readonly IUnitOfWork _unitOfWork;

		public CarService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
		public override void Create(Car entity)
        {         
            base.Create(entity);
        }
    }
}
