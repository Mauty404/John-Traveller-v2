using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataHolder : MonoBehaviour
{
    public static DataHolder Instance;

    CharacterSelector _characterSelector;
    GameObject backgroundMusic;
    protected internal int ID;
    protected internal bool isMale;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
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
