using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    Collider2D player;
    Collider2D item;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (player == other)
        {
            ScoreTextScript.coinAmount += 1;
            Destroy(gameObject);
        }
        
    }
}
