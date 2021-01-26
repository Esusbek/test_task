using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class Worker : Employee
    {
        public Worker(int exp, string name)
            : base(exp, name)
        { }

        public override string Work()
        {
            return "some products";
        }

        public override string ToString()
        {
            return $"Regular worker {FullName} with {Experience} years of experience ";
        }
    }
}
