using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnishGame : MonoBehaviour
{

    SceneChangerAnim _sceneChangerAnim;
    // Start is called before the first frame update
    void Start()
    {
        _sceneChangerAnim = GameObject.Find("Scene Changer").GetComponent<SceneChangerAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _sceneChangerAnim.Fade(3);
    }
}
