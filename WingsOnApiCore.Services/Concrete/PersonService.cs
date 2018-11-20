using System.Collections.Generic;
using WingsOnApiCore.Models;
using WingsOnApiCore.Services.Abstract;

namespace WingsOnApiCore.Services.Concrete
{
    public class PersonService : ServiceBase, IPersonService
    {
        public PersonModel Get(int id)
        {
            return DbContext.PersonRepository.Get(id);
        }

        public IEnumerable<PersonModel> GetAll()
        {
            return DbContext.PersonRepository.GetAll();
        }

        public IEnumerable<PersonModel> GetPeopleByGender(GenderType gender)
        {
            return DbContext.PersonRepository.GetPeopleByGender(gender);
        }
    }
}