using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    private PlayerMovement pm;
    public int hpbonus;
    private Collider2D player;
    private Collider2D item;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Collider2D>();
        item = GetComponent<Collider2D>();
        pm = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    public void AddHP()
    {
        pm.hp = pm.hp + hpbonus;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (player == collider && pm.hp < pm.hpMax)
        {
            Debug.Log("Heal");
            AddHP();
            Destroy(this.gameObject);
        }
        
    }
}
