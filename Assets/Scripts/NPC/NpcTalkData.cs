using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NpcTalkData : MonoBehaviour
{
    public List<string> elflist;
    public List<string> dwarflist;
    public List<string> humanlist;


    private void Awake()
    {
        elflist = new List<string> {
    "바람은 모든 것을 알고 있지... 네가 여기에 온 이유도 말해줄 수 있을까?",
    "숲의 귓가에 속삭여 보게. 네 목소리가 나뭇잎을 흔들지 않는다면 거짓이야.",
    "시간은 우리에게 친절하지만, 인간에게는 그렇지 않지. 하지만... 넌 예외일까?",
    "이 땅의 마법이 흐려지고 있어. 그대가 손을 내밀어 주겠나?",
    "신성한 숲을 지나려는가? 네 발걸음이 가벼운지 시험해 보겠어."};

        dwarflist = new List<string> {
    "우린 바위처럼 단단하지! 하지만 술 한잔 앞에선 무너지는 법이지, 크하하하!",
    "내가 만든 도끼라면 바위도 두 동강 내지! 자, 이거 하나 사지 않겠나?",
    "엘프 녀석들은 너무 가벼워. 어휴, 그들의 맥주 맛이야말로 최악이지!",
    "일할 시간인가? 아니면 한 잔 할 시간인가? 어차피 정답은 후자지!",
    "내 조상 대대로 전해 내려오는 전설의 망치가 있다고! 근데 어디 뒀더라..." };

        humanlist = new List<string> {
    "이곳에서 여행자는 환영받지. 하지만 돈이 없다면 이야기가 좀 다를걸?",
    "왕국은 겉으로는 평온해 보이지만, 그 속은 썩어가고 있어.",
    "너 같은 모험가가 또 나타날 줄이야. 지난번 녀석은 늑대한테 잡아먹혔지.",
    "정의? 명예? 다 좋지만, 빈 주머니엔 아무 소용 없지 않나?",
    "조심하게나, 밤이 되면 거리는 더 위험해지니까."};
    }

}
