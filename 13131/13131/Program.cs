using System;

namespace _13131
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 200;
            bool proverka;
            if (min < max)
            {
                for (int i = min; i <= max; i++)
                {
                    proverka = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            proverka = false;
                            break;
                        }
                    }
                    if (proverka)
                        Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
