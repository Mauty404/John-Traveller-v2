﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UI_KeyHolder : MonoBehaviour
{
    private KeyHolder keyHolder;

    private Transform container;
    private Transform keyTemplate;

    private void Awake()
    {
        keyHolder = GameObject.FindWithTag("Player").GetComponent<KeyHolder>();
        container = transform.GetChild(0).gameObject.transform;
        //container = transform.Find("container");
        keyTemplate = container.transform.GetChild(0).gameObject.transform;
        //keyTemplate = container.Find("keyTemplate");
        keyTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        keyHolder.OnKeysChanged += KeyHolder_OnKeysChanged;
    }

    private void KeyHolder_OnKeysChanged(object sender, System.EventArgs e)
    {
        UpdateVisual();
    }
    private void UpdateVisual()
    {
        foreach (Transform child in container)
        {
            if(child == keyTemplate) continue;
            keyTemplate.gameObject.SetActive(false);
        }
        
        List<Key.KeyType> keyList = keyHolder.GetKeyList();
        for (int i = 0; i < keyList.Count; i++)
        {
            Transform keyTransform = Instantiate(keyTemplate, container);
            keyTemplate.gameObject.SetActive(true);
            keyTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 * i, 0);
        }
    }
}
