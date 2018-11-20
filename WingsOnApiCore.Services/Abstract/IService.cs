using System.Collections.Generic;

namespace WingsOnApiCore.Services.Abstract
{
    public interface IService<out T>
    {
        T Get(int id);

        IEnumerable<T> GetAll();
    }
}