using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPokeToFingerAttachPoint : MonoBehaviour
{
    public Transform PokeAttachpoint;

    private XRPokeInteractor _xrPokeInteractor;
    void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttachPoint();
    }

    void SetPokeAttachPoint()
    {
        if (PokeAttachpoint == null)
        {
            Debug.Log("Poke Attach Point is null");
            return;
        }
        if (_xrPokeInteractor == null)
        {
            Debug.Log("XR Poke Interactor is null");
            return;
        }
        _xrPokeInteractor.attachTransform = PokeAttachpoint;
    }
}
