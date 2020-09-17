using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterSelector : MonoBehaviour
{
    List<string> genders = new List<string>() { "MALE", "FEMALE" };

    public TMP_Dropdown dropdown; 

    public GameObject[] male;
    public GameObject[] female;
    Vector3 characterPosition;
    Vector3 offScreen;

    public int ID;
    public bool isMale = true;
    bool changedGender = false;
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

    private void Start()
    {
        dropdown.AddOptions(genders);
    }

    public void Dropdown_IndexChanged(int index)
    {
        if (index == 0)
            Male();
        else
            Female();
    }

    public void Increase()
    {
        if (changedGender == false)
        {
            ID++;
            if (ID == max)
                ID = 0;
        }
        changedGender = false;
        

        int localID = ID;

        switch (ID)
        {
            case 0:
                if (isMale)
                {
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID - 1)].transform.position = offScreen;

                }
                else
                {
                    female[IDClampf(localID - 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                }

                break;
            case 1:
                if (isMale)
                {
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID - 1)].transform.position = offScreen;
                }
                else
                {
                    female[IDClampf(localID - 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                }
                break;
            case 2:
                if (isMale)
                {
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID - 1)].transform.position = offScreen;
                }
                else
                {
                    female[IDClampf(localID - 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                }
                break;
            case 3:
                if (isMale)
                {
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID - 1)].transform.position = offScreen;
                }
                else
                {
                    female[IDClampf(localID - 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID - 1)].transform.position = offScreen;
                }
                break;
        }

    }

    int IDClampf(int ID)
    {
        if (ID == max)
            return 0;
        if (ID == -1)
            return 3;
        else
            return ID;
    }

    public void Decrease()
    {
        ID--;
        if (ID == -1)
            ID = 3;

        int localID = ID;

        switch (ID)
        {
            case 0:
                if (isMale)
                {
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID - 1)].transform.position = offScreen;

                }
                else
                {
                    female[IDClampf(localID + 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                }

                break;
            case 1:
                if (isMale)
                {
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID + 1)].transform.position = offScreen;
                }
                else
                {
                    female[IDClampf(localID + 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                }
                break;
            case 2:
                if (isMale)
                {
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID + 1)].transform.position = offScreen;
                }
                else
                {
                    female[IDClampf(localID + 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                }
                break;
            case 3:
                if (isMale)
                {
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                    male[ID].transform.position = characterPosition;
                    female[ID].transform.position = offScreen;
                    female[IDClampf(localID + 1)].transform.position = offScreen;
                }
                else
                {
                    female[IDClampf(localID + 1)].transform.position = offScreen;
                    female[ID].transform.position = characterPosition;
                    male[ID].transform.position = offScreen;
                    male[IDClampf(localID + 1)].transform.position = offScreen;
                }
                break;
        }
    }

    public void Male()
    {
        isMale = true;
        changedGender = true;
        Increase();
    }

    public void Female()
    {
        isMale = false;
        changedGender = true;
        Increase();
    }

}
