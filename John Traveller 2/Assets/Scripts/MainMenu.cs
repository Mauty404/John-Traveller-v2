using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    CharacterSelector _characterSelector;

    private void Start()
    {
        _characterSelector = GetComponent<CharacterSelector>();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("GAME HAS EXIT");
        Application.Quit();
    }


    public void Select()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (_characterSelector.isMale)
        {
            DontDestroyOnLoad(_characterSelector.male[_characterSelector.ID]);
            _characterSelector.male[_characterSelector.ID].transform.localScale = new Vector3(1f, 1f, 1f);
            _characterSelector.male[_characterSelector.ID].transform.position = new Vector3(2.58f, 1.22f, 0f);
        }
            
        else
            DontDestroyOnLoad(_characterSelector.female[_characterSelector.ID]);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
