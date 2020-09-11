using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanels : MonoBehaviour
{
    public void HideInterface()
    {
        InterfaceManager.Instance.HidePanels();
    }
}
