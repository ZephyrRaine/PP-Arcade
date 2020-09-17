using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ShowObject : MonoBehaviour
{
    public void ToggleProductVisibility(GameObject product)
    {
        product.SetActive(!product.activeSelf);
    }

}