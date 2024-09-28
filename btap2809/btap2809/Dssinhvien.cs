using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dssinhvien
{
    private List<Sinhvien> danhsach;
    public Dssinhvien()
    {
        danhsach = new List<Sinhvien>();
    }
    public void Themsv()
    {
        Sinhvien sv = new Sinhvien();
        sv.Nhapthongtin();
        danhsach.Add(sv);
        Console.WriteLine("Da them sinh vien vao sanh sach.\n");
    }
    public void Hienthids()
    {
        Console.WriteLine("Danh sach sinh vien: ");
        foreach(Sinhvien sv in danhsach)
        {
            sv.Hienthithongtin();
        }
    }
    public void Timsinhvien(string mssv)
    {
        bool Timthay = false;
        foreach (Sinhvien sv in danhsach)
        {
            if(sv.masv == mssv)
            {
                Console.WriteLine("Da tim thay sinh vien voi ma sinh vien: " + mssv);
                Timthay = true;
                break;
            }
        }
        if (!Timthay)
        {
            Console.WriteLine("Khong tim thay sinh vien voi ma sinh vien: " + mssv);
        }
    }
    public Sinhvien Timdiemtrungbinhmax()
    {
        if(danhsach.Count == 0)
        {
            return null;
        }
        Sinhvien svmax = danhsach[0];
        foreach(Sinhvien sv in danhsach)
        {
            if(sv.diemtb > svmax.diemtb)
            {
                svmax = sv;
            }
        }
        return svmax;
    }
}
