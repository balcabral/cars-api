using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Infrastructure.Errors
{
    public class ResponseError
    {
		public string Type
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public static BadRequestObjectResult GetError(List<ResponseError> responseErrors)
        {
            var errors = new
            {
                errors = responseErrors
            };

            return new BadRequestObjectResult(errors)
            {
                ContentTypes = { "application/json" }
            };
        }
    }
}
