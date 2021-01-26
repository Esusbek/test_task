using System;
using System.Collections.Generic;

namespace test_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Company C = new Company();
            Worker W = new Worker(5, "Vasiliy");
            Manager M = new Manager(10, "Petr");
            Taskmaster T = new Taskmaster(20, "Vitaliy");
            List<Worker> LW = new List<Worker>();
            LW.Add(W);
            C = C + W + M + T;
            C.ShowStaff();
            Console.WriteLine($"Worker work output: {W.Work()}");
            Console.WriteLine($"Manager work output: {M.Work()}");
            Console.WriteLine($"Taskmaster work output { T.Work()}");
            M.GiveTask(LW);
            T.CheckWorkers(LW);
            C = C - W;
            C.ShowStaff();
            Console.WriteLine($"Company has {C.CountStaff<Worker>()} workers");
            Console.WriteLine($"Does company have Taskmaster with name of {T.FullName} and {T.Experience} experience? {C.FindStaff(T)}");
            foreach (var person in C.GetStaff<Manager>())
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
