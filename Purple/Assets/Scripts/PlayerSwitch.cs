using System;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public static event Action<bool> OnPlayerSwitched;

    private bool _redIsCurrentPlayer = false;

    private void SwitchPlayers()
    {
        if(OnPlayerSwitched != null)
        {
            OnPlayerSwitched(_redIsCurrentPlayer);
        }

        _redIsCurrentPlayer = !_redIsCurrentPlayer;
    }
}
