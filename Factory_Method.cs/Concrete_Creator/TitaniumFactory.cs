using System;
using Factory_Method.Abstractization_Product;
using Factory_Method.Concrete_Product;
using Factory_Method.Creator;

namespace Factory_Method.Concrete_Creator
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary> 
    public class TitaniumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
