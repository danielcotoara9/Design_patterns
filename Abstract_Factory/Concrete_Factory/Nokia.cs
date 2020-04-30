using Abstract_Factory.Abstractization;
using Abstract_Factory.Abstractization_Product;
using Abstract_Factory.Concrete_Product;

namespace Abstract_Factory.Concrete_Factory
{
    /// <summary>  
    /// The 'ConcreteFactory1' class.  
    /// </summary> 
    public class Nokia : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
}
