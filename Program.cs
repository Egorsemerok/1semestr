using System;

class Program
{
    static void Main()
    {
        for (int x = 2; x <= 8; x++)
        {
            for (int y = 2; y <= 5; y++)
            {
                double z = Math.Pow(x, y);
                Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
            }
        }
    }
}
