using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSelector : MonoBehaviour
{

    public GameObject[] male;
    public GameObject[] female;
    Vector3 characterPosition;
    Vector3 offScreen;

    int ID;
    bool isMale = true;
    const int max = 4;

    private void Awake()
    {
        characterPosition = new Vector3(530f, 320f, 0f);
        offScreen = new Vector3(-200f, -200f, 0f);
        for (int i = 0; i < max; i++)
        {
            male[i] = Instantiate(male[i]) as GameObject;
            male[i].transform.localScale = new Vector3(150f, 150f, 1f);
            male[i].transform.position = offScreen;
            female[i] = Instantiate(female[i]) as GameObject;
            female[i].transform.localScale = new Vector3(150f, 150f, 1f);
            female[i].transform.position = offScreen;

        }
            
       male[0].transform.position = characterPosition;
    }


    public void Increase()
    {
        ID++;
        if (ID == max)
            ID = 0;

        switch (ID)
        {
            case 0:
                male[3].transform.position = offScreen;
                male[0].transform.position = characterPosition;
                break;
            case 1:
                male[0].transform.position = offScreen;
                male[1].transform.position = characterPosition;
                break;
            case 2:
                male[1].transform.position = offScreen;
                male[2].transform.position = characterPosition;
                break;
            case 3:
                male[2].transform.position = offScreen;
                male[3].transform.position = characterPosition;
                break;
        }
    }

    public void Decrease()
    {
        ID--;
        if (ID == -1)
            ID = 3;

        switch (ID)
        {
            case 0:
                male[1].transform.position = offScreen;
                male[0].transform.position = characterPosition;
                break;
            case 1:
                male[2].transform.position = offScreen;
                male[1].transform.position = characterPosition;
                break;
            case 2:
                male[3].transform.position = offScreen;
                male[2].transform.position = characterPosition;
                break;
            case 3:
                male[0].transform.position = offScreen;
                male[3].transform.position = characterPosition;
                break;
        }
    }
}
