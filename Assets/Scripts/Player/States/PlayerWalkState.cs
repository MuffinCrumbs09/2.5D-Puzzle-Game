using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{
    // Constructor
    public PlayerWalkState(PlayerStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter() { }
    public override void Tick(float deltaTime) 
    {
        #region Switch State
        if (_stateMachine._ir.MovementValue.magnitude < 0.1f)
            _stateMachine.SwitchState(new PlayerIdleState(_stateMachine));

        if (_stateMachine._ir.isSprint)
            _stateMachine.SwitchState(new PlayerRunState(_stateMachine));
        #endregion

        ApplyMovement(deltaTime);
    }
    public override void Exit() { }

    private void ApplyMovement(float deltaTime)
    {
        Vector3 movement = CalculateMovement();
        Move(movement * _stateMachine.walkSpeed, deltaTime);
    }
}
