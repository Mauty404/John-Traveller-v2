﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame2 : MonoBehaviour
{
    public void End()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
