using POO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirhtDate =  new Date(1990, 5, 23),
    HiringDate  = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};

//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirhtDate = new Date(1998, 5, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Juan",
    LastName = "Perez",
    BirhtDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,   
    HourValue = 12356.56M,
    Hours = 123.5F
};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Ernesto",
    LastName = "Verde",
    BirhtDate = new Date(1987, 5, 23),
    HiringDate = new Date(2020, 2, 15),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F    
};

//Console.WriteLine(employee4);

//primera sintaxis 
//ICollection<Employee> employees = new List<Employee>();
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);

//segunda sintaxis
ICollection<Employee> employees = new List<Employee>()
{
    employee1,
    employee2,
    employee3, 
    employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                                    =================");
Console.WriteLine($"TOTAL                              {$"{payroll:C2}", 15}");

Invoice invoice1 = new Invoice()
{
    Descrption = "Iphone 13",
    Id = 1,
    Price = 53000000M,
    Quantity = 6
};


Invoice invoice2 = new Invoice()
{
    Descrption = "Posta Primiun",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);