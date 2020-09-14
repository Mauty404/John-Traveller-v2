using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private UI_Inventory uiInventory;
    private Inventory inventory;
    // Start is called before the first frame update

    private void Start()
    {
        inventory = new Inventory();
        uiInventory = GameObject.FindGameObjectWithTag("UI").GetComponent<UI_Inventory>();
        uiInventory.SetInventory(inventory);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }
}
