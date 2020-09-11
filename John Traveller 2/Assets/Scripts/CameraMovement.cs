using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform target;
    float offsetX, offsetY;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        offsetX = 3.66f;
        offsetY = 2f;
    }


    void Update()
    {
        Vector3 temp;
        target = GameObject.FindGameObjectWithTag("Player").transform;
        if (target.transform.position.x > transform.position.x + offsetX)
        {
            
            temp.x = target.position.x - offsetX;
            temp.y = transform.position.y;
            temp.z = -10;
            transform.position = temp;
        }

        if(target.transform.position.y > transform.position.y + offsetY)
        {
            temp.x = transform.position.x;
            temp.y = target.position.y - offsetY;
            temp.z = -10;
            transform.position = temp;
        }

        if (target.transform.position.x < transform.position.x - offsetX)
        {

            temp.x = target.position.x + offsetX;
            temp.y = transform.position.y;
            temp.z = -10;
            transform.position = temp;
        }

        if (target.transform.position.y < transform.position.y - offsetY)
        {
            temp.x = transform.position.x;
            temp.y = target.position.y + offsetY;
            temp.z = -10;
            transform.position = temp;
        }
    }
}
    