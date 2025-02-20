using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum NpcType
{
    elf,
    dwarf,
    human,
    guide,
    Ignarius, // 전설의 영웅의 검
    barrier
}

public class NpcInfo : MonoBehaviour
{
    [SerializeField] private NpcType type;

    NpcTalkData npcTalkData;
    UIManager uimanager;

    public TextMeshProUGUI NpcName;
    public TextMeshProUGUI NpcTalk;

    public string Name;

    bool guideTalking = false;
    bool IgnariusTalking = false;

    int i = 0;

    private void Start()
    {
        npcTalkData = FindAnyObjectByType<NpcTalkData>();
        uimanager = FindAnyObjectByType<UIManager>();
    }

    public void printText()
    {
        int selet = Random.Range(0, 5);
        switch (type)
        {
            case NpcType.elf:
                NpcTalk.text = npcTalkData.elflist[selet];
                break;
            case NpcType.dwarf:
                NpcTalk.text = npcTalkData.dwarflist[selet];
                break;
            case NpcType.human:
                NpcTalk.text = npcTalkData.humanlist[selet];
                break;
            case NpcType.guide:
                guideTalking = true;
                i = 0;
                break;
            case NpcType.Ignarius:
                IgnariusTalking = true;
                i = 0;
                break;
            case NpcType.barrier:
                NpcTalk.text = npcTalkData.barrierlist[selet];
                break;
        }
    }

    private void Update()
    {
        if (guideTalking)
        {
            NpcTalk.text = npcTalkData.guidelist[i];
            if (Input.GetKeyDown(KeyCode.Space) && i < 4)
            {
                NpcTalk.text = npcTalkData.guidelist[i];
                if (i < 3) i += 1;
            }
        }
        if (IgnariusTalking)
        {
            NpcTalk.text = npcTalkData.Ignariuslist[i];
            if (Input.GetKeyDown(KeyCode.Space) && i < 2)
            {
                NpcTalk.text = npcTalkData.Ignariuslist[i];
                if (i < 1) i += 1;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            printText();
            if (npcTalkData == null)
                Debug.Log("this is null");
            NpcName.text = Name;
            uimanager.SetOnNPCTalkUI();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        uimanager.SetOffNPCTalkUI();
        if (guideTalking == true) guideTalking = false;
    }


}
