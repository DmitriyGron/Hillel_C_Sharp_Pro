using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_3_3
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }
    public interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class Array : IOutput, ISort
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

        public void SortAsc()
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - i - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        int k = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = k;
                    }
                }
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - i - 1; j++)
                {
                    if (elements[j] < elements[j + 1])
                    {
                        int k = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = k;
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            int[] mass = { 5, 3, 1, 4, 2, 6, 8, 9 };
            Array array = new Array(mass);

            Console.WriteLine("Масив:");
            array.Show();

            array.SortAsc();
            Console.WriteLine("Масив за зростанням:");
            array.Show();

            array.SortDesc();
            Console.WriteLine("Масив спаданням:");
            array.Show();

            array.SortByParam(true);
            Console.WriteLine("Масив з використанням SortByParam:");
            array.Show();
        }
    }

}
