using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lou.Data
{
    [Table("Employee")]
    public class Employee : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int? GroupId { get; set; }

    }
}
