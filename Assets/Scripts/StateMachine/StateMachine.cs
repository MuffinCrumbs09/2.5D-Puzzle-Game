using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Abstract class
public abstract class StateMachine : MonoBehaviour
{
    private State _curState;
    private bool isSwitching;

    // If not switching state, tick current state
    private void Update()
    {
        _curState.Tick(Time.deltaTime);
    }

    // Switch states to new state if not already switching states
    public void SwitchState(State newState)
    {
        Debug.Log("Switching State");
        if (isSwitching) return;
        isSwitching = true;

        _curState?.Exit();
        _curState = newState;
        _curState?.Enter();

        isSwitching = false;
    }

}
