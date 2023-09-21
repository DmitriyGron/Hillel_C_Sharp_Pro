using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_4_1
{
    class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double amount)
        {
            Salary += amount;
        }

        public void DecreaseSalary(double amount)
        {
            Salary -= amount;
        }

        public bool Equals(Employee other)
        {
            if (other == null) return false;
            return Name == other.Name && Salary == other.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals(obj as Employee);
        }

        public override int GetHashCode()
        {
            return (Name.GetHashCode() * 7) ^ Salary.GetHashCode();
        }

        public static bool operator ==(Employee first, Employee second)
        {
            if (ReferenceEquals(first, second))
                return true;
            if ((object)first == null || (object)second == null)
                return false;
            return first.Equals(second);
        }

        public static bool operator !=(Employee first, Employee second)
        {
            return !(first == second);
        }

        public static bool operator >(Employee first, Employee second)
        {
            return first.Salary > second.Salary;
        }

        public static bool operator <(Employee first, Employee second)
        {
            return first.Salary < second.Salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Вася", 2000);
            Employee employee2 = new Employee("Петя", 3000);

            Console.WriteLine("Співробітник 1: " + employee1.Name + ", Зарплата: " + employee1.Salary);
            Console.WriteLine("Співробітник 2: " + employee2.Name + ", Зарплата: " + employee2.Salary);

            employee1.IncreaseSalary(1000);
            employee2.DecreaseSalary(400);

            Console.WriteLine("Оновлена заробітна плата працівника 1: " + employee1.Salary);
            Console.WriteLine("Оновлена заробітна плата працівника 2: " + employee2.Salary);

            Console.WriteLine("Працівники мають рівні зарплати: " + (employee1 == employee2));
            Console.WriteLine("Працівник 1 має вищу зарплату, ніж працівник 2: " + (employee1 > employee2));
            Console.WriteLine("Працівник 2 має вищу зарплату, ніж працівник 1: " + (employee2 < employee1));
        }
    }

}
