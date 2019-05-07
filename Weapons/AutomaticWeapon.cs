
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AutomaticWeapon : Firearm
{

    public AutomaticWeapon()
    {
    }
    public AutomaticWeapon(string name, int damageProof, int initialCost, int destrucyionRange, int magazineCapacity, int rapidity)
        : base(name, damageProof, initialCost, destrucyionRange, magazineCapacity)
    {
        this._rapidity = rapidity;
        this.cost = CalculateWeaponCost();
    }

    private int _rapidity;

    public int GetRapidity()
    {
        return _rapidity;
    }
    public void SetRapidity(int value)
    {
        _rapidity = value;
    }

    public new int CalculateWeaponCost()
    {
        int cost = (int)(this.initialCost + 800 * (this.damageProof - 100) / this.damageProof + this.destructionRange * 0.5 + this.magazineCapacity * 20 + this._rapidity * 25);
        return cost;
    }

}