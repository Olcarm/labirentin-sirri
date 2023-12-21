using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panzehir : MonoBehaviour
{

    public bool IsFinished = false;
    void Start()
    {

        
    }

    [ContextMenu("Consume")]
    public void Consume()
    {
        if (!IsFinished)
        {
            AudioManager.instance.Play("drinking");
            Destroy(this.gameObject);
            IsFinished = true;
        }
    }

}