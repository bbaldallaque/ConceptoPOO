namespace Taller1
{
    public class ComposeProduct : Product
    {
        public float Discount { get; set; }

        public ICollection<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            return (decimal)Discount;
        }

        public override string ToString()
        {
         return $"{base.ToString()}" +
                $"\n\tDiscount......................: {$"{Discount:P2}",18}" +
                $"\n\tProducts......................: {$"{Products}",18}" +
                $"\n\tValue To Pay..................: {$"{ValueToPay():C2}",18}";
        }
    }
}
