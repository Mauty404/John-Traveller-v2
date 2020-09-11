using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private UI_Inventory uiInventory;
    public float moveSpeed = 5f;

    Rigidbody2D rb;
    Animator _animator;

    private Vector2 movement;
    Vector3 currentPosition;
    Vector3 previousPosition;
    private Inventory inventory;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    // Update is called once per frame
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

        Rotate();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 
    }

   bool IsMove()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            return true;
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
