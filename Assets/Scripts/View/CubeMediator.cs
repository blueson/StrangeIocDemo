using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;

public class CubeMediator : Mediator {

    [Inject]
    public CubeView cubeView { get; set; }

    [Inject(ContextKeys.CONTEXT_DISPATCHER)]
    public IEventDispatcher dispatcher { get; set; }

    public override void OnRegister()
    {
        cubeView.Init();

        dispatcher.Dispatch(CommandEnum.RequestScore);
    }

    public override void OnRemove()
    {
        
    }
}
