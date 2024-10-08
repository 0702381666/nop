using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Xehoi : Ptien,Ithongtinthem
{
    public double Tocdomax1 { get; set; }
    public double Muctieuthunhienlieu1 { get; set; }
    public Xehoi(string ten, string loai, double Tocdomax, double Muctieuthu):base(ten,loai)
    {
        Tocdomax1 = Tocdomax;
        Muctieuthunhienlieu1 = Muctieuthu;
    }
    public override void Dichuyen()
    {
        Console.WriteLine($"{Tenpt} dang di chuyen bang dong co.");
    }
    public void Tocdomax()
    {
        Console.WriteLine($"Toc do toi da: {Tocdomax1} km/h");
    }
    public void Muctieuthunhienlieu()
    {
        Console.WriteLine($"Muc tieu thu nhien lieu: {Muctieuthunhienlieu1} lit/100km");
    }
    public override void Hienthi()
    {
        base.Hienthi();
        Tocdomax();
        Muctieuthunhienlieu();
    }
}
