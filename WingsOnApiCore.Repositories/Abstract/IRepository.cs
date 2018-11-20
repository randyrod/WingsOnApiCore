using System.Collections.Generic;
using WingsOnApiCore.Models;

namespace WingsOnApiCore.Repositories.Abstract
{
    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Save(T element);
    }
}