using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public static int id;

    //Attributes
    [SerializeField]
    internal protected float speed = 3.5f;

    //
    public float hp = 100;
    public float hpMax = 100;
    public float damage = 1;
    public float[] position;

    public PlayerData(PlayerMovement player)
    {
        speed = player.speed;
        hp = player.hp;
        hpMax = player.hpMax;
        damage = player.damage;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
    
}
