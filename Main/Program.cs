using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
    static void main(string[] args)
    {
        Weapon ak74 = new Weapon();
        ak74.SetName("АК-74");
        ak74.SetDamageProof(5);
        ak74.SetCost(15000);

        Printer printer = new Printer();
        printer.PrintWeapon(ak74);
    }
}