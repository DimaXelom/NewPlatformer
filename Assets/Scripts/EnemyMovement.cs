using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Sequence = DG.Tweening.Sequence;


public class EnemyMovement : MonoBehaviour
{
    
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private int _health = 20;
    
    private EnemyMovement _enemy;
    private Sequence _sequence;
    private Bullet _bullet;
    private const int MAX_HEALTH=100;
    
   

    private void Start()
    {
        _health = MAX_HEALTH;
        _sequence = DOTween.Sequence();
        _sequence.Append(gameObject.transform.DOMove(_startPoint.position, _speed).SetEase(Ease.Linear));
        _sequence.Append(gameObject.transform.DOMove(_endPoint.position, _speed).SetEase(Ease.Linear));
        _sequence.SetLoops(-1);
        _sequence.SetLink(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.TryGetComponent(out _bullet))
        {
            _health = -2;
        }

        if (_health <= 1)
        {
            Destroy(gameObject);
        }
    }
}