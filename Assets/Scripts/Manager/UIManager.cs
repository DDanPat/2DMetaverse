using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI rank1;
    public TextMeshProUGUI rank2;
    public TextMeshProUGUI rank3;

    public GameObject RankUI;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instace;

        UpdateRank();
    }

    public void SetRankUI()
    {
        RankUI.SetActive(true);
    }

    public void UpdateRank()
    {
        rank1.text = gameManager.Rank[0].ToString();
        rank2.text = gameManager.Rank[1].ToString();
        rank3.text = gameManager.Rank[2].ToString();
    }
}
