using Decorator.Abstractization;

namespace Decorator
{
    public class Espresso : Beverages
    {
        public override int Cost()
        {
            return Constants.Espresso_Cost;
        }
    }
}
