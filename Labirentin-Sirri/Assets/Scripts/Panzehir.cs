using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panzehir : MonoBehaviour
{
    AudioSource _audioSource;
    public string icmeSes;

    public bool IsFinished = false;

    public void Consume()
    {
        if (!IsFinished)
        {
            AudioManager.instance.Play(icmeSes);
            Destroy(this.gameObject);
            IsFinished = true;
        }
    }

}