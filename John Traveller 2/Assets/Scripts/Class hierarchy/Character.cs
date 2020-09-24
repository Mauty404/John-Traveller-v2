using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    //Core
    public new String name;
    public static int id;

    //Attributes
    [SerializeField]
    internal protected float speed = 3.5f;

    //
    public float hp = 100;
    public float hpMax = 100;
    public float damage = 1;

    

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
