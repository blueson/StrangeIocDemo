using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

public class RequestCommand : EventCommand
{
    [Inject]
    public IScoresService scoreService { get; set; }

    [Inject]
    public ScoresModel scoresModel { get; set; }

    public override void Execute()
    {
        Retain();
        scoreService.dispatcher.AddListener(ServiceEvent.RequestScores, this.OnComplete);
        scoreService.RequestScores("http://www.baidu.com");
    }

    public void OnComplete(IEvent evt)
    {
        Debug.Log("OnComplete" + evt.data);
        scoreService.dispatcher.RemoveListener(ServiceEvent.RequestScores, this.OnComplete);

        scoresModel.scores = (int)evt.data;
        dispatcher.Dispatch(MediatorEvent.ScoreChange,evt.data);

        Release();
    }
}
