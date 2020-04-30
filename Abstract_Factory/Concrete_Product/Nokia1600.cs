using System;
using Abstract_Factory.Abstractization_Product;

namespace Abstract_Factory.Concrete_Product
{
    /// <summary>  
    /// The 'ProductB1' class  
    /// </summary>  
    public class Nokia1600 : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
