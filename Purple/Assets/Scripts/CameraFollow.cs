using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    private Rigidbody _playerRigidbody;

    void Awake()
    {
        PlayerSwitch.OnPlayerSwitched += CameraSwitch;
    }

    void Update()
    {
        transform.position = new Vector3(_playerRigidbody.transform.position.x,10,_playerRigidbody.transform.position.z);
    }

    void CameraSwitch(Rigidbody _newPlayerRb)
    {
        _playerRigidbody = _newPlayerRb;
    }



}
