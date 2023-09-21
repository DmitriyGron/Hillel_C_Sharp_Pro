namespace homework_5_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Супермаркет", "Гетманська, 123", Shop.ShopType.Grocery);

            shop.DisplayInfo();

            Console.ReadLine();
        }
    }
}