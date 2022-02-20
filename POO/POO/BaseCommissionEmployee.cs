namespace POO
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        //esta sobrecarga es la clase heredada, en este caso CommissionEmpleyee
        public override decimal GetValueToPay()
        {
           return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            //El \n es un salto de linea
            //El \t es un tabulador 
            //Con doble interpolación
            return $"{base.ToString()}" +
                $"\n\tBase..................:  {$"{Base:C2}",18}";
        }
    }
}
