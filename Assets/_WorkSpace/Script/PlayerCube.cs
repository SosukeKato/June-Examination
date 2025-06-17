//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
        }
        SceneManager.LoadScene("GameOverScene");
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
        }
    }
    */
}
