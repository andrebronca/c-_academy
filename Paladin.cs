using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Character
{
    public Weapon weapon;


    //chamando o construtor da classe pai, passando parâmetro
    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    //usando poliformismo
    public override void PrintStatsInfo()
    {
        //base.PrintStatsInfo();
        Debug.LogFormat("Hail {0} - take up your {1}!", this.name,this.weapon.name);
    }
}
