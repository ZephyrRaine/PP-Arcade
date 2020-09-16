using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpScore : MonoBehaviour
{
    public TMP_InputField arcadeScore;
    public TMP_InputField marioKartMinutes;
    public TMP_InputField marioKartSeconds;
    public TMP_InputField marioKartMilliseconds;

    public bool isMarioKart;

    private void OnEnable()
    {
     arcadeScore.text = "";
     marioKartMinutes.text = "";
     marioKartSeconds.text = "";
     marioKartMilliseconds.text = "";
}

    public string GetName()
    {
        return "Nathalie Ponchard";
    }

    public string GetScore()
    {
        if (isMarioKart)
            return $"{marioKartMinutes.text}:{marioKartSeconds.text}.{marioKartMilliseconds.text}";
        else
            return arcadeScore.text;
    }
}
