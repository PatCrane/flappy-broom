using System;
using UnityEngine;

public class MobCollision : MonoBehaviour
{
    public static event Action OnMobCollision;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            // Emit the event

            OnMobCollision?.Invoke();

            Debug.Log("MOB COLLIDED");
        }
    }
}
