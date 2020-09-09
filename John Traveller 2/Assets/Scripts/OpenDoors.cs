using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class OpenDoors : MonoBehaviour
{
    public Transform Player;
    private Animator animator;
    private double distance = 2.53;
    public void OpenDoor()
    {
        animator.SetBool("Open", true);
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
        if (Vector2.Distance(transform.position, Player.position) < distance)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                {
                    OpenDoor();
                    GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }

    }
}
