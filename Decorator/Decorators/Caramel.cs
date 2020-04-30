using Decorator.Abstractization;

namespace Decorator.Decorators
{
    //Carammel is a decorator for Espresso -> is a AddonDecorator => is a Beverage
    public class Caramel : AddonDecorator
    {
        private Beverages bevarage;
        public Caramel(Beverages _bevarage)
        {
            bevarage = _bevarage;
        }
        public override int Cost()
        {
            return bevarage.Cost() + 1;
        }
    }
}
