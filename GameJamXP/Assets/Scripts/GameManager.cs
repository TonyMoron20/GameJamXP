using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool _gameOver = true;
    private UIManager _uiManager;

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    private void Update()
    {
        if(_gameOver)
        {
            Time.timeScale = 0.0f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _gameOver = false;
                Time.timeScale = 1.0f;
                _uiManager.HideTitleScreen();
            }
        }
    }
}
