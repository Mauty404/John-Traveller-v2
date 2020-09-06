using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{

    CharacterSelector _characterSelector;
    public int ID;
    public bool isMale;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        _characterSelector = FindObjectOfType<CharacterSelector>();
    }


    void Update()
    {
        ID = _characterSelector.ID;
        isMale = _characterSelector.isMale;
    }
}
