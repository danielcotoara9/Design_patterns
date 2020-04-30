using Abstract_Factory.Abstractization;
using Abstract_Factory.Abstractization_Product;

namespace Abstract_Factory.Client
{
    /// <summary>  
    /// The 'Client' class  
    /// </summary> 
    public class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;
        public MobileClient(IMobilePhone factory)
        {
            smartPhone = factory.GetSmartPhone();
            normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.GetModelDetails();
        }
    }
}
