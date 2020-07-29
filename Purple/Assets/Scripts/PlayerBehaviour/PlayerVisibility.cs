using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerVisibility : MonoBehaviour
{

    private FieldOfView _currentViewFilter;

    private void Start()
    {
        PlayerSwitch.OnPlayerSwitched += SwitchPlayerVisibility;
        GameObject.Find("BluePlayer").GetComponent<FieldOfView>().SetVisibility(false);
        _currentViewFilter = GameObject.Find("RedPlayer").GetComponent<FieldOfView>();
    }

    private void SwitchPlayerVisibility(Rigidbody newRb)
    {
        _currentViewFilter.SetVisibility(false);
        _currentViewFilter = newRb.gameObject.GetComponent<FieldOfView>();
        _currentViewFilter.SetVisibility(true);
    }
}
