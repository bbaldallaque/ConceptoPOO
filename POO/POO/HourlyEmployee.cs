namespace POO
{
    public class HourlyEmployee : Employee
    {
        public float Hours  { get; set; }

        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            //castiamos para que no de error
            return (decimal)Hours * HourValue;
        }

        //Este es el ToString() de la clase padre (Employee)
        public override string ToString()
        {
            //El \n es un salto de linea
            //El \t es un tabulador 
            //Con doble interpolación
            return $"{base.ToString()}" +
                $"\n\tHours.................:  {$"{Hours:N2}", 18}" +
                $"\n\tHour Value............:  {$"{HourValue:C2}", 18}" +
                $"\n\tvalue to pay..........:  {$"{GetValueToPay():C2}", 18}";
            // sin doble interpolación
            // $"\n\tvalue to pay.........: {GetValueToPay():C2}";
        }
    }
}
