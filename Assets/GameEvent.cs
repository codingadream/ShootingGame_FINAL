using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvent : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public static event Action OnPlayerWin;

    public static void TriggerPlayerDeath()
    {
        OnPlayerDeath?.Invoke();
    }

    public static void TriggerPlayerWin()
    {
        OnPlayerWin?.Invoke();
    }
}
