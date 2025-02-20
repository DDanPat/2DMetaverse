using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionController : MonoBehaviour
{
    UIManager uimanager;
    [SerializeField] private GameObject PotalOn;
    [SerializeField] private TextMeshProUGUI InteractionText;

    bool potal = false;
    bool statue = false;
    private void Awake()
    {
        uimanager = FindAnyObjectByType<UIManager>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (statue)
            {
                uimanager.SetRankUI();
                InteractionText.gameObject.SetActive(false);
            }
            if (potal) SceneLoadManager.instance.FlappyBirdSceneLoad();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Statue")
        {
            Debug.Log("Statue On");
            InteractionText.gameObject.SetActive(true);
            statue = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (statue == true) statue = false;
        InteractionText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Potal")
        {
            Debug.Log("Potal On");
            InteractionText.gameObject.SetActive(true);
            PotalOn.SetActive(true);
            potal = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (potal == true)
        {
            potal = false;
            InteractionText.gameObject.SetActive(false);
            PotalOn.SetActive(false);
        } 
    }

}
