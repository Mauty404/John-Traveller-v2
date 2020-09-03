using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    { 
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 temp;
        temp.x = target.position.x;
        temp.y = target.position.y;
        temp.z = -10;

        transform.position = temp;
    }
}
    