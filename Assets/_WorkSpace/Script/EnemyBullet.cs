using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Rigidbody))]
public class EnemyBullet : MonoBehaviour
{
    //private void OnTriggerEnter(Collider collision)
    //{
    //    if(collision.CompareTag("PlayerWall"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerWall"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
