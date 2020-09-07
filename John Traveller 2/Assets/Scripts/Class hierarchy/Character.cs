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
    private int id = 0;
    private bool isAlive;
    
    //Attributes
    [SerializeField]
    internal protected float speed = 1;
    private float strength = 1;
    private float vitality = 1;
    private float dexterity = 1;
    private float agility = 1;
    private float intelligence = 1;
    
    //
    private float hp = 0;
    private float hpMax = 0;
    private float damage = 0; 
    private float damageMax = 0;
    private float accuracy = 0;
    private float defence = 0;
    
    //General
    private int gold = 100;

    private void CalculateStats()
    {
        this.hp = this.vitality * 10;
        this.damageMax = this.strength * 2;
        this.damage = this.strength + this.accuracy;
        this.accuracy = this.dexterity * (3/5);
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

    public void TakeDamage()
    {
        this.hp -= this.damage/this.defence;
        if (this.hp <= 0)
        {
            Debug.Log("You Died");
            this.exp += 15;
        }
            
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
