namespace Taller1
{
    public class Invoice : IPay
    {
        private readonly Product _product;

        public Invoice(Product product)
        {
            _product = product;
        }

        private override string AddProduct()
        {
            throw new NotImplementedException();
        }

        public decimal ValueToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
