using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_3_1
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] array)
        {
            elements = array;
        }

        public void Show()
        {
            Console.WriteLine("Масив:");
            foreach (int element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine("Інфа: " + info);
            Show();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array ar = new Array(array);

            ar.Show();
            ar.Show("Масив");

        }
    }
}
