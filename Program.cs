using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // za pomoc adaptera laczymy niekompatybilne klasy ze soba i mozemy sie odwolwyac do ich metod
           
                Adaptee adaptee = new Adaptee();
                ITarget target = new Adapter(adaptee);

                Console.WriteLine("Adaptee interface is incompatible with the client.");
                Console.WriteLine("But with adapter client can call it's method.");

                Console.WriteLine(target.GetRequest());

            Console.ReadKey(); ;
        }
    }
}
