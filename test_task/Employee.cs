using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    abstract class Employee
    {
        public int Experience { get; set; }
        public string FullName { get; set; }

        public Employee(int exp, string name)
        {
            Experience = exp;
            FullName = name;
        }
        public abstract string Work();
    }
}
