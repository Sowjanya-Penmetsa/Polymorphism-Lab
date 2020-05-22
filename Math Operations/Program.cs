using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Math_Operations mo = new Math_Operations();

            Console.WriteLine(mo.Add(2, 3));

            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));

            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
