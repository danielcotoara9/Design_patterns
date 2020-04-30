using System;
using Abstract_Factory.Abstractization_Product;

namespace Abstract_Factory.Concrete_Product
{
    /// <summary>  
    /// The 'ProductA2' class  
    /// </summary>  
    public class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
