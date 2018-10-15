using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;

public class CubeMediator : EventMediator {

    [Inject]
    public CubeView cubeView { get; set; }

    public override void OnRegister()
    {
        cubeView.Init();

        cubeView.dispatcher.AddListener(MediatorEvent.ScoreUpdate, ScoreUpdate);
        dispatcher.AddListener(MediatorEvent.ScoreChange,ScoreChange);

        dispatcher.Dispatch(CommandEnum.RequestScore);
    }

    public override void OnRemove()
    {
        cubeView.dispatcher.RemoveListener(MediatorEvent.ScoreUpdate,ScoreUpdate);
        dispatcher.RemoveListener(MediatorEvent.ScoreChange,ScoreChange);
    }

    public void ScoreChange(IEvent evt){
        Debug.Log("CubeMediator ScoreChange");

        Debug.Log(evt.data);


    }

    public void ScoreUpdate(){
        Debug.Log("ScoreUpdate");
    }
}
