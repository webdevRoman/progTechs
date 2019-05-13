
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BladedWeapon : Weapon
{
    private int _brandClass;
    private int _bladeLength;

    public BladedWeapon(string name, int damageProof, int initialCost, int brandClass, int bladeLength)
        : base(name, damageProof, initialCost)
    {
        this._brandClass = brandClass;
        this._bladeLength = bladeLength;
        this.cost = CalculateWeaponCost();
        this.CheckCost();
    }

    public int GetBrandClass()
    {
        return _brandClass;
    }
    public void SetBrandClass(int value)
    {
        _brandClass = value;
    }

    public int GetBladeLength()
    {
        return _bladeLength;
    }
    public void SetBladeLength(int value)
    {
        _bladeLength = value;
    }

    public new int CalculateWeaponCost()
    {
        int cost = (int)(this.initialCost + 400 * (this.damageProof - 100) / this.damageProof + this._brandClass * 100 + this._bladeLength * 50);
        return cost;
    }

}