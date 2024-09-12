using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    // Constructor
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("Entered Idle");
    }

    public override void Tick(float deltaTime)
    {
        Debug.Log("Idle");
        if(_stateMachine._ir.MovementValue.magnitude >= 0.1f)
            _stateMachine.SwitchState(new PlayerWalkState(_stateMachine));
    }

    public override void Exit()
    {
        Debug.Log("Exited Idle");
    }
}
