namespace POO
{
    public abstract class Employee : IPay
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirhtDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        //Metodo Abstracto
        //Los metodos abstracto solo se plantean, no se lealizan, por que aun no sabemos
        //que clase de empleado es
        public abstract decimal GetValueToPay();

        //sobre escribir el ToString para poder imprimir por pantalla
        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birth:{BirhtDate}, " +
                $"Hiring:{HiringDate}, " +
                $"Is Active: {IsActive}";
        }
    }
}
