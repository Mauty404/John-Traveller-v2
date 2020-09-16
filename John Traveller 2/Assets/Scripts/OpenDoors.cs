using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;
using TMPro;

public class OpenDoors : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;
    
    public Transform Player;
    private Animator animator;
    private double distance = 2.53;

    public GameObject canvas;

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
        canvas = GameObject.Find("Tip");
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
}
