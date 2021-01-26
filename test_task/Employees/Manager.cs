using System;
using System.Collections.Generic;

namespace test_task
{
    class Manager : Employee
    {
        public Manager(int exp, string name)
            : base(exp, name)
        { }

        public override string Work()
        {
            return "Collected orders";
        }

        public void GiveTask(List<Worker> workers)
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"Assigned task to {worker.FullName}");
            }
        }

        public override string ToString()
        {
            return $"Manager {FullName} with {Experience} years of experience ";
        }
    }
}
