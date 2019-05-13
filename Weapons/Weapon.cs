
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Weapon
{
    private string _name;
    protected int damageProof;
    protected int initialCost;
    protected int cost;

    public Weapon(string name, int damageProof, int initialCost)
    {
        this._name = name;
        this.damageProof = damageProof;
        this.initialCost = initialCost;
        this.cost = CalculateWeaponCost();
        this.CheckCost();
    }

    protected void CheckCost()
    {
        if (this.cost < 0)
            this.cost = 0;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string value)
    {
        _name = value;
    }

    public int GetDamageProof()
    {
        return damageProof;
    }
    public void SetDamageProof(int value)
    {
        damageProof = value;
    }

    public int GetInitialCost()
    {
        return initialCost;
    }
    public void SetInitialCost(int value)
    {
        initialCost = value;
    }

    public int GetCost()
    {
        return cost;
    }

    public int CalculateWeaponCost()
    {
        int cost = (int)(this.initialCost + 600 * (this.damageProof - 100) / this.damageProof);
        return cost;
    }

}