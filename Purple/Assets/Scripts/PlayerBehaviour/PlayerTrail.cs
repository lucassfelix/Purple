using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrail : MonoBehaviour
{
    private TrailRenderer _currentPlayerTrail;
    void Start()
    {
        PlayerSwitch.OnPlayerSwitched += SwitchTrailOrder;
        _currentPlayerTrail = GameObject.Find("RedPlayer").GetComponent<TrailRenderer>();
    }

    private void SwitchTrailOrder(Rigidbody newRb)
    {
        _currentPlayerTrail.sortingOrder = 0;
        _currentPlayerTrail = newRb.GetComponent<TrailRenderer>();
        _currentPlayerTrail.sortingOrder = 1;
    }
}
