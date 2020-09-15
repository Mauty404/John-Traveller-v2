using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;
using TMPro;

public class OpenDoors : MonoBehaviour
{
    public Transform Player;
    private Animator animator;
    private double distance = 2.53;

    public GameObject canvas;
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
        canvas = GameObject.Find("Tip");
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.position) < distance)
        {
            if (GetComponent<BoxCollider2D>().enabled == true)
                canvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                {
                    OpenDoor();
                    GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }
        else
            canvas.SetActive(false);

    }
}
