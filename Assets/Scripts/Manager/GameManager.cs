using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static List<string> dontDestroyObject = new List<string>(); // GameManger.cs�� ���� ����Ʈ

    static GameManager gameManager;

    public int Bastscore = 0;

    public List<int> Rank;

    public static GameManager Instace { get { return gameManager; } }
    private void Awake()
    {
        Rank = new List<int> { 0, 0, 0, 0, 0 };
        if (dontDestroyObject.Contains(gameObject.name)) // ����Ʈ�� ���� �Ŵ����� �ִ��� Ȯ��
        {
            Destroy(gameObject); //������ �ı�
            return;
        }
        gameManager = this;  

        dontDestroyObject.Add(gameObject.name);//������ �߰�
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateScore(int score) //��ũ ���� ���� �˰���
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
