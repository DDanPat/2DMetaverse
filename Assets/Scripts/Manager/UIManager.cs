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

    public GameObject NpcTalkUI;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instace;

        UpdateRank();
    }

    public void SetRankUI() // ��ŷ UI ǥ��
    {
        RankUI.SetActive(true);
    }

    public void SetOnNPCTalkUI() // NPC ��ȭâ ǥ��
    {
        NpcTalkUI.SetActive(true);
    }
    public void SetOffNPCTalkUI() // NPC ��ȭâ �ݱ�
    {
        NpcTalkUI.SetActive(false);
    }

    public void UpdateRank() // ��ŷ ���� ������Ʈ
    {
        rank1.text = gameManager.Rank[0].ToString();
        rank2.text = gameManager.Rank[1].ToString();
        rank3.text = gameManager.Rank[2].ToString();
    }
}
