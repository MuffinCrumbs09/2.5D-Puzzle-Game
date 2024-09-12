using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunState : PlayerBaseState
{
    public PlayerRunState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter() { }
    public override void Exit() { }

    public override void Tick(float deltaTime)
    {
        #region Switch State
        if (!_stateMachine._ir.isSprint)
            _stateMachine.SwitchState(new PlayerWalkState(_stateMachine));
        #endregion

        #region Movement
        Vector3 movement = CalculateMovement();
        Move(movement * _stateMachine.runSpeed, deltaTime);
        #endregion
    }
}
