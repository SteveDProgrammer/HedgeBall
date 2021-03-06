using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : GameState
{
    private bool _activated = false;

    // ReSharper disable Unity.PerformanceAnalysis
    public override void Enter()
    {
        //GameEnv.instance.maze.GetComponent<MazeControl>().enabled = false;
        GameEnv.instance.ball.GetComponent<BallBehavior>().rb.isKinematic = true;
    }

    public override void Tick()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StateMachine.ChangeState<PlayState>(); //ChangeState<PlayState>();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StateMachine.ChangeState<PauseMenuState>(); //ChangeState<PlayState>();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ButtonClick.Click(1);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            ButtonClick.Click(0);
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public override void Exit()
    {
        //GameEnv.instance.maze.GetComponent<MazeControl>().enabled = true;
        GameEnv.instance.ball.GetComponent<BallBehavior>().rb.isKinematic = false;
        _activated = false;
    }
}
