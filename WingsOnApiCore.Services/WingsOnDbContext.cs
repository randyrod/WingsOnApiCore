using WingsOnApiCore.Repositories.Abstract;
using WingsOnApiCore.Repositories.Concrete;

namespace WingsOnApiCore.Services
{
    public class WingsOnDbContext
    {
        public readonly IPersonRepository PersonRepository;

        public WingsOnDbContext()
        {
            PersonRepository = new PersonRepository();
        }
    }
}