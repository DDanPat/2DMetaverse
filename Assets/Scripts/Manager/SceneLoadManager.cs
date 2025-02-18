using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{
    public static SceneLoadManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void FlappyBirdSceneLoad()
    {
        SceneManager.LoadScene("FlappyBird",LoadSceneMode.Single);
    }

    public void MainSceneLoad()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
