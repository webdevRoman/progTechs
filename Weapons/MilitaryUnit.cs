
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

public class MilitaryUnit
{
    private ArrayList _equipment;
    
    public MilitaryUnit(ArrayList weapons)
    {
        this._equipment = weapons;
    }

    public ArrayList GetEquipment()
    {
        return _equipment;
    }
    public void SetEquipment(ArrayList weapons)
    {
        _equipment = weapons;
    }

    public void Equip(Weapon weapon)
    {
        _equipment.Add(weapon);
    }
    public void Unequip(Weapon weapon)
    {
        _equipment.Remove(weapon);
    }

    public int CalculateEquipmentCost()
    {
        int cost = 0;
        foreach (Weapon weapon in _equipment)
            cost += weapon.GetCost();
        return cost;
    }
}