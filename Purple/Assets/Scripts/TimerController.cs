using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    private const float TIME_TO_CHANGE = 7.95f;
    private float _remainingTime;

    private Text _timerText;

    private void Start()
    {
        _timerText = GetComponent<Text>();
        _remainingTime = TIME_TO_CHANGE;
    }

    private void Update()
    {
        _remainingTime -= Time.deltaTime;
        _timerText.text = _remainingTime.ToString("F2");

        if (!(_remainingTime < 0)) return;
        
        PlayerSwitch.SwitchPlayers();
        _remainingTime = TIME_TO_CHANGE;
    }
}
