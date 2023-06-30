using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RestaurantAPI.Services.Base
{
    public class ServiceResponse<T>
    {
        public ServiceResponse(T obj)
        {
            Success = true;
            Message = string.Empty;
            ReturnObject = obj;
        }

        public ServiceResponse(string errorMessage)
        {
            Success = false;
            Message = errorMessage;
            ReturnObject = default;
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
        public T ReturnObject { get; private set; }
    }
}

