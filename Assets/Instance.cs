using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public FollowMainPrefab otherPrefab;
    private void Start()
    {
        var instance = Instantiate(otherPrefab, transform.parent);
        instance.toFollow = this.transform;
    }
}