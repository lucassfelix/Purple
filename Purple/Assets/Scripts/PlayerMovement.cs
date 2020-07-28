using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _moveSpeed = 6f;
    private Vector3 _moveDirection;

    private Rigidbody _currentRigidbody;

    private bool ShouldMove => _moveDirection != Vector3.zero;

    void Awake()
    {
        PlayerSwitch.OnPlayerSwitched += SwitchPlayers;
    }


    void Update()
    {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }


    void SwitchPlayers(Rigidbody _newCurrentRb)
    {
            _currentRigidbody = _newCurrentRb;
    }

    void FixedUpdate() 
    {
        if(ShouldMove)
        {
            _currentRigidbody.velocity = _moveDirection * _moveSpeed;
        }    
    }
}
