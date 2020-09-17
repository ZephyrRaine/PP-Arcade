using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceFixedPositionRotation : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private void Start()
    {
       //Invoke("OK", 0.25f);
    }

    public void OK()
    { 
        //Instantiate(prefabToInstantiate, transform.position, transform.rotation);
    }
}
