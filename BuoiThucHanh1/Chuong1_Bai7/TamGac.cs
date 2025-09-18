using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Bai7
{
    internal class TamGiac
    {
        private int Canh1;
        private int Canh2;
        private int Canh3;
        private string Loaitamgiac;
        private int Chuvi;
        private float Dientich;
        public int CANH1
        {
            get { return Canh1; }
            set { Canh1 = value; }
        }
        public int CANH2
        {
            get { return Canh2; }
            set { Canh2 = value; }
        }
        public int CANH3
        {
            get { return Canh3; }
            set { Canh3 = value; }
        }
        public string LoaiTamGiac
        {
            get { return Loaitamgiac; }
            set { Loaitamgiac = value; }
        }
        public int ChuVi
        {
            get { return Chuvi; }
            set { Chuvi = value; }
        }
        public float DienTich
        {
            get { return DienTich; }
            set { DienTich = value; }
        }
        public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = 5;
        }
        public TamGiac(int a,int b,int c)
        {
            CANH1 = a;
            CANH2=  b;
            Canh3 = c;
        }
        public int TinhChuVi()
        {
            ChuVi=CANH1+CANH2 + CANH3;
            return ChuVi;
        }
        public float TinhDienTich()
        {
            float p = ChuVi / 2;
            DienTich=Convert.ToSingle(Math.Sqrt(p*(p-CANH1)*(p-CANH2)*(p-CANH3)));
            return DienTich;
        }
        public void input()
        {
            Console.Write(" \t -Nhap canh thu 1:");
            CANH1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap canh thu 2:");
            CANH2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap canh thu 3:");
            CANH3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap loai tam giac:");
            LoaiTamGiac = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", LoaiTamGiac, ChuVi, DienTich);
        }
    }
}

