using System;
using System.Collections;
class Program
{
    static void Main()
    {
        Hashtable people = new Hashtable();
        Console.Write("Nhap so luong nguoi: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) 
        {
            Console.Write("Nhap ten cua nguoi thu " + (i + 1) + ": ");
            string name = Console.ReadLine();
            Console.Write("Nhap tuoi cua " + name + ": ");
            int age = int.Parse(Console.ReadLine());
            people[name] = age;
        }
        Console.WriteLine("\nDanh sach ten va tuoi da nhap: ");
        foreach (DictionaryEntry entry in people)
        {
            Console.WriteLine("Ten: " + entry.Key + ", Tuoi: " + entry.Value);
        }
    }
}
