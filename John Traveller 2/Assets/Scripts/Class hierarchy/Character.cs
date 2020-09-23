using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    //Core
    public new String name;
    public int level = 0;
    public int attributePoints = 0;
    public int exp = 0;
    public int expMax = 0;
    public static int id;
    public bool isAlive;

    //Attributes
    [SerializeField]
    internal protected float speed = 3.5f;
    public float strength = 0;
    public float vitality = 0;
    public float dexterity = 0;
    public float agility = 0;
    public float intelligence = 0;

    //
    public float hp = 100;
    public float hpMax = 100;
    public float damage = 1;
    public float damageMax = 0;
    public float accuracy = 0;
    public float defence = 0;


    //General
    public int gold = 0;

    private void CalculateStats()
    {
        this.hp = this.vitality * 10;
        this.damageMax = this.strength * 2;
        this.damage = this.strength + this.accuracy;
        this.accuracy = this.dexterity * (3 / 5);
        this.defence = this.agility * 2;
    }

    private void CalculateExp()
    {
        this.expMax = this.level * 100;
        if(this.exp == this.expMax)
        {
            this.level++;
            this.attributePoints += 3;
        }
            
    }

    public override string ToString()
    {
        return this.name = name;
    }

    public float TakeDamage(float hp, float damage)
    {
        this.hp -= damage;
        return this.hp;
    }

    public void Dead()
    {
        if(hp <= 0)
        {
           Destroy(this.gameObject); 
        }
    }
   
}
