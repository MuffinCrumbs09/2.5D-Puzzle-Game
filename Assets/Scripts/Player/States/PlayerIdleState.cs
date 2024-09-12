using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    // Constructor
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        //_stateMachine._rb.isKinematic = true;
    }

    public override void Tick(float deltaTime)
    {
        if(_stateMachine._ir.MovementValue.magnitude >= 0.1f)
            _stateMachine.SwitchState(new PlayerWalkState(_stateMachine));
    }

    public override void Exit()
    {
        //_stateMachine._rb.isKinematic = false;
    }
}
