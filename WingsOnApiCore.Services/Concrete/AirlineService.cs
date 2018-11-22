using System.Collections.Generic;
using WingsOnApiCore.Models;
using WingsOnApiCore.Services.Abstract;

namespace WingsOnApiCore.Services.Concrete
{
    public class AirlineService : ServiceBase, IAirlineService
    {
        public AirlineModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AirlineModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public AirlineModel GetAirlineByName(string airlineName)
        {
            throw new System.NotImplementedException();
        }

        public AirlineModel GetAirlineByCode(string airlineCode)
        {
            throw new System.NotImplementedException();
        }
    }
}