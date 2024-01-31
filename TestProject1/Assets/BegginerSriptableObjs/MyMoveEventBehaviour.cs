using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyMoveEventBehaviour : MonoBehaviour
{
    public UnityEvent movementStartEvent, movementPreviewEvent, movementEndEvent;

    private void OnEnable()
    {
        movementStartEvent.Invoke();
    }

    private void OnMouseOver()
    {
        movementPreviewEvent.Invoke();
    }

    private void OnMouseDown()
    {
        movementEndEvent.Invoke();
    }
}
