using Abstract_Factory.Abstractization;
using Abstract_Factory.Abstractization_Product;
using Abstract_Factory.Concrete_Product;

namespace Abstract_Factory.Concrete_Factory
{
    /// <summary>  
    /// The 'ConcreteFactory2' class.  
    /// </summary>
    public class Samsung : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}
