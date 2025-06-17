using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject _EnemyBulletPrefab;
    [SerializeField]
    private List<Transform> _Muzzle;

    private float _AttackInterval = 1f;
    private int _AttackSpeed = 200;

    private float _timer;
    int r;

    private void Start()
    {
        StartCoroutine("ShootingTimer");
        StartCoroutine("ShootingTimer2");
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _AttackInterval)
        {
            r = Random.Range(0, _Muzzle.Count);
            GameObject obj = Instantiate(_EnemyBulletPrefab, _Muzzle[r].position,Quaternion.identity);
            obj.GetComponent<Rigidbody>().AddForce(_Muzzle[r].transform.forward * _AttackSpeed);
            _timer = 0;
        }
    }

    IEnumerator ShootingTimer()
    {
        yield return new WaitForSeconds(60);
        _AttackInterval = 0.7f;
        _AttackSpeed = 300;
    }
    IEnumerator ShootingTimer2()
    {
        yield return new WaitForSeconds(120);
        _AttackInterval = 0.5f;
        _AttackSpeed = 500;
    }
}
