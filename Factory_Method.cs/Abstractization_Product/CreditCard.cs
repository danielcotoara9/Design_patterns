namespace Factory_Method.Abstractization_Product
{
    /// <summary>  
    /// The 'Product' Abstract Class  
    /// </summary>  
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}
