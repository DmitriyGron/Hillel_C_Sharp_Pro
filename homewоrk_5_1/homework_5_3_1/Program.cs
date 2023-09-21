namespace homework_5_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Play play = new Play("Гамлет", "Вільям Шекспір", "Трагедія", 1600))
            {
                play.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}