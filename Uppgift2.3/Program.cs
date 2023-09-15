using System;
namespace Uppgift_2.__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?..");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer ska du köra?..");
            int km = int.Parse(Console.ReadLine());
            int ans = 300 + km + 500 * dagar;
            Console.WriteLine("Detta kommer att kosta dig " + ans + " kr");
        }
    }
}
