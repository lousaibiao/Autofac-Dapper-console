using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lou.Data
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
