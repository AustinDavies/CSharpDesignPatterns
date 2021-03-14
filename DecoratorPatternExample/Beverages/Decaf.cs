using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExample.Beverages
{
    public class Decaf : Beverage
    {
        public override long CaluculateCost()
        {
            return 150;
        }
    }
}
