using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    GameObject _EnemyBulletPrefab;
    [SerializeField]
    List<Transform> _Muzzle;

    float _AttackInterval = 1f;
    int _AttackSpeed = 200;

    float _timer;
    int r;
    GameObject obj;

    void Start()
    {
        StartCoroutine(ShootingTimer(60, 0.7f, 300));
        StartCoroutine(ShootingTimer(120, 0.5f, 500));
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _AttackInterval)
        {
            r = Random.Range(0, _Muzzle.Count);
            obj = Instantiate(_EnemyBulletPrefab, _Muzzle[r].position,Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(_Muzzle[r].forward * _AttackSpeed);
            _timer = 0;
        }

    }

    IEnumerator ShootingTimer(int Wait , float Interval, int Speed)
    {
        yield return new WaitForSeconds(Wait);
        _AttackInterval = Interval;
        _AttackSpeed = Speed;
    }
}
