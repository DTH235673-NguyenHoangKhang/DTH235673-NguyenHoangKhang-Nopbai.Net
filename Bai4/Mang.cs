using System;
using System.Runtime.InteropServices;

namespace Bai4
{
    class MangSoNguyen
    {
        //phuong thuc nhap mot so > 0
        public int NhapSoDuong()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so <= 0);
            return so;
        }
        //phuong thuc nhap mot so
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        //phuong thuc nhap mang
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //phuong thuc in mang
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0}", a[i]);
        }
        public int TimSoLonNhat(int[] a)
        {
            int max = 0;
            for(int i=0;i< a.Length; i++)
            {
                if (a[i]>max)
                    max = a[i];
            }   
            return max;
        }
        public int TimSoNhoNhat(int[] a)
        {
            int min =a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
        public int TinhTong(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        public void SapXepTangDan(int[] a)
        {
            int tam = 0;
            for (int i=0;i<a.Length-1;i++)
                for(int j=i+1;j<a.Length;j++)
                    if (a[i] > a[j])
                    {
                        tam=a[i];
                        a[i]=a[j];
                        a[j]=tam;
                    }   
        }

    }
}