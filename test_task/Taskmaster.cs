using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class Taskmaster : Employee
    {
        public Taskmaster(int exp, string name)
            : base(exp, name)
        { }

        public override string Work()
        {
            return "Bought the materials";
        }

        public void CheckWorkers(List<Worker> workers)
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"Checked {worker.FullName}");
            }
        }
    }
}
