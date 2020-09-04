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
    private float moveSpeed;
    private bool playerFound = false;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Character ch = GetComponent<Character>();
        moveSpeed = ch.speed;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    

    void Movement()
    {
        if (Vector2.Distance(player.position, transform.position) <= distance 
            && Vector2.Distance(player.position, transform.position) > stoppingDistance )
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }
    
}
