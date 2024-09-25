using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList();
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap cac so nguyen: ");
        for(int i = 0; i <n; i++)
        {
            Console.Write("So thu " + (i + 1) + " : ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        numbers.Sort();
        Console.WriteLine("Danh sach cac so nguyen theo thu tu tang dan la: ");
        foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
