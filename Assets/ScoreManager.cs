using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
public struct Score
{
    public string name;
    public string score;
}

public class ScoreManager : MonoBehaviour
{
    public bool isMarioKart;
    public GameObject prefab;
    public List<Score> scoresModel;
    List<Score> scoresReal;
    public Transform scoresTransform;
    public PopUpScore popUpScore;

    string GetPosFromIndex(int i)
    {
        switch(i)
        {
            case 0: return "1er";
            case 1: return "2ème";
            case 2: return "3ème";
            case 3: return "4ème";
            case 4: return "5ème";
            case 5: return "6ème";
            case 6: return "7ème";
            case 7: return "8ème";
            case 8: return "9ème";
            case 9: return "10ème";
        }
        return "ok";
    }

    public void AddScore()
    {
        //scoresReal = new List<Score>(scoresModel);

        Score s = new Score();
        s.name = popUpScore.GetName();
        s.score = popUpScore.GetScore();
        scoresReal.Add(s);
        ManageScores();
        popUpScore.gameObject.SetActive(false);
    }

    private void Start()
    {
        scoresReal = new List<Score>(scoresModel);
        ManageScores();
    }

    public int SortByScore(Score score1, Score score2)
    {
        if(isMarioKart)
            return score1.score.CompareTo(score2.score);
        else
        {

            return int.Parse(score2.score).CompareTo(int.Parse(score1.score));
        }

    }

    public void ManageScores()
    {
        scoresReal.Sort(SortByScore);   

        for(int i = 0; i < scoresTransform.childCount; i++)
        {
            var t = scoresTransform.GetChild(i);
            t.GetChild(0).GetComponent<TMP_Text>().text = GetPosFromIndex(i);
            t.GetChild(1).GetComponent<TMP_Text>().text = scoresReal[i].name;
            t.GetChild(2).GetComponent<TMP_Text>().text = scoresReal[i].score;
        }
    }
}
