namespace POO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        //Este es el ToString() de la clase padre (Employee)
        public override string ToString()
        {
            //El \n es un salto de linea
            //El \t es un tabulador 
            return $"{base.ToString()}" +
                // la doble interpolación: 2 corchetes uno dentro del otro con el signo de pesos
                $"\n\tvalue to pay.........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
