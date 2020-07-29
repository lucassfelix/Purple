using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float _moveSpeed = 7f;
    private Vector3 _initialTouchPosition;
    private Vector3 _moveDirection;
    private Camera _camera;

    public Joystick joystick;

    private Rigidbody _currentRigidbody;

    private bool ShouldMove => _moveDirection != Vector3.zero;

    private void Awake()
    {
        PlayerSwitch.OnPlayerSwitched += SwitchPlayersMovement;
        _camera = Camera.main;
    }

    private void Update()
    {
        _moveDirection = new Vector3(joystick.Horizontal, 0, joystick.Vertical).normalized;
    }


    void SwitchPlayersMovement(Rigidbody newCurrentRb)
    {
        _initialTouchPosition = Vector3.zero;
        _currentRigidbody = newCurrentRb;
    }

    void FixedUpdate() 
    {
        if(ShouldMove)
        {
            _currentRigidbody.velocity = _moveDirection * _moveSpeed;
        }    
    }
}
