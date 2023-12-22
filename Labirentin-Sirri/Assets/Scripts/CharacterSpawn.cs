using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class CharacterSpawn : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        Invoke("SpawnObject", 1);
    }

    void SpawnObject()
    {
        Instantiate(target, transform.position, transform.rotation);
    }
}
