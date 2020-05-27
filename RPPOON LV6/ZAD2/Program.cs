using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("novcanik", 250);
            Product p2 = new Product("bokal za vodu", 25);
            Product p3 = new Product("ulazna vrata", 2600);

            Box kutija = new Box();
            kutija.AddProduct(p1);
            kutija.AddProduct(p2);
            kutija.AddProduct(p3);

            IAbstractIterator iterator = kutija.GetIterator();

            while (!iterator.IsDone)
            {
                Console.WriteLine(iterator.Current);
                iterator.Next();
            }
        }
    }
}
