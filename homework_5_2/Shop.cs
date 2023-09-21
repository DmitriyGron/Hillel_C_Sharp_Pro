namespace homework_5_2

{
    enum ShopType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    class Shop : IDisposable
    {
        public string ShopName { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        public Shop(string shopName, string address, ShopType type)
        {
            ShopName = shopName;
            Address = address;
            Type = type;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {ShopName}");
            Console.WriteLine($"Адрес: {Address}");
            Console.WriteLine($"Тип: {Type}");
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


}
