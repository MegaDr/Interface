using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2723
{
    public interface PrinterWindows
    {
        void Show();
        void Print();
    }
    public class Epson : PrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer printing .......");
        }
    }

    public class Canon : PrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension : 9,5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer printing .......");
        }
    }
    
    public class LaserJet : PrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
        public void Print()
        {
            Console.WriteLine("LaserJet printer printing .......");
        }
    }
}
