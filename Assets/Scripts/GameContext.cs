using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using UnityEngine;

public class GameContext : MVCSContext
{

    public GameContext(MonoBehaviour view) : base(view)
    { }

    protected override void mapBindings()
    {
        //command
        commandBinder.Bind(CommandEnum.RequestScore).To<RequestCommand>();

        //service
        injectionBinder.Bind<IScoresService>().To<ScoreService>();

        //model

        //mediator
        mediationBinder.Bind<CubeView>().To<CubeMediator>();

        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
}
