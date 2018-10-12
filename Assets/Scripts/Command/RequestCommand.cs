using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

public class RequestCommand : Command {

    [Inject]
    public IScoresService scoreService { get; set; }

    public override void Execute()
    {
        scoreService.RequestScores("http://www.baidu.com");
    }
}
