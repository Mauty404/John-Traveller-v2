﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenDoors : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;
    
    public Transform Player;
    private Animator animator;

    //public GameObject canvas;

    public Key.KeyType GetKeyType()
    {
        return keyType;
    }
    public void OpenDoor()
    {
        animator.SetBool("Open", true);
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<CapsuleCollider2D>().enabled = false;

    }
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
