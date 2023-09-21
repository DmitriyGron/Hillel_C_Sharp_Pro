namespace homework_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Play hamlet = new Play("Уильям Шекспир", "Цимбелин", "Трагедия", 1611);

            hamlet.DisplayInfo();

            hamlet = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}