using WingsOnApiCore.Models;

namespace WingsOnApiCore.Services.Abstract
{
    public interface IAirlineService : IService<AirlineModel>
    {
        AirlineModel GetAirlineByName(string airlineName);

        AirlineModel GetAirlineByCode(string airlineCode);
    }
}