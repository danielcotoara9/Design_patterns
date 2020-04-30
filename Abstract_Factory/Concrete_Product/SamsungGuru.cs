using Abstract_Factory.Abstractization_Product;

namespace Abstract_Factory.Concrete_Product
{
    /// <summary>  
    /// The 'ProductB2' class  
    /// </summary>  
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
