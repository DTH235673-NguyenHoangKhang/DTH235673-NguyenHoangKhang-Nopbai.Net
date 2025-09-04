using Bai6;
using System;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        Console.Write(" Nhap so luong nhan vien: ");
        n = int.Parse(Console.ReadLine());
        Employee[] _arrEmployee = new Employee[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" Nhap thong tin nhan vien thu: " + (i + 1).ToString());
            _arrEmployee[i] = new Employee();
            _arrEmployee[i].input();
        }
        Console.WriteLine(" Danh sach nhan vien: ");
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", "Định danh", "Họ và tên", "Năm sinh", "Lương cơ bản","Thu nhập");
        for (int i = 0; i < n; i++)
        {
            _arrEmployee[i].Display();
        }
        Console.ReadLine();
    }
}
