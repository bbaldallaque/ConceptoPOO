namespace Taller1
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity + (decimal)Quantity * Price * (decimal)Tax ;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement : kilo" +
                $"\n\tQuantity......................: {$"{Quantity:N2}",18}" +
                $"\n\tPrice.........................: {$"{Price:C2}",18}" +
                $"\n\tTax...........................: {$"{Tax:P2}",18}" +
                $"\n\tValue To Pay..................: {$"{ValueToPay():C2}",18}";
        }
    }
}
