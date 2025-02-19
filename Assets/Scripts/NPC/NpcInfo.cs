using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum NpcType
{
    elf,
    dwarf,
    human
}

public class NpcInfo : MonoBehaviour
{
    [SerializeField] private NpcType type;

    NpcTalkData npcTalkData;
    UIManager uimanager;

    public TextMeshProUGUI NpcName;
    public TextMeshProUGUI NpcTalk;

    public string Name;

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
    }


}
