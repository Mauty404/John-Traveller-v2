using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    GameObject player;

    GameObject dataHolder;
    SceneChangerAnim _sceneChangerAnim;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        dataHolder = GameObject.Find("Data Holder");
        player = GameObject.FindGameObjectWithTag("Player");
        _sceneChangerAnim = GameObject.Find("Scene Changer").GetComponent< SceneChangerAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (GameIsPaused)
                Resume();
            else
                Pause();

    }

    public void Pause()
    {
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        _sceneChangerAnim.Fade(3);
        Time.timeScale = 1f;
        //SceneManager.LoadScene("StartMenu");
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        
        Destroy(dataHolder);
        Destroy(player);
    }
}
