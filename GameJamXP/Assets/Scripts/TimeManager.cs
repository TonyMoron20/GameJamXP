using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    private float _maxTime;
    private float _currentTime;
    private bool _activeTime;

    [SerializeField]
    private Slider _slider;

    private void Start()
    {
        TimerOn();
    }

    private void Update()
    {
        if (_activeTime)
        {
            ChangeTime();
        }
    }

    private void ChangeTime()
    {
        _currentTime -= Time.deltaTime;

        if(_currentTime >= 0)
        {
            _slider.value = _currentTime;
        }

        if (_currentTime <= 0)
        {
            Debug.Log("Se acabo el tiempo");
            _activeTime = false;
            ChangeTimer(false);
        }
    }

    private void ChangeTimer(bool state)
    {
        _activeTime = state;
    }

    public void TimerOn()
    {
        _currentTime = _maxTime;
        _slider.maxValue = _maxTime;
        ChangeTimer(true);
    }

    public void TimerOff()
    {
        ChangeTimer(false);
    }
}
