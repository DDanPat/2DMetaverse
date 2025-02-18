using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Statue On");
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Potal On");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneLoadManager.instance.FlappyBirdSceneLoad();
        }
    }
}
