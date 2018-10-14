using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreService : IScoresService
{
    public void OnCallback()
    {
        int score = Random.Range(0, 100);
        dispatcher.Dispatch(ServiceEvent.RequestScores, score);
    }

    public void RequestScores(string url)
    {
        Debug.Log(url);
        OnCallback();
    }

    public void UpdateScores(string url, int score)
    {
        Debug.Log(url + "   " + score);
    }

    [Inject]
    public strange.extensions.dispatcher.eventdispatcher.api.IEventDispatcher dispatcher { get; set; }
}
