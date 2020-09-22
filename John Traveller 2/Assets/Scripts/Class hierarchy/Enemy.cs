using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    private Transform player;
    public float stoppingDistance;
    public float distance;
    Character ch;
    private bool playerFound = false;
    public float attackDistance;
    private float lastAttackTime;
    public float attackDelay;
    private PlayerMovement pm;

    private void Awake()
    {
        
        id++;
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        ch = GetComponent<Character>();
        pm = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }


    void Update()
    {
        Movement();
        Dead();
        Attack();
    }


    

    void Movement()
    {
        if (Vector2.Distance(player.position, transform.position) <= distance 
            && Vector2.Distance(player.position, transform.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, ch.speed * Time.deltaTime);
        }
    }

    void Attack()
    {
        if(Vector2.Distance(player.position, transform.position) < attackDistance)
            if (Time.time > lastAttackTime + attackDelay)
            { 
                pm.hp = TakeDamage(pm.hp, damage);
                lastAttackTime = Time.time;
            }
    }

}
