using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    public static VolumeController Instance;
    AudioSource _audioSource;
    public float volumeLevel = 1f;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            volumeLevel = PlayerPrefs.GetFloat("volume");
        }
        else
            Destroy(gameObject);
    }

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        _audioSource.volume = volumeLevel;
    }
 
}
