using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    private Transform Player;
    private Animator animator;
    private double distance = 2.53;
    GameObject canvas;
    
    public void OpenChest()
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
        canvas = GameObject.Find("UI").transform.GetChild(2).gameObject;
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.position) < distance)
        {
            if (animator.GetBool("Open") == false)
                canvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                {
                    OpenChest();
                }
            }
        }
        else
            canvas.SetActive(false);

    }
}
