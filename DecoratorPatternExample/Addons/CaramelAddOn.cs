using DecoratorPatternExample.Beverages;

namespace DecoratorPatternExample.Addons
{
    public class CaramelAddOn : AddOnDecorator
    {

        public CaramelAddOn(Beverage beverage)
            : base(beverage)
        {
        }

        public override long CaluculateCost()
        {
            return base.CaluculateCost() + 300;
        }

    }
}
