using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_3_2
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);

    }

    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput, IMath
    {
        private int[] elements;

        public Array(int[] array)
        {
            elements = array;
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"Інфа: {info}");
            Show();
        }
        
        public int Max()
        {
            int max = int.MinValue;
            foreach (var i in elements)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = int.MaxValue;
            foreach (var i in elements)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        public float Avg()
        {
            int sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return (float)sum / elements.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int element in elements)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        class Program
        {
            static void Main(string[] args)
            {
                int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Array arrayInstance = new Array(myArray);

                arrayInstance.Show();
                arrayInstance.Show("Масив");

                Console.WriteLine($"Максимум: {arrayInstance.Max()}");
                Console.WriteLine($"Мінімум: {arrayInstance.Min()}");
                Console.WriteLine($"Середнє: {arrayInstance.Avg()}");


                int valueToSearch = 7;
                if (arrayInstance.Search(valueToSearch))
                {
                    Console.WriteLine("Число знайдено");
                }
                else
                {
                    Console.WriteLine("Не знайдено");
                }
            }
        }
    }
}
