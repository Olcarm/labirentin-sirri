using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    private bool _deadTimeActive = false;

    public UnityEvent onPressed;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button" && !_deadTimeActive)
        {
            onPressed?.Invoke();
        }
    }
}
