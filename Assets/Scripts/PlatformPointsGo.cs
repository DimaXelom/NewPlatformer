using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class PlatformPointsGo : MonoBehaviour
{

    [SerializeField] private float _speed = 5f;
    [SerializeField] private Transform[] _moveSpot;
    [SerializeField] private float startWaitTime = 1f;


    private int _randomSpot;
    private float _waitTime;

    private void Start()
    {
        RandomUpdate();
    }

    private void Update()
    {
        MovedByPointsEnemy();

    }


    private void MovedByPointsEnemy()
    {
        transform.position = Vector3.MoveTowards(transform.position, _moveSpot[_randomSpot].position, _speed * Time.deltaTime);
        if (!(Vector2.Distance(transform.position, _moveSpot[_randomSpot].position) <= 0.2)) return;
        if (_waitTime <= 0)
        {
            _randomSpot = Random.Range(0, _moveSpot.Length);
            _waitTime = startWaitTime;
        }
        else
        {
            _waitTime -= Time.deltaTime;
        }
    }

    private void RandomUpdate()
    {
        _randomSpot = Random.Range(0, _moveSpot.Length);
        _waitTime = startWaitTime;
    }



}
