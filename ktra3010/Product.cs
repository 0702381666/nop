using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    public class Product
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string image, string name, decimal price, int quantity)
        {
            Image = image;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
