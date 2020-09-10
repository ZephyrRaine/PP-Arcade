using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public GameObject product;
    public void ToggleProductVisibility()
    {
        product.SetActive(!product.activeSelf);
    }
}