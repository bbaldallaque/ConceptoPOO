namespace Taller1
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return (decimal)Tax * Price + Price;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tPrice.........................: {$"{Price:N2}",18}" +
                $"\n\tTax...........................: {$"{Tax:P2}",18}" +
                $"\n\tValue To Pay..................: {$"{ValueToPay():C2}",18}";



        }
    }
}
