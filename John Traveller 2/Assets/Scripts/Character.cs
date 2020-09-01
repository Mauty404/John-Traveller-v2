using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    //Core
    private String name = "";
    private int level = 0;
    private int attributePoints = 3;
    private int exp = 0;
    private int expMax = 100;
    
    //Attributes
    private int strength = 1;
    private int vitality = 1;
    private int dexterity = 1;
    private int agility = 1;
    private int intelligence = 1;
    
    //
    private int hp = 0;
    private int hpMax = 0;
    private int damage = 0; 
    private int damageMax = 0;
    private int accuracy = 0;
    private int defence = 0;
    
    //General
    private int gold = 100;

    private void CalculateStats()
    {
        this.hp = this.vitality * 10;
        this.damageMax = this.strength * 2;
        this.damage = this.strength;
        this.accuracy = this.dexterity * 2;
        this.defence = this.agility * 2;
    }

    private void CalculateExp()
    {
        this.expMax = this.level * 100; 
    }

    public override string ToString()
    {
        return this.name = name;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
