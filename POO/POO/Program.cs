
using POO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
try
{
    Console.WriteLine(new Date(2022, 2, 28));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}