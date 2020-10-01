using System;

namespace week3ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Whatunitisit w = new Whatunitisit();
            w.Unitstotest1(7);
            w.Unitstotest1(1001);

            Console.Read();
            w.Unitstotest1(1678);

        }
    }
}
