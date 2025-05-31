using System.Collections;
using System.Collections.Generic;
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
    // Update is called once per frame
    void Update()
    {
        _timer = Time.deltaTime;

        if (_timer >= _AttackInterval)
        {
            int r = Random.Range(0, _Muzzle.Count);
            Instantiate(_EnemyBulletPrefab, _Muzzle[r].position, Quaternion.identity);
            _timer = 0;
        }
    }
}
