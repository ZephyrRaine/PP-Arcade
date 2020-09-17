using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceFixedPositionRotation : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private void Start()
    {
        Instantiate(prefabToInstantiate, transform.position, transform.rotation);
    }
}
