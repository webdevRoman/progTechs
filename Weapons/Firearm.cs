
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Firearm : Weapon
{

    public Firearm()
    {
    }
    public Firearm(string name, int damageProof, int initialCost, int destructionRange, int magazineCapacity)
        : base(name, damageProof, initialCost)
    {
        this.destructionRange = destructionRange;
        this.magazineCapacity = magazineCapacity;
        this.cost = CalculateWeaponCost();
    }

    protected int destructionRange;
    protected int magazineCapacity;

    public int GetDestructionRange()
    {
        return destructionRange;
    }
    public void SetDestructionRange(int value)
    {
        destructionRange = value;
    }

    public int GetMagazineCapacity()
    {
        return magazineCapacity;
    }
    public void SetMagazineCapacity(int value)
    {
        magazineCapacity = value;
    }

    public new int CalculateWeaponCost()
    {
        int cost = (int)(this.initialCost + 800 * (this.damageProof - 100) / this.damageProof + this.destructionRange * 0.5 + this.magazineCapacity * 20);
        return cost;
    }

}