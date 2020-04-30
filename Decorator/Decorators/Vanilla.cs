using Decorator.Abstractization;

namespace Decorator.Decorators
{
    public class Vanilla : AddonDecorator
    {
        private Beverages beverages;

        public Vanilla(Beverages _beverages)
        {
            beverages = _beverages;
        }
        public override int Cost()
        {
            return beverages.Cost() + Constants.Vanilla_Cost;
        }
    }
}
