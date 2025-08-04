using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI_CD_Project_with_Unit_Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe bitte deine erste Zahl ein, welche du addieren möchtest");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gebe bitte deine zweite Zahl ein, welche du addieren möchtest");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            int sum = zahl1 + zahl2;

            Console.WriteLine("Das Ergbnis ist: " + sum);
        }
    }
}
