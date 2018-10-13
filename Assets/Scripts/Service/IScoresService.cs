using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;

public interface IScoresService
{

    void RequestScores(string url);
    void OnCallback();
    void UpdateScores(string url, int score);

    IEventDispatcher dispatcher { get; set; }
}