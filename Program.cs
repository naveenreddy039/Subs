using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Division objDivision = new Division();
            Console.WriteLine("total value" + objDivision.isDiv(30, 20));
            Console.ReadKey();
        }
    }
}
