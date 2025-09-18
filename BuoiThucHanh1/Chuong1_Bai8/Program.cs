using Bai7;
using System;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        Console.Write(" Nhap so luong tam giac: ");
        n = int.Parse(Console.ReadLine());
        TamGiac[] _arrTamGiac = new TamGiac[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" Nhap thong tin tam giac thu: " + (i + 1).ToString());
            _arrTamGiac[i] = new TamGiac();
            _arrTamGiac[i].input();
        }
        Console.WriteLine(" Danh sach tam giac: ");
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", "Loại tam giác", "Chu vi", "Diện tích");
        for (int i = 0; i < n; i++)
        {
            _arrTamGiac[i].Display();
        }
        Console.ReadLine();
    }
}
