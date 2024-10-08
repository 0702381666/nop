using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class btaptt0810
{
    public static void Main(string[] args)
    {
        List<Ptien> dsPtien = new List<Ptien>();
        Xehoi xehoi1 = new Xehoi("Toyota Corolla", "Xang", 180, 7.5);
        Xehoi xehoi2 = new Xehoi("Mazda CX5", "Xang", 170, 6.8);
        dsPtien.Add(xehoi1);
        dsPtien.Add(xehoi2);
        Xedap xedap1 = new Xedap("Giant esxape 3", "Khong", 25);
        Xedap xedap2 = new Xedap("Thong nhat", "Khong", 25);
        dsPtien.Add(xedap1);
        dsPtien.Add(xedap2);
        foreach( var ptien in dsPtien)
        {
            Console.WriteLine("======================");
            ptien.Hienthi();
            ptien.Dichuyen();
        }
        Console.WriteLine("===================");
        Console.WriteLine("Hoan thanh quan li phuong tien giao thong.");
    }
}
