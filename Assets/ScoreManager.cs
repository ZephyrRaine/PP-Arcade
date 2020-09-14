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
    public GameObject prefab;
    public List<Score> scores;
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
        Score s = new Score();
        s.name = popUpScore.GetName();
        s.score = popUpScore.GetScore();
        scores.Add(s);
        ManageScores();
        popUpScore.gameObject.SetActive(false);
    }

    private void Start()
    {
        ManageScores();
    }

    public int SortByScore(Score score1, Score score2)
    {
        return score2.score.CompareTo(score1.score);
    }

    public void ManageScores()
    {
        scores.Sort(SortByScore);   

        for(int i = 0; i < scoresTransform.childCount; i++)
        {
            var t = scoresTransform.GetChild(i);
            t.GetChild(0).GetComponent<TMP_Text>().text = GetPosFromIndex(i);
            t.GetChild(1).GetComponent<TMP_Text>().text = scores[i].name;
            t.GetChild(2).GetComponent<TMP_Text>().text = scores[i].score;
        }
    }
}
