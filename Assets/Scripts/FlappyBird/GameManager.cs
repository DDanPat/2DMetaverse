using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public static GameManager Instace {  get { return gameManager; } }

    private int currentScore = 0;

    bool IsPause;

    UIManager uiManager;

    public UIManager UIManager { get { return uiManager; } }

    private void Awake()
    {
        gameManager = this;
        uiManager = FindAnyObjectByType<UIManager>();
        IsPause = true;
        Time.timeScale = 0;
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
    }
    private void Update()
    {
        if (IsPause)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Time.timeScale = 1;
                uiManager.Setstart();
            }
        }
        
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        uiManager.SetRestart();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Score :" + currentScore);
        uiManager.UpdateScore(currentScore);
    }
}
