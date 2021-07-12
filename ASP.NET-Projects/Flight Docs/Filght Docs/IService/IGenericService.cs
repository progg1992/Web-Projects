using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filght_Docs.IService
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        List<T> GetById(int id);
        List<T> Insert(T item);
        List<T> Delete(int id);
    }
}
