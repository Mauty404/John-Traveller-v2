using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public float damage;
    private Enemy e;
    private Character ch;
    


    private void Start()
    {
        e = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();

    }

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
            
        {
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
            for (int i = 0; i < enemiesToDamage.Length; i++)
                
            {
                    e.hp = enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(e.hp, damage);
            }
        }

        
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    } 
}
