using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NpcTalkData : MonoBehaviour
{
    public List<string> elflist;
    public List<string> dwarflist;
    public List<string> humanlist;
    public List<string> guidelist;
    public List<string> Ignariuslist;

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
        guidelist = new List<string> {
    "오! 새로운 얼굴이네? 처음 왔다면 내가 좀 알려줄게!\n\n[스페이스바를 눌러 다음 대화로 넘어갈 수 있다.]",
    "저기 오른쪽에 보이는 포탈 보이지? 스페이스바를 눌러 상호작용하면 미니게임에 들어갈 수 있어! 실력을 시험해보는 거지. 꽤 재미있으니까 한 번 도전해보는 것도 나쁘지 않을 걸?  [계속]",
    "그리고 바로 옆에 있는 커다란 동상, 눈에 띄지? 스페이스바를 눌러 상호작용하면 랭킹을 확인할 수 있어. 네가 얼마나 잘했는지, 다른 사람들은 얼마나 대단한지 확인할 수 있다고!  [계속]",
    "자, 뭐부터 해볼래? 그냥 멍하니 서 있지 말고 한 번 움직여보라고! 하하!"};
        Ignariuslist = new List<string> {
    "이그나리우스... 왕국의 마지막 방패였으며, 어둠을 가른 검.\n\r이곳에 잠든 용사는 홀로 수천의 적을 막아냈고, 그 끝에서 왕국을 지켜냈다.\n\r전쟁이 끝난 뒤, 그는 검을 내려놓았고, 사람들은 이곳을 성지로 삼았다.  [계속]",
    "\r그러나 검은 아직도 미세하게 떨리고 있다.\r\n그것은 새로운 주인을 기다리는 것인가, 아니면 과거의 기억을 속삭이고 있는 것인가?" };
    }
        


}
