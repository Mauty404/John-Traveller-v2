using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    CharacterSelector _characterSelector;
    SceneChangerAnim _sceneChangerAnim;


    
    private void Start()
    {
        _characterSelector = GetComponent<CharacterSelector>();
        _sceneChangerAnim = GameObject.Find("Scene Changer").GetComponent<SceneChangerAnim>();
    }

    public void NewGame()
    {
        _sceneChangerAnim.FadeToLevel();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("GAME HAS EXIT");
        Application.Quit();
    }


    public void Select()
    {
        _sceneChangerAnim.FadeToLevel();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (_characterSelector.isMale)
        {
            DontDestroyOnLoad(_characterSelector.male[_characterSelector.ID]);
            _characterSelector.male[_characterSelector.ID].transform.localScale = new Vector3(1f, 1f, 1f);
            _characterSelector.male[_characterSelector.ID].transform.position = new Vector3(2.58f, 1.22f, 0f);
        }
            
        else
            DontDestroyOnLoad(_characterSelector.female[_characterSelector.ID]);
        _characterSelector.female[_characterSelector.ID].transform.localScale = new Vector3(1f, 1f, 1f);
        _characterSelector.female[_characterSelector.ID].transform.position = new Vector3(2.58f, 1.22f, 0f);
    }

    public void Back()
    {
        _sceneChangerAnim.FadeToPrev();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
