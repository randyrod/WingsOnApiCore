using System.Collections.Generic;
using WingsOnApiCore.Models;

namespace WingsOnApiCore.Repositories.Abstract
{
    public interface IPersonRepository : IRepository<PersonModel>
    {
        IEnumerable<PersonModel> GetPeopleByGender(GenderType gender);
    }
}