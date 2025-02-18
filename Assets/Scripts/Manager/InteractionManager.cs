using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionManager : MonoBehaviour
{
    UIManager uimanager;

    private void Awake()
    {
        uimanager = FindAnyObjectByType<UIManager>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Statue On");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            uimanager.SetRankUI();
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Potal On");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("On Space");
            SceneLoadManager.instance.FlappyBirdSceneLoad();
        }
    }
}
