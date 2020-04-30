using Abstract_Factory.Abstractization_Product;

namespace Abstract_Factory.Abstractization
{
    /// <summary>  
    /// The 'AbstractFactory' interface.  
    /// </summary>  
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
