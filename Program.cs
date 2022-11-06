using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 100)
            {
                Console.WriteLine("третьей цифры нет");
            }
            else
            {
                while (n > 1000)
                {
                    n /= 10;
                }
                Console.WriteLine("{0}", n % 10);
            }
            Console.ReadKey();
        }
    }
}
