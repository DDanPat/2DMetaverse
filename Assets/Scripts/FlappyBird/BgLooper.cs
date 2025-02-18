using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int numBgCount = 5;

    public int obstacleCount = 0;
    public Vector3 obstacleLastPostion = Vector3.zero;

    private void Start()
    {
        //씬에 존재하는 모든 Obstacle 객체를 찾아 배열에 저장
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();

        // 첫 번째 장애물의 위치를 obstacleLastPostion에 저장
        obstacleLastPostion = obstacles[0].transform.position;

        // 장애물 개수를 저장
        obstacleCount = obstacles.Length;

        // 모든 장애물의 위치를 랜덤하게 설정
        for (int i = 0; i < obstacleCount; i++)
        {
            obstacleLastPostion = obstacles[i].SetRandomPlace(obstacleLastPostion, obstacleCount);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerd:" + collision.name);

        // 충돌한 오브젝트가 "BackGround" 태그를 가지고 있는지 확인
        if (collision.CompareTag("BackGround"))
        {
            // 배경 오브젝트의 가로 길이를 가져옴
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            // 배경 오브젝트의 현재 위치를 저장
            Vector3 pos = collision.transform.position;

            // 배경을 오른쪽으로 이동시켜 배경을 반복되도록 설정
            pos.x += widthOfBgObject * numBgCount;
            collision.transform.position = pos; 
            return;
        }


        // 충돌한 오브젝트가 Obstacle 컴포넌트를 가지고 있는지 확인
        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            // 장애물의 위치를 랜덤하게 재배치
            obstacleLastPostion = obstacle.SetRandomPlace(obstacleLastPostion, obstacleCount);
        }
    }
}
