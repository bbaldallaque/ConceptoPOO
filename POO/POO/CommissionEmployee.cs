namespace POO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        //Este es el ToString() de la clase padre (Employee)
        public override string ToString()
        {
            //El \n es un salto de linea
            //El \t es un tabulador 
            //Con doble interpolación
            return $"{base.ToString()}" +
                $"\n\tCommission Perscentaje:  {$"{CommissionPercentaje:P2}", 18}" +
                $"\n\tSales.................:  {$"{Sales:C2}", 18}" +
                $"\n\tvalue to pay..........:  {$"{GetValueToPay():C2}", 18}";
            // sin doble interpolación
            // $"\n\tvalue to pay.........: {GetValueToPay():C2}";
        }
    }
}
