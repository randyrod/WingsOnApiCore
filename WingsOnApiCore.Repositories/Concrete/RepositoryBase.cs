using System.Collections.Generic;
using System.Linq;
using WingsOnApiCore.Models;

namespace WingsOnApiCore.Repositories.Concrete
{
    public class RepositoryBase<T> where T : BaseModel
    {
        protected List<T> Repository;

        protected RepositoryBase()
        {
            Repository = new List<T>();
        }
        
        public IEnumerable<T> GetAll()
        {
            return Repository;
        }

        public T Get(int id)
        {
            return Repository.FirstOrDefault(elem => elem.Id == id);
        }

        public void Save(T element)
        {
            if (element == null)
            {
                return;
            }

            var exists = Get(element.Id);

            if (exists != null)
            {
                Repository.Remove(exists);
            }
            
            Repository.Add(element);
        }
    }
}