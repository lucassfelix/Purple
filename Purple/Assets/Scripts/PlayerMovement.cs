using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _moveSpeed = 6f;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;

    private bool ShouldMove => _moveDirection != Vector3.zero;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

     void FixedUpdate() 
    {
        if(ShouldMove)
        {
            _rigidbody.velocity = _moveDirection * _moveSpeed;
        }    
    }
}
