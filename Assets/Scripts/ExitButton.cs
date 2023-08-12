using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private Button _exitGame;
    public void OnExitGame()
    {
        if(!_exitGame)
            return;
        Application.Quit();
    }
}
