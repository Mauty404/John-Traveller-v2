using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerAnim : MonoBehaviour
{
    public Animator _animator;
    int globalMode = 1;
    
    enum Mode
    {
        NextScene = 1,
        PrevScene,
        StartScene
    }


    public void Fade(int scene)
    {
        if (scene == 1)
            globalMode = (int)Mode.NextScene;

        else if (scene == 2)
            globalMode = (int)Mode.PrevScene;

        else if (scene == 3)
            globalMode = (int)Mode.StartScene;

        _animator.SetTrigger("FadeOut");
    }

    public void FadeToScene()
    {
        switch (globalMode)
        {
            case 1:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case 2:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                break;
            case 3:
                SceneManager.LoadScene("StartMenu");
                break;
        }
    }
}
