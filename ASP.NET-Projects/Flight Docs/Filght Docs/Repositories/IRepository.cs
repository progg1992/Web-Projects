using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filght_Docs.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);
    }
}
