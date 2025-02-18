using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Statue On");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Potal On");
    }
}
