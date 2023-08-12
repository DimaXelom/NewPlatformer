using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Menu : MonoBehaviour
{
    [SerializeField] private Button _playGame;
    [SerializeField] private Button _exitGame;


    public void OnStartGame()
    {
        if (!_playGame) return;
        SceneManager.LoadScene(1);
    }

    public void OnExitGame()
    {
        if(!_exitGame)
            return;
        Application.Quit();
    }
} 