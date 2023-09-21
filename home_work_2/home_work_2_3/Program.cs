using System;

namespace home_work_2_3
{
    struct DecimalNumber
    {
        private int decimalValue;

        public DecimalNumber(int value)
        {
            decimalValue = value;
        }

        public string ToBinary()
        {
            int value = decimalValue;
            string result = string.Empty;

            if (value == 0)
                return "0";

            while (value > 0)
            {
                int remainder = value % 2;
                result = remainder + result;
                value /= 2;
            }

            return result;
        }

        public string ToOctal()
        {
            int value = decimalValue;
            string result = string.Empty;

            if (value == 0)
                return "0";

            while (value > 0)
            {
                int remainder = value % 8;
                result = remainder + result;
                value /= 8;
            }

            return result;
        }

        public string ToHexadecimal()
        {
            int value = decimalValue;
            string result = string.Empty;

            if (value == 0)
                return "0";

            while (value > 0)
            {
                int remainder = value % 16;
                if (remainder < 10)
                    result = remainder + result;
                else
                    result = ((char)('A' + remainder - 10)) + result;

                value /= 16;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть десяткове число: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            DecimalNumber num = new DecimalNumber(userInput);

            Console.WriteLine("Десяткове: " + userInput);
            Console.WriteLine("Двійкове: " + num.ToBinary());
            Console.WriteLine("Вісімкове: " + num.ToOctal());
            Console.WriteLine("Шістнадцяткове: " + num.ToHexadecimal());
        }
    }
}
