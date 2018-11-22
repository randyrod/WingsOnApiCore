using WingsOnApiCore.Repositories.Abstract;
using WingsOnApiCore.Repositories.Concrete;

namespace WingsOnApiCore.Services
{
    public class WingsOnDbContext
    {
        public readonly IPersonRepository PersonRepository;
        public readonly IAirlineRepository AirlineRepository;

        public WingsOnDbContext()
        {
            PersonRepository = new PersonRepository();
            AirlineRepository = new AirlineRepository();
        }
    }
}