namespace POO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }

        public string Descrption { get; set; }

        public float Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - {Descrption}" +
                $"\n\tQueantity.........{$"{Quantity:N2}",18}" +
                $"\n\tPrice.............{$"{Price:C2}",18}" +
                $"\n\tValue.............{$"{GetValueToPay():C2}",18}";
        }
    }
}
