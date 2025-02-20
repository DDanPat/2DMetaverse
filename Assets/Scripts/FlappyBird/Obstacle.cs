using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float highPosY = 1f;
    public float lowPosy = 1f;

    public float holeSizeMin = 1f;
    public float holeSizeMax = 3f;

    public Transform topObject;
    public Transform bottomObject;

    public float widthPadding = 4f;

    FBGameManager FBgameManager;

    private void Start()
    {
        FBgameManager = FBGameManager.Instace;
    }

    public Vector3 SetRandomPlace(Vector3 LastPosition, int obstaclCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePosition = LastPosition + new Vector3(widthPadding, 0);
        transform.position = placePosition;

        return placePosition;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        FBPlayer player = collision.GetComponent<FBPlayer>();
        if (player != null && player.isDead == false)
            FBgameManager.AddScore(1);
        
    }
}
