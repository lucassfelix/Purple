using System;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public static event Action<Rigidbody> OnPlayerSwitched;

    private static bool _redIsCurrentPlayer = true;
    private static Rigidbody _redPlayer;
    private static Rigidbody _bluePlayer;

    private void Awake() {
        _redPlayer = GameObject.Find("RedPlayer").GetComponent<Rigidbody>();
        _bluePlayer = GameObject.Find("BluePlayer").GetComponent<Rigidbody>();
    }

    private void Start()
    {
        OnPlayerSwitched?.Invoke(_redPlayer);
    }

    public static void SwitchPlayers()
    {
        OnPlayerSwitched?.Invoke(_redIsCurrentPlayer ? _bluePlayer : _redPlayer);

        _redIsCurrentPlayer = !_redIsCurrentPlayer;
    }
}
