using System;

namespace Class27102020
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            IHasValue[] values = new IHasValue[10];

            for (int i = 0; i < values.Length; i++)
            {
                int x = rnd.Next(1, 11);

                if (x < 4)
                {
                    values[i] = new Building($"Building {i}", (i + x) * x, (i + x) / x);
                }
                else if (x < 7)
                {
                    values[i] = new SettlerUnit(i, x * i + x);
                }
                else
                    values[i] = new MilitaryUnit(i, x * i + x, x * i + 100);
            }

            for (int i = 0; i < values.Length; i++)
            {
                System.Console.WriteLine($"Value {i}");
                System.Console.WriteLine($"Type: {values[i].GetType().Name}");
                Console.WriteLine(i > 0 ? values[i - 1].Equals(values[i]) ? "Equal to previous!" : "Different to previous!" : "First value!");

                System.Console.WriteLine();
            }
        }
    }
}
