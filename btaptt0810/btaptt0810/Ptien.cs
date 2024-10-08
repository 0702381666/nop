
using System;
using System.Collections.Generic;
public abstract class Ptien
{
    public string Tenpt { get; set; }
    public string Loainhienlieu { get; set; }
    public Ptien( string ten,string loai)
    {
        Tenpt = ten;
        Loainhienlieu = loai;
    }
    public abstract void Dichuyen();
    public virtual void Hienthi()
    {
        Console.WriteLine($"Ten phuong tien: {Tenpt}");
        Console.WriteLine($"Loai nhien lieu: {Loainhienlieu}");
    }
}
