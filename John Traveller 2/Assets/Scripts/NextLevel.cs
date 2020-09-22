using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    GameObject player;
    SceneChangerAnim _sceneChangerAnim;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _sceneChangerAnim = GameObject.Find("Scene Changer").GetComponent<SceneChangerAnim>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _sceneChangerAnim.Fade(1);
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector3(5.04f, 3.32f, 0f);
    }
}
