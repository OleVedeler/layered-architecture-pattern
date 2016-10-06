
namespace TheShop.Domain.Core.Values
{
    public class Price
    {
        private decimal _value;


        public Price()
        {

        }


        public Price(decimal startingValue)
        {
            SetValue(startingValue);
        }


        public decimal Value
        {
            get { return _value; }
        }


        public void SetValue(decimal value)
        {
            _value = value;
        }

    }
}
