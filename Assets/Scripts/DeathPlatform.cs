using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using  System.Collections;
using System.Collections.Generic;


public class DeathPlatform : MonoBehaviour
{
    [SerializeField] private PlayerMovement _player;

    private  async void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.TryGetComponent(out _player))
        {
            await Task.Delay(30);
         
            SceneManager.LoadScene(1);
        }
    }
}