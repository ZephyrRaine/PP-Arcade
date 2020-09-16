using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEntry : MonoBehaviour
{
    public void FindAndActivateScoreManager(bool isMarioKart)
    {
        var allManager = GameObject.Find("ScoreManagerHandler").transform.GetComponentsInChildren<ScoreManager>(true);
        foreach(var m in allManager)
        {
            if (m.isMarioKart && isMarioKart)
            {
                m.gameObject.SetActive(true);
            }
            else if(!m.isMarioKart && !isMarioKart)
            {
                m.gameObject.SetActive(true);
            }
        }
    }

}
