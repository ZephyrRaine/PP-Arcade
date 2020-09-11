using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMissions : MonoBehaviour
{
    public GameObject product;
    public void ToggleProductVisibility()
    {
        product.SetActive(!product.activeSelf);
    }
}