using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Cars.Business;
using Cars.Model;
using Cars.Infrastructure.Errors;

namespace Cars.WebApi.Controllers
{
	[Route("api/cars")]
	public class CarController : BaseController
    {
		private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
			_carService = carService;
        }

		/// <summary>
        /// Create car
        /// </summary>
        /// <returns>Return the created car</returns>
        /// <param name="car">Car.</param>
		/// <response code="200">Return the created car</response>
        /// <response code="400">error</response>
        [HttpPost]
        [ProducesResponseType(typeof(Car), 200)]
        [ProducesResponseType(typeof(List<ResponseError>), 400)]
        [ProducesResponseType(404)]
        public IActionResult CreatePlant([FromBody] Car car)
        {
            try
            {            
                _carService.Create(car);

				return Created("Create", car);
            }
            catch (Exception exception)
            {
                return GetErrors(exception);
            }
        }

		protected BadRequestObjectResult GetErrors(Exception exception)
        {
            return ResponseError.GetError(new List<ResponseError>
            {
                new ResponseError
                {
                    Type = exception.GetType().Name,
                    Message = exception.Message
                }
            });
        }
    }
}
