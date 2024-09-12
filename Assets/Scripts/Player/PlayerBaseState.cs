using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Abstract class
public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine _stateMachine;

    // Constructor
    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this._stateMachine = stateMachine;
    }

    protected void Move(Vector3 motion, float deltaTime)
    {
        _stateMachine._rb.AddForce(motion * deltaTime, ForceMode.Force);
    }

    protected Vector3 CalculateMovement()
    {
        Vector3 forward = _stateMachine._cam.transform.forward;
        Vector3 right = _stateMachine._cam.transform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        return forward * _stateMachine._ir.MovementValue.y + right * _stateMachine._ir.MovementValue.x;
    }
}
