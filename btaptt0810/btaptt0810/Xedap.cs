using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Xedap : Ptien, Ithongtinthem
{
    public double Tocdomax1 { get; set; }
    public Xedap(string ten, string loai, double Tocdomax) : base(ten, loai)
    {
        Tocdomax1 = Tocdomax;
    }
    public override void Dichuyen()
    {
        Console.WriteLine($"{Tenpt} dang di chuyen bang suc nguoi.");
    }
    public void Tocdomax()
    {
        Console.WriteLine($"Toc do toi da: {Tocdomax1} km/h");
    }
    public void Muctieuthunhienlieu()
    {
        Console.WriteLine("Khong su dung nhien lieu.");
    }
    public override void Hienthi()
    {
        base.Hienthi();
        Tocdomax();
        Muctieuthunhienlieu();
    }
}

