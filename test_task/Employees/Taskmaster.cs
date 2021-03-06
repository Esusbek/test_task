﻿using System;
using System.Collections.Generic;

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

        public override string ToString()
        {
            return $"Taskmaster {FullName} with {Experience} years of experience ";
        }
    }
}
