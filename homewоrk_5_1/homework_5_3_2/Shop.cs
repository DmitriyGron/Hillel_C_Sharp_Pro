namespace homework_5_3_2
{
    public class Shop
    {
        private string name;
        private string address;
        private ShopType type;

        public enum ShopType
        {
            Grocery,
            Household,
            Clothing,
            Footwear
        }

        public Shop(string name, string address, ShopType type)
        {
            this.name = name;
            this.address = address;
            this.type = type;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public ShopType Type
        {
            get { return type; }
            set { type = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Назва магазину: {name}");
            Console.WriteLine($"Адреса магазину: {address}");
            Console.WriteLine($"Тип магазину: {type}");
        }

        ~Shop()
        {
            Console.WriteLine($"Магазин \"{name}\" був видалений.");
        }
    }
}
