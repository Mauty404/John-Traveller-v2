using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform target;
    [SerializeField]
    float chaseRadius;
    public float attackRadius;
    float moveSpeed;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        moveSpeed = 5;
    }

    
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            RotateTowards();
        }
    }

    void RotateTowards()
    { 
        Vector3 direction;
        direction = target.position - transform.position;
        direction = direction.normalized;
        if (direction.x < 0)
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        else if (direction.x > 0)
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        else if (direction.x == 0)
            transform.eulerAngles = transform.eulerAngles;
    }
}
