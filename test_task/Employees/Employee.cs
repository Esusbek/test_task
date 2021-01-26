namespace test_task
{
    abstract class Employee
    {
        public int Experience { get; set; }
        public string FullName { get;}

        public Employee(int exp, string name)
        {
            Experience = exp;
            FullName = name;
        }
        public abstract string Work();
    }
}
