using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    private CircleCollider2D _circleCollider2D;
    private GameObject _bullet;

    private void Start()
    {

        _circleCollider2D = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right* _speed * Time.deltaTime);
      
    }


}