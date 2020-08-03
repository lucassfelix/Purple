using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private const float TIME_TO_CHANGE = 7.95f;
    private bool _levelWon;
    private float _remainingTime;

    private Text _timerText;

    private void Start()
    {
        PlayerSwitch.OnLevelWon += WinLevel;
        _timerText = GetComponent<Text>();
        _remainingTime = TIME_TO_CHANGE;
        _levelWon = false;
    }

    private void WinLevel()
    {
        _levelWon = true;
        _timerText.text = "Congratulations!";
    }

    private void Update()
    {
        _remainingTime -= Time.deltaTime;

        if(!_levelWon) UpdateTimerText();
        
        if (!(_remainingTime < 0)) return;
        
        PlayerSwitch.SwitchPlayers();
        _remainingTime = TIME_TO_CHANGE;
    }

    private void UpdateTimerText()
    {
        _timerText.text = _remainingTime.ToString("F2");
    }
}
