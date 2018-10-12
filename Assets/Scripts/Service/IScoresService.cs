using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScoresService
{

    void RequestScores(string url);
    void OnCallback();
    void UpdateScores(string url, int score);
}