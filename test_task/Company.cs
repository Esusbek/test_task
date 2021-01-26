using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task
{
    class Company
    {
        private List<Employee> Staff { get; set; }
        public Company()
        {}
        public Company(List<Employee> staff)
        {
            Staff = staff;
        }
        public static Company operator +(Company company, Employee person)
        {
            List<Employee> newStaff = company.Staff.ToList();
            newStaff.Add(person);
            return new Company(newStaff);
        }
        public static Company operator -(Company company, Employee person)
        {
            List<Employee> newStaff = company.Staff.ToList();
            newStaff.Remove(person);
            return new Company(newStaff);
        }

        public bool FindStaff(Employee person)
        {
            var selectResult = from emp in Staff where (emp.FullName == person.FullName) && (emp.Experience == person.Experience)
                               select emp;
            if (selectResult != null)
                return true;
            return false;
        }

        public List<T> GetStaff<T>()
        {
            return Staff.OfType<T>().ToList<T>();
        }

        public int CountStaff<T>()
        {
            return Staff.OfType<T>().Count();
        }

        public void ShowStaff()
        {
            foreach (Employee person in Staff)
            {
                Console.WriteLine(person.ToString());

            }
        }
    }
}
