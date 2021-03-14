using DecoratorPatternExample.Beverages;

namespace DecoratorPatternExample.Addons
{
    public class SoyMilkAddOn : AddOnDecorator
    {
        public SoyMilkAddOn(Beverage beverage) 
            : base(beverage)
        {
        }

        public override long CaluculateCost()
        {
            return base.CaluculateCost() + 150;
        }
    }
}
