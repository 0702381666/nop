using System;
using System.Collections.Generic;

// Lớp cha Product
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, string description, int quantity)
    {
        Name = name;
        Price = price;
        Description = description;
        Quantity = quantity;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ten san pham: {Name}, Gia: {Price} VND, Mo ta: {Description}, So luong: {Quantity}");
    }
}

// Lớp con Electronic kế thừa từ Product
class Electronic : Product
{
    public int Warranty { get; set; }

    public Electronic(string name, double price, string description, int quantity, int warranty)
        : base(name, price, description, quantity)
    {
        Warranty = warranty;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Bao hanh: {Warranty} thang");
    }
}

// Lớp con Clothing kế thừa từ Product
class Clothing : Product
{
    public string Size { get; set; }
    public string Color { get; set; }

    public Clothing(string name, double price, string description, int quantity, string size, string color)
        : base(name, price, description, quantity)
    {
        Size = size;
        Color = color;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Kich thuoc: {Size}, Mau sac: {Color}");
    }
}

// Lớp con Food kế thừa từ Product
class Food : Product
{
    public string ExpirationDate { get; set; }

    public Food(string name, double price, string description, int quantity, string expirationDate)
        : base(name, price, description, quantity)
    {
        ExpirationDate = expirationDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Ngay het han: {ExpirationDate}");
    }
}

// Lớp giỏ hàng ShoppingCart
class ShoppingCart
{
    private List<Product> products;

    public ShoppingCart()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"Đa them {product.Name} vao gio hang.");
    }

    public void RemoveProduct(string productName)
    {
        Product productToRemove = products.Find(p => p.Name == productName);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine($"Da xoa {productName} khoi gio hang.");
        }
        else
        {
            Console.WriteLine($"San pham {productName} khong ton tai trong gio hang.");
        }
    }

    public void DisplayCart()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Gio hang trong.");
        }
        else
        {
            Console.WriteLine("Cac san pham trong gio hang:");
            foreach (var product in products)
            {
                product.DisplayInfo();
            }
        }
    }

    public void CalculateTotal()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.Price * product.Quantity;
        }
        Console.WriteLine($"Tong gia tri don hang: {total} VND");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo một số sản phẩm mẫu
        Electronic laptop = new Electronic("Laptop", 15000000, "Laptop gaming", 1, 24);
        Clothing tshirt = new Clothing("Ao Polo", 200000, "Vai thun lanh", 2, "L", "Xanh,Trang");
        Food apple = new Food("Tao", 25000, "Tao my nhap khau", 10, "17-11-2024");

        // Khởi tạo giỏ hàng
        ShoppingCart cart = new ShoppingCart();

        // Thêm sản phẩm vào giỏ hàng
        cart.AddProduct(laptop);
        cart.AddProduct(tshirt);
        cart.AddProduct(apple);

        // Hiển thị giỏ hàng
        cart.DisplayCart();

        // Tính tổng giá trị đơn hàng
        cart.CalculateTotal();
    }
}

