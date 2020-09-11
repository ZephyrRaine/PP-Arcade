using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    public void ToggleProductVisibility(GameObject product)
    {
        product.SetActive(!product.activeSelf);
    }
}