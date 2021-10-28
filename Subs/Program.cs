using System;

namespace Subs
{
    class Program
    {
        static void Main(string[] args)
        {
            Substraction objSubstraction = new Substraction();
            Console.WriteLine("total values" + objSubstraction.isDiff(30, 20));
            Console.ReadKey();
        }
    }
}
