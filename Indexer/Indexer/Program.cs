using Indexer.Models;
using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
             Garage g = new Garage(3);
            
            Car c1 = new Car("BMW", "BMW");
            Car c2 = new Car("Mercedes", "Altima");
            g[0] = c1;
            g[1] = c2;
            Console.WriteLine(g[0]);
        }
    }
}
