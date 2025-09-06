using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Bai8
{
    internal class TamGiac
    {
        private int Soa;
        private int Sob;
        private int Soc;

        public int SoA
        {
            get { return Soa; }
            set { Soa = value; }
        }
        public int SoB
        {
            get { return Sob; }
            set { Sob = value; }
        }
        public int SoC
        {
            get { return SoC; }
            set { SoC = value; }
        }
        public void input()
        {
            Console.Write(" \t -Nhap so thu 1:");
            SoA = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap so thu 2:");
            SoB = Convert.ToInt32(Console.ReadLine());
            Console.Write(" \t -Nhap so thu 3:");
            SoC = Convert.ToInt32(Console.ReadLine());

        }
        public void TinhNghiem()
        {
            float x1, x2;
            float delta = SoB * SoB - 4 * SoA * SoC;
            float CanDelta = Convert.ToSingle(Math.Sqrt(delta));
            if (CanDelta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            if (CanDelta == 0)
            {
                
                    x1 = -(float)SoB / 2 * SoA;
                    x2 = x1;
             }
             if (CanDelta > 0)
             {

                  x1 = (float)(-SoB + CanDelta) / 2 * SoA;
                  x2 = (float)(-SoB - CanDelta) / 2 * SoA;
             }

            
        Console.WriteLine("Phương trình có nghiệm x1=(0),x2=(1)", x1,x2);
        }
}

    }




