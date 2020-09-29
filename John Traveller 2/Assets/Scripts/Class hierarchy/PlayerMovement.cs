using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : Character
{
    // PSEUDO-GLOBAL VARIABLES
    public float moveSpeed = 5f;
    private float attackRange = 0.6f;

    // **********************************


    Rigidbody2D rb;
    Animator _animator;
    private Enemy e;
    private Vector2 movement;
    protected internal int lastKeyMove;
    private Transform attackPos;
    public LayerMask whatIsEnemies;

    enum enumLastKeyMove
    {
        up = 1,
        down = 2
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            
        }
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

    void Attack()
    {
        _animator.SetTrigger("Attack");
        if (e == null || attackPos == null)
        {
            e = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
            attackPos = transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Transform>();
        }

        if (e != null)
        {
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies.value);
            foreach (var enemy in enemiesToDamage)
            {
                enemy.GetComponent<Enemy>().TakeDamage(e.hp, damage);
                if (transform.eulerAngles.y > 100f && transform.eulerAngles.y < 210f)
                {
                    Vector3 tmp = new Vector3(enemy.transform.position.x - 1f, enemy.transform.position.y, enemy.transform.position.z);
                    enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, tmp, 6f);
                }
                else if (transform.eulerAngles.y > -50f && transform.eulerAngles.y < 50f)
                {
                    Vector3 tmp = new Vector3(enemy.transform.position.x + 1f, enemy.transform.position.y, enemy.transform.position.z);
                    enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, tmp, 6f);
                }
                
            }
        }
    }

    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.A))
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        if (Input.GetKeyDown(KeyCode.D))
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}
