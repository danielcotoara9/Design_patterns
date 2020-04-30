using Decorator.Abstractization;

namespace Decorator.Decorators
{
    public abstract class AddonDecorator : Beverages
    {
        public abstract override int Cost();
    }
}
