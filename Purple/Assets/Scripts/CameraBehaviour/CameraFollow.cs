using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    private Rigidbody _playerRigidbody;

    private void Awake()
    {
        PlayerSwitch.OnPlayerSwitched += CameraSwitch;
    }
 
    private void Update()
    {
        var playerPosition = _playerRigidbody.transform.position;
        transform.position = new Vector3(playerPosition.x,10,playerPosition.z);
    }

    private void CameraSwitch(Rigidbody newPlayerRb)
    {
        _playerRigidbody = newPlayerRb;
    }

}
