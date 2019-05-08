using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Creator
{
    public MilitaryUnit CreateFirstMilitaryUnit()
    {
        AutomaticWeapon ak74 = new AutomaticWeapon("АК-74", 90, 30000, 1350, 30, 150);
        Firearm pm = new Firearm("ПМ", 75, 13000, 350, 8);
        BladedWeapon knife = new BladedWeapon("Штык-нож", 100, 5000, 3, 20);
        Weapon granade = new Weapon("РГД-5", 80, 3000);

        ArrayList equipment = new ArrayList();
        equipment.Add(ak74);
        equipment.Add(pm);
        equipment.Add(knife);
        equipment.Add(granade);
        MilitaryUnit division = new MilitaryUnit(equipment);

        return division;
    }
}
