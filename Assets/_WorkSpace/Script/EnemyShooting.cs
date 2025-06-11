using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject _EnemyBulletPrefab;
    [SerializeField]
    private float _AttackInterval = 2f;
    [SerializeField]
    private List<Transform> _Muzzle;

    private float _timer;
    int r;
    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _AttackInterval)
        {
             r = Random.Range(0, _Muzzle.Count);
            GameObject obj = Instantiate(_EnemyBulletPrefab, _Muzzle[r].position,Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            _timer = 0;
        }
    }
}
