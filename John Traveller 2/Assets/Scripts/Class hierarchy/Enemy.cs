using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    // PSEUDO-GLOBAL VARIABLES
    public float speed = 3.5f;
    public float distance = 4f;
    public float stoppingDistance = 0.5f;
    public float attackDistance = 1.3f;
    public float attackDelay = 0.45f;

    // ************************


    private Transform player;
    private float lastAttackTime;
    private PlayerMovement pm;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
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
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

            Vector3 position;
            Vector3 john;
            Vector3 direction;
            john = GameObject.FindGameObjectWithTag("Player").transform.position;
            position = transform.position;
            direction = john - position;
            direction = direction.normalized;
            if (direction.x < 0)
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            if (direction.x > 0)
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            else
                transform.eulerAngles = transform.eulerAngles;
        }
    }

    void Attack()
    {
        if(Vector2.Distance(player.position, transform.position) < attackDistance)
            if (Time.time > lastAttackTime + attackDelay)
            { 
                pm.TakeDamage(pm.hp, damage);
                lastAttackTime = Time.time;
            }
    }

}
