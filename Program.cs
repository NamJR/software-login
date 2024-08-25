using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    internal class Program
    {
        static void Main(string[] args)
        {
          giaovien gv = new giaovien();
          baove bv = new baove();
            gv.nhap();
            Console.WriteLine(gv.getten() + "\n"+gv.gettuoi()+"\n"+gv.getcannang()+"\n"+gv.getquequan());
            Console.WriteLine(gv.tinhluong());
            bv.nhap();
            Console.WriteLine(bv.getten() + "\n" + bv.gettuoi() + "\n" + bv.getcannang() + "\n" + bv.getquequan());
            Console.WriteLine(bv.Tinhluong());
            Console.ReadKey();
        }
    }
}
