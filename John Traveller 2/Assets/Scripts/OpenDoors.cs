using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{

    private Animator animator;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            OpenDoor();
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
