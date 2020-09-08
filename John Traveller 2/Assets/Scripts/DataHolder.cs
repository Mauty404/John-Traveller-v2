using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataHolder : MonoBehaviour
{

    CharacterSelector _characterSelector;
    GameObject backgroundMusic;
    public int ID;
    public bool isMale;

    private void Awake()
    {
        backgroundMusic = GameObject.Find("Background Music");
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(backgroundMusic.gameObject);

    }

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            _characterSelector = FindObjectOfType<CharacterSelector>();
            ID = _characterSelector.ID;
            isMale = _characterSelector.isMale;
        }

        
    }

    
}
