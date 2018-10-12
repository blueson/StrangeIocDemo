using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreService : IScoresService
{
    public void OnCallback()
    {
        int score = Random.Range(0, 100);
    }

    public void RequestScores(string url)
    {
        Debug.Log(url);
    }

    public void UpdateScores(string url, int score)
    {
        Debug.Log(url + "   " + score);
    }
}
