using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
   abstract class BicycleDecorator: Bicycle
    {

        Bicycle bicycle;

        public BicycleDecorator(Bicycle bicycle)
        {

            this.bicycle = bicycle;
        }
        public Bicycle GetBicycle()
        {

            return bicycle;
        }

        public void SetBicycle( Bicycle bicycle)
        {


            this.bicycle = bicycle;
        }
    }


    class FrontLight  : BicycleDecorator
    {
        public override string GetDescription()
        {

            return GetBicycle().GetDescription() + ", lampka przednia";
        }

        public override double GetPrice()
        {
            return GetBicycle().GetPrice() +  29.99;
        }

        public FrontLight(Bicycle bicycle) : base(bicycle) {}
    }
}
