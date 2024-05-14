using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon
{
    //atributos
    public string name;
    public int damage;

    //construtor
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    //métodos
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", this.name, this.damage);
    }
}