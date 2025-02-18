using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FBGameManager : MonoBehaviour
{
    static FBGameManager FBgameManager;

    public static FBGameManager Instace {  get { return FBgameManager; } }

    private int currentScore = 0;

    bool IsPause;

    FBUIManager uiManager;

    public FBUIManager FBUIManager { get { return uiManager; } }

    private void Awake()
    {
        FBgameManager = this;
        uiManager = FindAnyObjectByType<FBUIManager>();
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
