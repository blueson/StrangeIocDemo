using System.Collections;
using System.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;

public class CubeView : View {

    [Inject]
    public IEventDispatcher dispatcher { get; set; }

    public void Init(){
        Debug.Log("CubeView Init");
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("点击了鼠标");
            dispatcher.Dispatch(MediatorEvent.ScoreUpdate);
        }
    }
}
