using DecoratorPatternExample.Beverages;

namespace DecoratorPatternExample.Addons
{
    public abstract class AddOnDecorator : Beverage
    {
        protected readonly Beverage _beverage;
        public AddOnDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override long CaluculateCost()
        {
            return _beverage.CaluculateCost();
        }
    }
}
