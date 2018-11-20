using System;
using System.Collections.Generic;
using System.Linq;
using WingsOnApiCore.Models;
using WingsOnApiCore.Repositories.Abstract;

namespace WingsOnApiCore.Repositories.Concrete
{
    public class PersonRepository : RepositoryBase<PersonModel>, IPersonRepository
    {
        public PersonRepository()
        {
            Repository.AddRange(new []
            {
                new PersonModel
                {
                    Id = 91,
                    Address = "Address 1",
                    DateBirth = DateTime.Today,
                    Email = "name@name.com",
                    Name = "Person 1",
                    
                }, 
            });
        }

        public IEnumerable<PersonModel> GetPeopleByGender(GenderType gender)
        {
            return GetAll().Where(p => p.Gender == gender);
        }
    }
}