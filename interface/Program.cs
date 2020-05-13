using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2723
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;
            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.WriteLine("Pilih Nomer Printer [1/2/3] : ");

            int NomorPrinter = Convert.ToInt32(Console.ReadLine());
            

            if (NomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (NomorPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
