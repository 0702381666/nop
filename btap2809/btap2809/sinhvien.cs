using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
class Sinhvien
{
    public string hoten { get; set; }
    public string masv { get; set; }
    public double diemtb { get; set; }
    public void Nhapthongtin()
    {
        Console.Write("Nhap ho ten sinh vien: ");
        hoten = Console.ReadLine();
        Console.Write("Nhap ma sinh vien: ");
        masv = Console.ReadLine();
        Console.Write("Nhap diem trung binh: ");
        diemtb = double.Parse(Console.ReadLine());
    }
    public void Hienthithongtin()
    {
        Console.WriteLine("Ho ten: " + hoten);
        Console.WriteLine("Ma sinh vien: " + masv);
        Console.WriteLine("Diem trung binh: " + diemtb);
    }
}
