using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public bool _gameOver = false;
    private int _score;

    public TMP_Text calificacion;
    public GameObject resultados;

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        if(_gameOver)
        {
            Time.timeScale = 0.0f;
            resultados.SetActive(true);

            if(_score > 100)
            {
                calificacion.text = "A";
            }
            else if(_score > 80 && _score < 100)
            {
                calificacion.text = "B";
            }
            else if (_score > 60 && _score < 80)
            {
                calificacion.text = "C";
            }
            else if (_score < 60)
            {
                calificacion.text = "F";
            }
        }
    }

    public void UpdateScore(int puntos)
    {
        _score += puntos;
    }
}
