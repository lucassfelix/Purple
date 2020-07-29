using System;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public static event Action<Rigidbody> OnPlayerSwitched;

    private bool _redIsCurrentPlayer = true;
    private Rigidbody _redPlayer;
    private Rigidbody _bluePlayer;

    private void Awake() {
        _redPlayer = GameObject.Find("RedPlayer").GetComponent<Rigidbody>();
        _bluePlayer = GameObject.Find("BluePlayer").GetComponent<Rigidbody>();
    }

    private void Start()
    {
        OnPlayerSwitched?.Invoke(_redPlayer);
    }

    private void SwitchPlayers()
    {
        OnPlayerSwitched?.Invoke(_redIsCurrentPlayer ? _redPlayer : _bluePlayer);

        _redIsCurrentPlayer = !_redIsCurrentPlayer;
    }
}
