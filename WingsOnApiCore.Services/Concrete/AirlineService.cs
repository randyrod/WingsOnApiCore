using System;
using System.Collections.Generic;
using WingsOnApiCore.Models;
using WingsOnApiCore.Services.Abstract;

namespace WingsOnApiCore.Services.Concrete
{
    public class AirlineService : ServiceBase, IAirlineService
    {
        public AirlineModel Get(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException($"The Id cannot be negative: {id}");
            }
            
            return DbContext.AirlineRepository.Get(id);
        }

        public IEnumerable<AirlineModel> GetAll()
        {
            return DbContext.AirlineRepository.GetAll();
        }

        public AirlineModel GetAirlineByName(string airlineName)
        {
            return DbContext.AirlineRepository.GetAirlineByName(airlineName);
        }

        public AirlineModel GetAirlineByCode(string airlineCode)
        {
            return DbContext.AirlineRepository.GetAirlineByCode(airlineCode);
        }
    }
}