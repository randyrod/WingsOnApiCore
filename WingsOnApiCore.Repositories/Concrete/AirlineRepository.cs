using WingsOnApiCore.Models;
using WingsOnApiCore.Repositories.Abstract;

namespace WingsOnApiCore.Repositories.Concrete
{
    public class AirlineRepository : RepositoryBase<AirlineModel>, IAirlineRepository
    {
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