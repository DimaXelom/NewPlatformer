using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiseRound : MonoBehaviour
{
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private string _menuSceneName;

    private void MenuButtonClicked()
    {
        _sceneLoader.LoadScene(_menuSceneName);
    }
}