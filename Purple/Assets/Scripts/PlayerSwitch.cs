using System;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public static event Action<Rigidbody> OnPlayerSwitched;

    private bool _redIsCurrentPlayer = true;
    private Rigidbody _redPlayer;
    private Rigidbody _bluePlayer;

    void Awake() {
        _redPlayer = GameObject.Find("RedPlayer").GetComponent<Rigidbody>();
        _bluePlayer = GameObject.Find("BluePlayer").GetComponent<Rigidbody>();
    }

    void Start()
    {
        OnPlayerSwitched(_redPlayer);
    }

    private void SwitchPlayers()
    {
        if(OnPlayerSwitched != null)
        {
            if(_redIsCurrentPlayer)
            {
                OnPlayerSwitched(_redPlayer);
            }
            else
            {
                OnPlayerSwitched(_bluePlayer);
            }
        }

        _redIsCurrentPlayer = !_redIsCurrentPlayer;
    }
}
