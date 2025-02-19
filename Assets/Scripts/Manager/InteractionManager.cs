using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionManager : MonoBehaviour
{
    UIManager uimanager;

    bool potal = false;
    bool statue = false;
    private void Awake()
    {
        uimanager = FindAnyObjectByType<UIManager>();
    }


    private void Update()
    {

        if (statue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                uimanager.SetRankUI();
            }
        }
        if (potal)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("FlappyBird");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Statue")
        {
            Debug.Log("Statue On");
            statue = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Statue Off");
        statue = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Potal")
        {
            Debug.Log("Potal On");
            potal = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Potal off");
        potal = false;
    }

}
