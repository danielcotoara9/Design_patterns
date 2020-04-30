using Factory_Method.Abstractization_Product;

namespace Factory_Method.Creator
{
    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
