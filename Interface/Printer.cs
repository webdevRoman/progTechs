using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Printer {

    public void PrintMilitaryUnit(MilitaryUnit militaryUnit)
    {
        string weapons = "Подразделение вооружено следующими видами оружия: ";
        foreach (Weapon weapon in militaryUnit.GetEquipment())
        {
            weapons += weapon.GetName() + ", ";
        }
        weapons = weapons.Remove(weapons.Length - 2);
        Console.WriteLine(weapons + "\nХарактеристики оружия:");
        foreach (Weapon weapon in militaryUnit.GetEquipment())
        {
            Console.WriteLine("Название: " + weapon.GetName() + "; надежность: " + weapon.GetDamageProof() + "; цена: " + weapon.GetCost());
        }
    }
}
