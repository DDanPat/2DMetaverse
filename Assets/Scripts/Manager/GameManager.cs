using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static List<string> dontDestroyObject = new List<string>();

    static GameManager gameManager;

    public int Bastscore = 0;
    public static GameManager Instace { get { return gameManager; } }
    private void Awake()
    {
        if (dontDestroyObject.Contains(gameObject.name))
        {
            Destroy(gameObject);
            return;
        }
        gameManager = this;  
        dontDestroyObject.Add(gameObject.name);
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateScore(int score)
    {
        if (score > Bastscore)
        {
            Bastscore = score;
        }
    }



}
