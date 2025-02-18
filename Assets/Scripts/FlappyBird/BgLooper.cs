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
        //���� �����ϴ� ��� Obstacle ��ü�� ã�� �迭�� ����
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();

        // ù ��° ��ֹ��� ��ġ�� obstacleLastPostion�� ����
        obstacleLastPostion = obstacles[0].transform.position;

        // ��ֹ� ������ ����
        obstacleCount = obstacles.Length;

        // ��� ��ֹ��� ��ġ�� �����ϰ� ����
        for (int i = 0; i < obstacleCount; i++)
        {
            obstacleLastPostion = obstacles[i].SetRandomPlace(obstacleLastPostion, obstacleCount);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerd:" + collision.name);

        // �浹�� ������Ʈ�� "BackGround" �±׸� ������ �ִ��� Ȯ��
        if (collision.CompareTag("BackGround"))
        {
            // ��� ������Ʈ�� ���� ���̸� ������
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            // ��� ������Ʈ�� ���� ��ġ�� ����
            Vector3 pos = collision.transform.position;

            // ����� ���������� �̵����� ����� �ݺ��ǵ��� ����
            pos.x += widthOfBgObject * numBgCount;
            collision.transform.position = pos; 
            return;
        }


        // �浹�� ������Ʈ�� Obstacle ������Ʈ�� ������ �ִ��� Ȯ��
        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            // ��ֹ��� ��ġ�� �����ϰ� ���ġ
            obstacleLastPostion = obstacle.SetRandomPlace(obstacleLastPostion, obstacleCount);
        }
    }
}
