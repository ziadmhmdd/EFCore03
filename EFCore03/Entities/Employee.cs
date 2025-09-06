using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        //public Department? department { get; set; }
        public Department? WorkFor { get; set; }
        //public int WorkForId { get; set; }

    }
}
