using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_4_4
{
    class CreditCard
    {
        private string cardNumber;
        private int cvc;
        private double balance;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public int CVC
        {
            get { return cvc; }
            set { cvc = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public CreditCard(string cardNumber, int cvc, double balance)
        {
            CardNumber = cardNumber;
            CVC = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, double amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, double amount)
        {
            card.Balance -= amount;
            return card;
        }

        public bool Equals(CreditCard other)
        {
            if (other == null) return false;
            return CVC == other.CVC;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals(obj as CreditCard);
        }

        public override int GetHashCode()
        {
            return CVC.GetHashCode();
        }

        public static bool operator ==(CreditCard first, CreditCard second)
        {
            if (ReferenceEquals(first, second))
                return true;
            if ((object)first == null || (object)second == null)
                return false;
            return first.Equals(second);
        }

        public static bool operator !=(CreditCard first, CreditCard second)
        {
            return !(first == second);
        }

        public static bool operator >(CreditCard first, CreditCard second)
        {
            return first.Balance > second.Balance;
        }

        public static bool operator <(CreditCard first, CreditCard second)
        {
            return first.Balance < second.Balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CreditCard card1 = new CreditCard("1234-5432-9012-7654", 265, 1000);
            CreditCard card2 = new CreditCard("9876-5678-1098-3456", 972, 1500);

            Console.WriteLine("Картка 1: " + card1.CardNumber + ", CVC: " + card1.CVC + ", Баланс: $" + card1.Balance); ; ;
            Console.WriteLine("Картка 2: " + card2.CardNumber + ", CVC: " + card2.CVC + ", Баланс: $" + card2.Balance);

            card1 += 500;
            card2 -= 200;

            Console.WriteLine("Оновлений баланс картки 1: $" + card1.Balance);
            Console.WriteLine("Оновлений баланс картки 2: $" + card2.Balance);

            Console.WriteLine("Картки мають однакові коди CVC: " + (card1 == card2));
            Console.WriteLine("Картка 1 має більший баланс, ніж карта 2: " + (card1 > card2));
            Console.WriteLine("Картка 2 має нижчий баланс, ніж карта 1: " + (card2 < card1));
        }
    }

}
