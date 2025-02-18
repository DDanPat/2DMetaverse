using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using TMPro;
using UnityEngine;

public class FBUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestscoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI startText;

    private void Start()
    {
        if (restartText == null)
            Debug.LogError("restrart text is null");

        if (restartText == null)
            Debug.LogError("strart text is null");

        if (scoreText == null)
            Debug.LogError("score text text is null");

        restartText.gameObject.SetActive(false);
    }
    public void Setstart()
    {
        startText.gameObject.SetActive(false);
    }
    public void SetRestart()
    {
        restartText.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void BestScore(int score)
    {
        bestscoreText.text = score.ToString();
    }
}
