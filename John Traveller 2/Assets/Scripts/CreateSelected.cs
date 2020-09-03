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
            GameObject player = Instantiate(male[_dataHolder.ID], new Vector3(2.58f, 1.22f, 0f), new Quaternion(0f,0f,0f, 0f)) as GameObject;
        }
        else
        {
            GameObject player = Instantiate(female[_dataHolder.ID], new Vector3(2.58f, 1.22f, 0f), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
        }
    }
}

