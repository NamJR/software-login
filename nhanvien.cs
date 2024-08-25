using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    public class nhanvien
    {
        private string hoten;
        private string quequan;
        private int tuoi;
        private int cannang;

        public void nhap()
        {
            Console.Write("ho ten: ");
            hoten = Console.ReadLine();
            Console.WriteLine();
            Console.Write("que quan: ");
            quequan = Console.ReadLine();
            Console.WriteLine();
            Console.Write("tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("can nang: ");
            cannang = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }
        public string getten() { return hoten; }
        public string getquequan() { return quequan; } 
        public int gettuoi() { return tuoi; }
        public int getcannang() { return cannang; } 
        
            
        public double tinhluong()
        {
            return Math.Pow(11, 6);
        }
    }
    
}
