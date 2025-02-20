using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    float offsetX;
    float offsetY;

    [SerializeField] Vector2 minCameraBoundary;
    [SerializeField] Vector2 maxCameraBoundary;

    void Start()
    {
        if (target == null)
            return;

        offsetX = transform.position.x - target.position.x;
        offsetY = transform.position.y - target.position.y;
    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 pos = transform.position;

        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            pos.x = Mathf.Clamp(target.position.x, minCameraBoundary.x, maxCameraBoundary.x) + offsetX;
            pos.y = Mathf.Clamp(target.position.y, minCameraBoundary.y, maxCameraBoundary.y) + offsetY;
        }
        else if (SceneManager.GetActiveScene().name == "FlappyBird")
        {
            pos.x = target.position.x + offsetX;
        }
        
        transform.position = pos;
    }

}
