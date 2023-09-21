using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace homework_7
{
    class Program
    {
        static readonly object locker = new object();
        static bool barberSleeping = true;

        static void Main(string[] args)
        {
            Thread barberThread = new Thread(BarberWork);
            barberThread.Start();

            for (int i = 0; i < 10; i++)
            {
                Thread clientThread = new Thread(ClientArrives);
                clientThread.Start(i);
                Thread.Sleep(1000); 
            }

            Console.ReadLine();

        }

        static void BarberWork()
        {
            while (true)
            {
                lock (locker)
                {
                    if (barberSleeping)
                    {
                        Console.WriteLine("Перукар спить.");
                        Monitor.Wait(locker);
                    }

                    Console.WriteLine("Перукар стриже відвідувача.");
                    Thread.Sleep(2000); 
                    Console.WriteLine("Перукар закінчив стрижку.");

                    Monitor.Pulse(locker); 
                    barberSleeping = true;
                }
            }
        }

        static void ClientArrives(object clientNumber)
        {
            lock (locker)
            {
                int client = (int)clientNumber;

                if (!barberSleeping)
                {
                    Console.WriteLine($"Відвідувач {client} залишив перукарню, бо немає вільних місць.");
                    return;
                }

                Console.WriteLine($"Відвідувач {client} прийшов до перукарні.");
                barberSleeping = false;
                Monitor.Pulse(locker); 
                Monitor.Wait(locker); 
                Console.WriteLine($"Відвідувач {client} пішов після стрижки.");
            }
        }

    }
}
