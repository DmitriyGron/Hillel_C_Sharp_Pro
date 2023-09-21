namespace homework_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Shop groceryShop = new Shop("СуперТЦ", "Гетманська 47", ShopType.Grocery))
            {
                groceryShop.DisplayInfo();
            }

        }
    }
}