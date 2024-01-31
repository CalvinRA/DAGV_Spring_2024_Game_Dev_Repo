using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyRestoreEventBehaviour : MonoBehaviour
{
    public UnityEvent restoreEvent;

    private void OnEnable()
    {
        restoreEvent.Invoke();
    }
    
}
