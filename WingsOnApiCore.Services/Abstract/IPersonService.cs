using System.Collections.Generic;
using WingsOnApiCore.Models;

namespace WingsOnApiCore.Services.Abstract
{
    public interface IPersonService : IService<PersonModel>
    {
        IEnumerable<PersonModel> GetPeopleByGender(GenderType gender);
    }
}