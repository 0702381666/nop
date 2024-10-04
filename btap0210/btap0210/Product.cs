using System;

abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public abstract void DisplayProductInfo();
    public abstract void ApplyDiscount(decimal percentage);
}