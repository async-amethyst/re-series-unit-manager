using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
     public byte Initiative {get; set;}
     public ushort HP {get; set;} //ushort = Unsigned Short, makes it so that it can go up to 65535 but not go into negatives.
     public string Name {get; set;}
     public byte DecayStacks {get; set;}
     private bool HasFlourish {get; set;}
     public byte ChargeCounters {get; set;}
     public bool HuntersMarked {get; set;}
     public bool LunaBleed {get; set;}
     public byte RockWeaponState {get; set;} //In reality, this won't be used on 99% of units merely just Rock. So I make it so that it disregards any value out of range.
     public Condition UnitCondition {get; set;}
     public EnergyState Exhaustion {get; set;}

     public Unit()
     {
        Initiative = 0xFF; //If initiative is over 40, it will be discarded and treated as 0 instead.
        HP = 0xFFFF; //Set HP to the max value by default, obviously this will be changed. No unit should have 65535 health... right Ethan?
        Name = "Unit";
        DecayStacks = 0x0;
        HasFlourish = false;
        ChargeCounters = 0x0;
        HuntersMarked = false;
        LunaBleed = false;
        RockWeaponState = 0xFF;
        UnitCondition = Condition.Healthy; //I would assume that something would be alive and healthy when it is first being registered.
        Exhaustion = EnergyState.Normal; //I would also assume that you would not be exhausted upon creation. If you are, I'm sorry for you.
     }

     public Unit(ushort hpInput, string nameInput) //Only use this constructor when there are values provided over the default.
     {
        HP = hpInput;
        Name = nameInput;
     }
}
