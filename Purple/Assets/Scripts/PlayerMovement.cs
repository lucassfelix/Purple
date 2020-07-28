using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _moveSpeed = 6f;
    private Vector3 _moveDirection;

    private Rigidbody _currentRigidbody;
    private Rigidbody _redRigidbody;
    private Rigidbody _blueRigidbody;

    private bool ShouldMove => _moveDirection != Vector3.zero;

    void Awake()
    {
        _redRigidbody = GameObject.Find("RedPlayer").GetComponent<Rigidbody>();
        _blueRigidbody = GameObject.Find("BluePlayer").GetComponent<Rigidbody>();
    }

    void Start()
    {
        _currentRigidbody = _redRigidbody;

        PlayerSwitch.OnPlayerSwitched += SwitchPlayers;
    }

    void Update()
    {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if(Input.GetKeyDown(KeyCode.Space))
            SwitchPlayers(true);

    }


    void SwitchPlayers(bool _isRed)
    {
        if(_isRed)
        {
            //Switch to blue
            _currentRigidbody = _blueRigidbody;
            //return
        }
        else
        {
            //Switch to red
            _currentRigidbody = _redRigidbody;
        }
    }

    void FixedUpdate() 
    {
        if(ShouldMove)
        {
            _currentRigidbody.velocity = _moveDirection * _moveSpeed;
        }    
    }
}
