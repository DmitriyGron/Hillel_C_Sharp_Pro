using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_4_3
{
    class City
    {
        private string name;
        private int population;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City city, int amount)
        {
            city.Population += amount;
            return city;
        }

        public static City operator -(City city, int amount)
        {
            city.Population -= amount;
            return city;
        }

        public bool Equals(City other)
        {
            if (other == null) return false;
            return Population == other.Population;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals(obj as City);
        }

        public override int GetHashCode()
        {
            return Population.GetHashCode();
        }

        public static bool operator ==(City first, City second)
        {
            if (ReferenceEquals(first, second))
                return true;
            if ((object)first == null || (object)second == null)
                return false;
            return first.Equals(second);
        }

        public static bool operator !=(City first, City second)
        {
            return !(first == second);
        }

        public static bool operator >(City first, City second)
        {
            return first.Population > second.Population;
        }

        public static bool operator <(City first, City second)
        {
            return first.Population < second.Population;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            City city1 = new City("Новомосковськ", 1000000);
            City city2 = new City("Черкаське", 50000);

            Console.WriteLine("Місто 1: " + city1.Name + ", Населення: " + city1.Population);
            Console.WriteLine("Місто 2: " + city2.Name + ", Населення: " + city2.Population);

            city1 += 5000;
            city2 -= 1000;

            Console.WriteLine("Оновлене населення міста 1: " + city1.Population);
            Console.WriteLine("Оновлене населення міста 2: " + city2.Population);

            Console.WriteLine("Міста мають рівну кількість населення: " + (city1 == city2));
            Console.WriteLine("Місто 1 має більше населення, ніж місто 2: " + (city1 > city2));
            Console.WriteLine("Місто 2 має меншу кількість населення, ніж місто 1: " + (city2 < city1));
        }
    }

}
