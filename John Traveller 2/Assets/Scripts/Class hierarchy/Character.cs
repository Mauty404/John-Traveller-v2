using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    //Core
    public String name = "";
    public int level = 0;
    public int attributePoints = 3;
    public int exp = 0;
    public int expMax = 100;
    public int id = 0;
    public bool isAlive;
    
    //Attributes
    [SerializeField]
    internal protected float speed = 1;
    public float strength = 1;
    public float vitality = 1;
    public float dexterity = 1;
    public float agility = 1;
    public float intelligence = 1;

    //
    public float hp = 0;
    public float hpMax = 0;
    public float damage = 0;
    public float damageMax = 0;
    public float accuracy = 0;
    public float defence = 0;

    //General
    public int gold = 100;

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

    public void TakeDamage(float damage)
    {
        Debug.Log("Hit");
        hp -= damage;

    }

    public void Dead()
    {
        if(hp < 0)
        {
           Destroy(this.gameObject); 
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
