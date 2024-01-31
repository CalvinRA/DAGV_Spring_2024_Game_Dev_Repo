using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyAttackEventBehaviour : MonoBehaviour
{
    public UnityEvent attackStartEvent, enemyDamagedEvent, enemyDestroyedEvent;

    private void Awake()
    {
        attackStartEvent.Invoke();
    }

    private void OnDisable()
    {
        enemyDamagedEvent.Invoke();
    }

    private void OnDestroy()
    {
        enemyDestroyedEvent.Invoke();
    }
}
