using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    public abstract class Bicycle
    {

       public abstract string GetDescription();

         public abstract double GetPrice();
   

}
    class CityBicycle: Bicycle
    {
        public override string GetDescription()
        {

            return "Rower miejski";
        }

        public override double GetPrice()
        {
            return 700.5;
        }
    }

    class Mountianbicycle : Bicycle
    {
        public override string GetDescription()
        {

            return "Rower gorski";
        }


        public override double GetPrice()
        {
            return 699.99;
        }
    }

}
