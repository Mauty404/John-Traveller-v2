using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicVolumeController : MonoBehaviour
{
    VolumeController _volumeController;
    GameObject volumeControllerObj;

    private void Start()
    {
        volumeControllerObj = GameObject.Find("Background Music");
        _volumeController = volumeControllerObj.GetComponent<VolumeController>();
    }

    public void SetVolume(float vol)
    {
        _volumeController.volumeLevel = vol;
        PlayerPrefs.SetFloat("volume", vol);
    }
}
