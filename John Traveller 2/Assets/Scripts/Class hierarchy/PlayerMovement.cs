using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : Character
{
    public float moveSpeed = 5f;

    Rigidbody2D rb;
    Animator _animator;

    private Vector2 movement;
    Vector3 currentPosition;
    Vector3 previousPosition;
    protected internal int lastKeyMove;

    enum enumLastKeyMove
    {
        up = 1,
        down = 2
    }


    private void Awake()
    {
        //id++;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }


    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (IsMove())
            _animator.SetFloat("Speed", 1f);
        else
            _animator.SetFloat("Speed", 0f);

        if (IsAttack())
            _animator.SetTrigger("Attack");



        Dead();
        Rotate();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 
    }

   bool IsMove()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.W))
                lastKeyMove = (int)enumLastKeyMove.up;
            else if (Input.GetKey(KeyCode.S))
                lastKeyMove = (int)enumLastKeyMove.down;


            return true;
        }
            
        else
            return false;
    }

    bool IsAttack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }

    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.A))
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        if (Input.GetKeyDown(KeyCode.D))
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
    

}
