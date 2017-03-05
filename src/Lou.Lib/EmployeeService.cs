using Lou.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lou.Lib
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> empRepository;
        private readonly IRepository<Group> groupRepository;
        public EmployeeService(IRepository<Employee> empRepository, IRepository<Group> groupRepository)
        {
            this.empRepository = empRepository;
            this.groupRepository = groupRepository;
        }

        public object GetById(int id)
        {
            var emp = empRepository.GetById(id);
            var group = groupRepository.GetById(id);

            return new EmpDto() { Employee = emp, Group = group };
        }
    }
}
