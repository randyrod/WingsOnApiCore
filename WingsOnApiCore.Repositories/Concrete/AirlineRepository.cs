using System;
using System.Linq;
using WingsOnApiCore.Models;
using WingsOnApiCore.Repositories.Abstract;

namespace WingsOnApiCore.Repositories.Concrete
{
    public class AirlineRepository : RepositoryBase<AirlineModel>, IAirlineRepository
    {

        public AirlineRepository()
        {
            Repository.AddRange(new []
            {
                new AirlineModel
                {
                    Id = 1,
                    Address = "Address 1",
                    Code = "1",
                    Name = "Airline Name1"
                }, 
            });
        }
        
        public AirlineModel GetAirlineByName(string airlineName)
        {
            if (string.IsNullOrEmpty(airlineName))
            {
                throw new ArgumentNullException($"The name cannot be null or empty");
            }

            return GetAll().FirstOrDefault(a => a.Name == airlineName);
        }

        public AirlineModel GetAirlineByCode(string airlineCode)
        {
            if (string.IsNullOrEmpty(airlineCode))
            {
                throw new ArgumentNullException($"The code cannot be null or empty");
            }

            return GetAll().FirstOrDefault(a => a.Code == airlineCode);
        }
    }
}