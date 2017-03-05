using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lou.Data
{
    public class EmployeeRepository : BaseRepository<Employee>, IRepository<Employee>
    {
        public EmployeeRepository()
        {

        }
    }
}