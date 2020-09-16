using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePseudo : MonoBehaviour
{
    public void Pseudo(string _name)
    {
        FindObjectOfType<PseudoHandler>().pseudo = _name;
    }
}
