using Taller1;

Console.WriteLine("PRODUCTS");
Console.WriteLine("-------------------------------------------------");

Product product1 = new FixedPriceProduct()
{
    Id = 1010,
    Descripcion = "Vino gato negro",
    Price = 46000M,
    Tax = 0.19F
};



Product product2 = new FixedPriceProduct()
{
    Id = 2020,
    Descripcion = "Pan bimbo artesanal",
    Price = 1560M,
    Tax = 0.19F
};


Product product3 = new VariablePriceProduct()
{
    Id = 3030,
    Descripcion = "Queso Holandes",
    Measurement = "Kilo",   
    Price = 32000M,
    Quantity = 0.536F,
    Tax = 0.19F
};



Product product4 = new VariablePriceProduct()
{
    Id = 4040,
    Descripcion = "Cabano",
    Measurement = "Kilo",
    Price = 18000M,
    Quantity = 0.389F,
    Tax = 0.19F
};



Product product5 = new ComposeProduct()
{
    Id = 5050,
    Descripcion = "Ancheta #1",
    Discount =  0.12F,
    Products = new List<Product>() { product1, product2, product3, product4 }
};

Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);
Console.WriteLine(product4);
Console.WriteLine(product5);