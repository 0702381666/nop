﻿class Accessory : Product, ISellable
{
    public string Type { get; set; }

    public override void DisplayProductInfo()
    {
        Console.WriteLine($"Accessory: {Type}");
        Console.WriteLine($"Price: {Price:C}, Stock: {Stock}");
    }
    public override void ApplyDiscount(decimal percentage)
    {
        Price -= Price * (percentage / 100);
        Console.WriteLine($"New price after {percentage}% discount: {Price:C}");
    }
    public void Sell(int quantity)
    {
        if (Stock >= quantity)
        {
            Stock -= quantity;
            Console.WriteLine($"{quantity} units of {Name} sold.");
        }
        else
        {
            Console.WriteLine("Not enough stock.");
        }
    }
    public bool IsInStock()
    {
        return Stock > 0;
    }
}