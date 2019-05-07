using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            MilitaryUnit division = creator.CreateFirstMilitaryUnit();

            Printer printer = new Printer();
            printer.PrintMilitaryUnit(division);

            int price = division.CalculateEquipmentCost();

            Console.WriteLine();
            Console.WriteLine("Цена вооружения военного подразделения: " + price);

            Console.ReadKey();
        }
    }
}
