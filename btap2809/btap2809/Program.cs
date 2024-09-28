using System;
class Program
{
    static void Main(string[] args)
    {
        Dssinhvien dssinhvien = new Dssinhvien();
        Console.WriteLine("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap thong tin cho sinh vien: ");
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nSinh vien thu {i + 1}: ");
            dssinhvien.Themsv();
        }
        dssinhvien.Hienthids();
        Sinhvien svmax = dssinhvien.Timdiemtrungbinhmax();
        if(svmax != null)
        {
            Console.WriteLine("Sinh vien co diem trung binh cao nhat la: ");
            svmax.Hienthithongtin();
        }
        else
        {
            Console.WriteLine("Danh sach sinh vien rong!");
        }
        Console.WriteLine("Nhap ma sinh vien de tim sinh vien: ");
        string masvTimkiem = Console.ReadLine();
        dssinhvien.Timsinhvien(masvTimkiem);
        Console.ReadKey();
    }
}
