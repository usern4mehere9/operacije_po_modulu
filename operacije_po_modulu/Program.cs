using System;

namespace operacije_po_modulu
{
    class Program
    {
        static void Main(string[] args)
        {
            long m, n, o, p, z, pr, zz, zpr, a, b;

            m = long.Parse(Console.ReadLine());
            n = long.Parse(Console.ReadLine());
            o = long.Parse(Console.ReadLine());
            p = long.Parse(Console.ReadLine());

            z = m + n + o + p;
            pr = m * n * o * p;

            a = z % 1000;
            b = pr % 1000;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
