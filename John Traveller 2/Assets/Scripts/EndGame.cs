using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    PlayerMovement _playerMovoment;
    GameObject hearts;

    void Start()
    {
        _playerMovoment = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        
    }

    
    void Update()
    {
        if (_playerMovoment.hp <= 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            
        }
        
    }

    public void End()
    {
        SceneManager.LoadScene("StartMenu");
    }

}
