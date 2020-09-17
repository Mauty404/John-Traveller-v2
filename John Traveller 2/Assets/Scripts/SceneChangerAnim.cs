using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerAnim : MonoBehaviour
{
    public Animator _animator;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            FadeToLevel();
    }

    public void FadeToLevel ()
    {
        _animator.SetTrigger("FadeOut");
    }

    public void FadeToPrev()
    {
        _animator.SetTrigger("FadeOutPrev");
    }

    public void FadeToStart()
    {
        _animator.SetTrigger("FadeOutStart");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PrevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void StartScene()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
