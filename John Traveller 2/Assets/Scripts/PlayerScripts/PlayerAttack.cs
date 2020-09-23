using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    private Enemy e;
    private Character ch;
    private PlayerMovement pm;
    public Animator anim;
    


    private void Start()
    {
        e = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
        pm = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
            
        {
            anim.SetTrigger("Attack");
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
            foreach (var enemy in enemiesToDamage)
            {
                enemy.GetComponent<Enemy>().TakeDamage(e.hp, pm.damage);
            }
        }

        
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    } 
}
