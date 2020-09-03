using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSelected : MonoBehaviour
{
    public GameObject[] male;
    public GameObject[] female;

    DataHolder _dataHolder;
    GameObject dataHolderObj;

    private void Awake()
    {
        _dataHolder = FindObjectOfType<DataHolder>();
        dataHolderObj = GameObject.Find("Data Holder");
        _dataHolder = dataHolderObj.GetComponent<DataHolder>();

        if (_dataHolder.isMale)
        {
            GameObject player = Instantiate(male[_dataHolder.ID]) as GameObject;
        }
        else
        {
            GameObject player = Instantiate(female[_dataHolder.ID]) as GameObject;
        }
    }
}

