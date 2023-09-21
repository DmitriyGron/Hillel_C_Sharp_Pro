using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_2
{
    class Money
    {
        private int _uah;
        private int _pennies;

        public int Uah
        {
            set
            {
                _uah = value;
            }
            get
            {
                return _uah;
            }

        }

        public int Pennies
        {
            set
            {
                _pennies = value;
            }
            get
            {
                return _pennies;
            }
        }

        public Money(int uah, int pennies)
        {
            this._uah = uah;
            this._pennies = pennies;
        }

        public void Print()
        {
            Console.WriteLine($"Загальна сума: {_uah} гривень та {_pennies} копійок.");
        }

    }

    class Product
    {
        private string _name;
        private Money _price;

        public string Name
        {
            get 
            {
                return _name; 
            }
            set 
            { 
                _name = value; 
            }
        }

        public Money Price
        {
            get 
            {
                return _price; 
            }
            set 
            { 
                _price = value; 
            }
        }

        public Product(string name, Money price)
        {
            this._name = name;
            this._price = price;
        }

        public void changePrice(Money sum)
        {
            if (sum.Uah > _price.Uah || (sum.Uah == _price.Uah && sum.Pennies > _price.Pennies))
            {
                Console.WriteLine("Помилка: неможливо знизити ціну більше, ніж початкова.");
            }
            else
            {
                _price.Uah -= sum.Uah;
                _price.Pennies -= sum.Pennies;

                if (_price.Pennies < 0)
                {
                    _price.Uah -= 1;
                    _price.Pennies += 100;
                }

                Console.WriteLine($"Ціна {_name} зменшена на {sum.Uah} гривень та {sum.Pennies} копійок.");
            }
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Ціна {_name}: {_price.Uah} гривень та {_price.Pennies} копійок.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Money mon1 = new Money(80000, 50);
            Money mon2 = new Money(500000, 75);

            Product prod1 = new Product("Машина", mon1);
            Product prod2 = new Product("Літак", mon2);

            prod1.PrintPrice();
            prod2.PrintPrice();

            

            Money changePrice = new Money(4600, 50);
            prod1.changePrice(changePrice);

            prod1.PrintPrice();
        }
    }
}
