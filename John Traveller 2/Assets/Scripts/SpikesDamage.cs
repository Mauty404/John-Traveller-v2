using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesDamage : MonoBehaviour
{

    Animator _animator;
    GameObject player;
    PlayerMovement _playerMovement;


    void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Active", false);
        StartCoroutine(ActiveSpikes());
        player = GameObject.FindGameObjectWithTag("Player");
        _playerMovement = player.GetComponent<PlayerMovement>();
    }


    void Update()
    {
        if (_animator.GetBool("Active") == true)
            if (Vector2.Distance(transform.position, player.transform.position) < 0.44)
            {
                _playerMovement.hp -= 11;
            }
    }

    

    IEnumerator ActiveSpikes()
    {
        while(true)
        {
            _animator.SetBool("Active", false);
            yield return new WaitForSeconds(3f);
            _animator.SetBool("Active", true);
            yield return new WaitForSeconds(1.7f);
        }
    }
}
