class Program
{
    static void Main(string[] args)
    {
        MobilePhone phone = new MobilePhone()
        {
            Name = "iPhone 14",
            Brand = "Apple",
            Model = "Pro Max",
            Price = 1500m,
            Stock = 50
        };
        Laptop laptop = new Laptop()
        {
            Name = "Dell XPS 13",
            Brand = "Dell",
            CPU = "Intel Core i7",
            Price = 1200m,
            Stock = 30
        };
        Accessory accessory = new Accessory()
        {
            Name = "Wireless Mouse",
            Type = "Mouse",
            Price = 25m,
            Stock = 100
        };
        phone.DisplayProductInfo();
        laptop.DisplayProductInfo();
        accessory.DisplayProductInfo();
        Console.WriteLine();
        phone.Sell(5);
        laptop.Sell(10);
        accessory.Sell(20);
        Console.WriteLine();
        Console.WriteLine("Checking stock status:");
        Console.WriteLine($"Phone in stock: {phone.IsInStock()}");
        Console.WriteLine($"Laptop in stock: {laptop.IsInStock()}");
        Console.WriteLine($"Accessory in stock: {accessory.IsInStock()}");
        Console.WriteLine();
        phone.ApplyDiscount(10);
        laptop.ApplyDiscount(15);
        Console.ReadKey();
    }
}
