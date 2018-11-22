using WingsOnApiCore.Models;

namespace WingsOnApiCore.Repositories.Abstract
{
    public interface IAirlineRepository : IRepository<AirlineModel>
    {
        AirlineModel GetAirlineByName(string airlineName);

        AirlineModel GetAirlineByCode(string airlineCode);
    }
}