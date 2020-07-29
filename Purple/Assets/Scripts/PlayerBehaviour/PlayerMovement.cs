using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float MOVE_SPEED = 6f;
    private Vector3 _moveDirection;

    private Rigidbody _currentRigidbody;

    private bool ShouldMove => _moveDirection != Vector3.zero;

    private void Awake()
    {
        PlayerSwitch.OnPlayerSwitched += SwitchPlayers;
    }


    private void Update()
    {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }


    void SwitchPlayers(Rigidbody newCurrentRb)
    {
            _currentRigidbody = newCurrentRb;
    }

    void FixedUpdate() 
    {
        if(ShouldMove)
        {
            _currentRigidbody.velocity = _moveDirection * MOVE_SPEED;
        }    
    }
}
