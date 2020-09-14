using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpScore : MonoBehaviour
{
    public TMP_InputField nameObject;
    public TMP_InputField arcadeScore;
    public TMP_InputField marioKartMinutes;
    public TMP_InputField marioKartSeconds;
    public TMP_InputField marioKartMilliseconds;

    public bool isMarioKart;

    public string GetName()
    {
        return nameObject.text;
    }

    public string GetScore()
    {
        if (isMarioKart)
            return $"{marioKartMinutes.text}:{marioKartSeconds.text}.{marioKartMilliseconds.text}";
        else
            return arcadeScore.text;
    }
}
