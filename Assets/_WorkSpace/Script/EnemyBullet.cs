using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class EnemyBullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("PlayerWall"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("PlayerWall"))
        {
            Destroy(gameObject);
        }
    }
}
