using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static List<string> dontDestroyObject = new List<string>(); // GameManger.cs를 담을 리스트

    static GameManager gameManager;

    public int Bastscore = 0;

    public List<int> Rank;

    public static GameManager Instace { get { return gameManager; } }
    private void Awake()
    {
        Rank = new List<int> { 0, 0, 0, 0, 0 };
        if (dontDestroyObject.Contains(gameObject.name)) // 리스트에 게임 매니저가 있는지 확인
        {
            Destroy(gameObject); //있으면 파괴
            return;
        }
        gameManager = this;  

        dontDestroyObject.Add(gameObject.name);//없으면 추가
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateScore(int score) //랭크 순위 정렬 알고리즘
    {
        for (int i = 0; i < Rank.Count - 2; i++)
        {
            if (score > Rank[i])
            {
                Rank[i + 2] = Rank[i + 1];
                Rank[i + 1] = Rank[i];
                Rank[i] = score;
                break;
            }
        }
        Bastscore = Rank[0];

    }



}
